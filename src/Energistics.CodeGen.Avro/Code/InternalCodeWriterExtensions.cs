//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2021 Energistics
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using Energistics.Avro.Schemas;
using Energistics.CodeGen.Avro.Code.TypeInfos;
using Energistics.CodeGen.Code;
using System.Collections.Generic;
using System.Linq;

namespace Energistics.CodeGen.Avro.Code
{
    /// <summary>
    /// Internal extension methods for <see cref="CodeWriter"/>s for Avro code generation.
    /// </summary>
    internal static class InternalCodeWriterExtensions
    {
        internal static class Params
        {
            internal static MethodParameter Encoder => new MethodParameter { Type = "IAvroEncoder", Name = "encoder" };
            internal static MethodParameter Decoder => new MethodParameter { Type = "IAvroDecoder", Name = "decoder" };
            internal static MethodParameter AvroObject => new MethodParameter { Type = "IAvroObject", Name = "@object" };
            internal static MethodParameter NullableTypeConverter => new MethodParameter { Type = "INullableTypeConverter", Name = "converter" };
            internal static MethodParameter ChoiceTypeConverter => new MethodParameter { Type = "IChoiceTypeConverter", Name = "converter" };
            internal static MethodParameter NestedNullableTypeConverter(int index) => new MethodParameter { Type = "INullableTypeConverter", Name = $"nestedConverter{(index == 0 ? string.Empty : index.ToString())}" };
            internal static MethodParameter NestedChoiceTypeConverter(int index) => new MethodParameter { Type = "IChoiceTypeConverter", Name = $"nestedConverter{(index == 0 ? string.Empty : index.ToString())}" };
            internal static MethodParameter Object => new MethodParameter { Type = "object", Name = "@object" };
        }
        internal static class Types
        {
            internal static TypeInfo AvroObject => AvroObjectInfo.TAvroObject;
            internal static TypeInfo Fixed => FixedInfo.TFixed;
        }

        private static IEnumerable<MethodParameter> GetConverterParameters(TypeInfo typeInfo)
        {
            var count = 0;
            while (typeInfo != null)
            {
                if (typeInfo is NullableInfo)
                    yield return Params.NestedNullableTypeConverter(count++);
                else if (typeInfo is ChoiceInfo)
                    yield return Params.NestedChoiceTypeConverter(count++);

                typeInfo = typeInfo.GetInnerTypeInfo();
            }
        }

        internal static List<string> GetTypeConvertersInternal(this TypeInfo typeInfo)
        {
            var converters = new List<string>();
            while (typeInfo != null)
            {
                if (typeInfo is NullableInfo n)
                    converters.Add(n.Converter);
                else if (typeInfo is ChoiceInfo c)
                    converters.Add(c.Converter);

                typeInfo = typeInfo.GetInnerTypeInfo();
            }

            return converters;
        }

        internal static void DeclareEncodeAvroObjectInternal(this CodeWriter writer)
        {
            var typeInfo = Types.AvroObject;
            var method = MethodInfo.Encode(typeInfo);
            var parameters = new List<MethodParameter> { Params.Encoder, Params.AvroObject };
            var whereClauses = typeInfo.HasGenericConstraint ? new List<WhereClause> { typeInfo.WhereClause } : Enumerable.Empty<WhereClause>();
            writer.GenericPublicStaticExtensionMethod(method.ReturnType, method.FullName(), string.Empty, parameters, whereClauses, $"{Params.AvroObject.Name}.{method.BaseName()}({Params.Encoder.Name})");
        }

        internal static void DeclareDecodeAvroObjectInternal(this CodeWriter writer)
        {
            var typeInfo = Types.AvroObject;
            var method = MethodInfo.Decode(typeInfo);
            var parameters = new List<MethodParameter> { Params.Decoder };
            var whereClauses = typeInfo.HasGenericConstraint ? new List<WhereClause> { typeInfo.WhereClause } : Enumerable.Empty<WhereClause>();
            writer.WithGenericPublicStaticExtensionMethod(method.ReturnType, method.FullName(), string.Empty, parameters, whereClauses, () =>
            {
                var returnVariable = writer.DeclareReturnVariable(method);
                writer.WriteLine($"{returnVariable}.{method.BaseName()}({Params.Decoder.Name});");
                writer.ReturnReturnVariable(method, returnVariable);
            });
        }

        internal static void DeclareAvroFixedEncodeInternal(this CodeWriter writer, FixedInfo fixedInfo)
        {
            var method = MethodInfo.Encode(fixedInfo);
            var parameters = new List<MethodParameter> { Params.Encoder };
            writer.ExplicitInterfaceMethod(method.ReturnType, method.BaseName(), Types.AvroObject.BaseClassOrInterface, parameters, $"{Params.Encoder.Name}.{method.Name()}({fixedInfo.Size}L, (({Types.Fixed.BaseClassOrInterface})this).Bytes)");
        }

        internal static void DeclareAvroFixedDecodeInternal(this CodeWriter writer, FixedInfo fixedInfo)
        {
            var method = MethodInfo.VoidDecode(fixedInfo);
            var parameters = new List<MethodParameter> { Params.Decoder };
            writer.WithExplicitInterfaceMethod(method.ReturnType, method.BaseName(), Types.AvroObject.BaseClassOrInterface, parameters, () =>
            {
                writer.WriteLine($"(({Types.Fixed.BaseClassOrInterface})this).Bytes = {Params.Decoder.Name}.{method.Name()}({fixedInfo.Size}L);");
            });
        }

        internal static void DeclareAvroRecordEncodeInternal(this CodeWriter writer, RecordInfo recordInfo)
        {
            var method = MethodInfo.Encode(recordInfo);
            var parameters = new List<MethodParameter> { Params.Encoder };
            writer.WithExplicitInterfaceMethod(method.ReturnType, method.BaseName(), Types.AvroObject.BaseClassOrInterface, parameters, () =>
            {
                writer.WriteLine($"{Params.Encoder.Name}.{method.Name($"Start")}(\"{recordInfo.AvroFullName}\", {recordInfo.FieldNames.Count});");

                var separator = false;
                for (int i = 0; i < recordInfo.FieldNames.Count; i++)
                {
                    var name = recordInfo.FieldNames[i];
                    var avroName = recordInfo.AvroFieldNames[i];
                    var typeInfo = recordInfo.FieldTypeInfos[i];
                    var fieldMethod = MethodInfo.Encode(typeInfo);
                    var converters = GetTypeConvertersInternal(typeInfo);
                    var encodeParams = new List<string> { $"{name}" };
                    encodeParams.AddRange(converters);
                    if (separator)
                        writer.WriteLine($"{Params.Encoder.Name}.{method.Name($"FieldSeparator")}();");
                    writer.WriteLine($"{Params.Encoder.Name}.{method.Name($"FieldName")}(\"{avroName}\");");
                    writer.WriteLine($"{Params.Encoder.Name}.{fieldMethod.FullName()}({string.Join(", ", encodeParams)});");
                    separator = true;
                }

                writer.WriteLine($"{Params.Encoder.Name}.{method.Name($"End")}();");
            });
        }

        internal static void DeclareAvroRecordDecodeInternal(this CodeWriter writer, RecordInfo recordInfo)
        {
            var method = MethodInfo.VoidDecode(recordInfo);
            var parameters = new List<MethodParameter> { Params.Decoder };
            writer.WithExplicitInterfaceMethod(method.ReturnType, method.BaseName(), Types.AvroObject.BaseClassOrInterface, parameters, () =>
            {
                writer.WriteLine($"{Params.Decoder.Name}.{method.Name($"Start")}(\"{recordInfo.AvroFullName}\", {recordInfo.FieldNames.Count});");

                var separator = false;
                for (int i = 0; i < recordInfo.FieldNames.Count; i++)
                {
                    var name = recordInfo.FieldNames[i];
                    var avroName = recordInfo.AvroFieldNames[i];
                    var typeInfo = recordInfo.FieldTypeInfos[i];
                    var fieldMethod = MethodInfo.Decode(typeInfo);
                    var converters = GetTypeConvertersInternal(typeInfo);
                    var decodeParams = new List<string>();
                    decodeParams.AddRange(converters);
                    if (separator)
                        writer.WriteLine($"{Params.Decoder.Name}.{method.Name($"FieldSeparator")}();");
                    writer.WriteLine($"{Params.Decoder.Name}.{method.Name($"FieldName")}(\"{avroName}\");");
                    writer.WriteLine($"{name} = {Params.Decoder.Name}.{fieldMethod.FullName()}({string.Join(", ", decodeParams)});");
                    separator = true;
                }

                writer.WriteLine($"{Params.Decoder.Name}.{method.Name($"End")}();");
            });
        }

        internal static void DeclareEncodeNullableInternal(this CodeWriter writer, NullableInfo nullable)
        {
            var method = MethodInfo.Encode(nullable);
            var nullMethod = MethodInfo.Encode(PrimitiveInfo.Null);
            var valueMethod = MethodInfo.Encode(nullable.ValueTypeInfo);
            var parameters = new List<MethodParameter> { Params.Encoder, nullable.MethodParameter, Params.NullableTypeConverter };
            var nestedConverters = GetConverterParameters(nullable.ValueTypeInfo).ToList();
            parameters.AddRange(nestedConverters);
            writer.WithTypedEncodingExtensionMethod(method, nullable, parameters, (returnVariable) =>
            {
                var isNull = writer.Var("isNull", $"{nullable.MethodParameter.Name} == null");
                writer.WriteLine($"{Params.Encoder.Name}.{method.BaseName($"UnionStart")}({isNull}, {Params.NullableTypeConverter.Name});");
                writer.If(isNull, () =>
                {
                    writer.WriteLine($"{Params.Encoder.Name}.{nullMethod.Name()}();");
                });
                writer.Else(() =>
                {
                    var encodeParams = new List<string> { nullable.ValueIfNotNull(nullable.MethodParameter.Name) };
                    encodeParams.AddRange(nestedConverters.Select(p => p.Name));
                    writer.WriteLine($"{Params.Encoder.Name}.{valueMethod.FullName()}({string.Join(", ", encodeParams)});");
                });
                writer.WriteLine($"{Params.Encoder.Name}.{method.BaseName($"UnionEnd")}({isNull});");
            });
        }

        internal static void DeclareDecodeNullableInternal(this CodeWriter writer, NullableInfo nullable)
        {
            var method = MethodInfo.Decode(nullable);
            var nullMethod = MethodInfo.Decode(PrimitiveInfo.Null);
            var valueMethod = MethodInfo.Decode(nullable.ValueTypeInfo);
            var parameters = new List<MethodParameter> { Params.Decoder, Params.NullableTypeConverter };
            var nestedConverters = GetConverterParameters(nullable.ValueTypeInfo).ToList();
            parameters.AddRange(nestedConverters);
            writer.WithTypedEncodingExtensionMethod(method, nullable, parameters, (returnVariable) =>
            {
                var isNull = writer.Var("isNull", $"{Params.Decoder.Name}.{method.BaseName($"UnionStart")}({Params.NullableTypeConverter.Name})");
                writer.If(isNull, () =>
                {
                    writer.WriteLine($"{returnVariable} = {Params.Decoder.Name}.{nullMethod.Name(nullable.NullTypeInfix)}{nullable.ValueTypeInfo.GenericTypeDeclaration}();");
                });
                writer.Else(() =>
                {
                    var decodeParams = new List<string>();
                    decodeParams.AddRange(nestedConverters.Select(p => p.Name));
                    writer.WriteLine($"{returnVariable} = {Params.Decoder.Name}.{valueMethod.FullName()}({string.Join(", ", decodeParams)});");
                });
                writer.WriteLine($"{Params.Decoder.Name}.{method.BaseName($"UnionEnd")}({isNull});");
            });
        }

        internal static void DeclareNullableTypeConverterInternal(this CodeWriter writer, NullableInfo nullable, bool @internal)
        {
            if (@internal)
                writer.InternalStaticReadonlyAutoImplementedProperty("NullableTypeConverter", nullable.Converter, $"new NullableTypeConverter({(nullable.NullFirst ? "true" : "false")}, \"{nullable.ValueTypeInfo.AvroFullName}\")");
            else
                writer.PrivateStaticReadonlyAutoImplementedProperty("NullableTypeConverter", nullable.Converter, $"new NullableTypeConverter({(nullable.NullFirst ? "true" : "false")}, \"{nullable.ValueTypeInfo.AvroFullName}\")");
        }

        internal static void DeclareEncodeChoiceInternal(this CodeWriter writer, ChoiceInfo choice)
        {
            var method = MethodInfo.Encode(choice);
            var nullMethod = MethodInfo.Encode(PrimitiveInfo.Null);
            var valueMethods = choice.ChoiceTypeInfos.Select(ti => MethodInfo.Encode(ti)).ToList();
            var parameters = new List<MethodParameter> { Params.Encoder, choice.MethodParameter, Params.ChoiceTypeConverter };
            writer.WithTypedEncodingExtensionMethod(method, choice, parameters, (returnVariable) =>
            {
                var isNull = writer.Var("isNull", $"{choice.MethodParameter.Name} == null");
                var index = writer.Var("index", $"{Params.ChoiceTypeConverter.Name}.ValueToTypeIndex({choice.MethodParameter.Name})");
                writer.WriteLine($"{Params.Encoder.Name}.{method.BaseName($"UnionStart")}({index}, {Params.ChoiceTypeConverter.Name});");
                writer.Switch(index, () =>
                {
                    for (int i = 0; i < valueMethods.Count; i++)
                    {
                        var typeInfo = choice.ChoiceTypeInfos[i];
                        var valueMethod = valueMethods[i];
                        if (typeInfo.IsNull)
                            writer.Case($"{i}", $"{Params.Encoder.Name}.{nullMethod.Name()}(); break;");
                        else
                        {
                            var converters = GetTypeConvertersInternal(typeInfo);
                            var encodeParams = new List<string> { $"({typeInfo.DeclaredType}){choice.MethodParameter.Name}" };
                            encodeParams.AddRange(converters);
                            writer.Case($"{i}", $"{Params.Encoder.Name}.{valueMethod.FullName()}({string.Join(", ", encodeParams)}); break;");
                        }
                    }
                    writer.DefaultCase($"throw new System.IO.InvalidDataException($\"Unexpected type: {{{choice.MethodParameter.Name}?.GetType().FullName}}\");");
                });
                writer.WriteLine($"{Params.Encoder.Name}.{method.BaseName($"UnionEnd")}({isNull});");
            });
        }

        internal static void DeclareDecodeChoiceInternal(this CodeWriter writer, ChoiceInfo choice)
        {
            var method = MethodInfo.Decode(choice);
            var nullMethod = MethodInfo.Decode(PrimitiveInfo.Null);
            var valueMethods = choice.ChoiceTypeInfos.Select(ti => MethodInfo.Decode(ti)).ToList();
            var parameters = new List<MethodParameter> { Params.Decoder, Params.ChoiceTypeConverter };
            writer.WithTypedEncodingExtensionMethod(method, choice, parameters, (returnVariable) =>
            {
                var index = writer.Var("index", $"{Params.Decoder.Name}.{method.BaseName($"UnionStart")}({Params.ChoiceTypeConverter.Name})");
                writer.Switch(index, () =>
                {
                    for (int i = 0; i < valueMethods.Count; i++)
                    {
                        var typeInfo = choice.ChoiceTypeInfos[i];
                        var valueMethod = valueMethods[i];
                        if (typeInfo.IsNull)
                            writer.Case($"{i}", $"{returnVariable} = {Params.Decoder.Name}.{nullMethod.Name(choice.NullTypeInfix)}{typeInfo.GenericTypeDeclaration}(); break;");
                        else
                        {
                            var converters = GetTypeConvertersInternal(typeInfo);
                            var decodeParams = new List<string>();
                            decodeParams.AddRange(converters);
                            writer.Case($"{i}", $"{returnVariable} = {Params.Decoder.Name}.{valueMethod.FullName()}({string.Join(", ", decodeParams)}); break;");
                        }
                    }
                    writer.DefaultCase($"throw new System.IO.InvalidDataException($\"Unexpected type index: {{{index}}}\");");
                });
                var isNull = writer.Var("isNull", $"{returnVariable} == null");
                writer.WriteLine($"{Params.Decoder.Name}.{method.BaseName($"UnionEnd")}({isNull});");
            });
        }

        internal static void DeclareChoiceTypeConverterInternal(this CodeWriter writer, ChoiceInfo choice, bool @internal)
        {
            var avroTypes = string.Join(", ", choice.ChoiceTypeInfos.Select(cti => $"\"{cti.AvroFullName}\""));
            var types = string.Join(", ", choice.ChoiceTypeInfos.Select(cti => cti.IsNull ? "null" : $"typeof({cti.DeclaredType})"));
            if (@internal)
                writer.InternalStaticReadonlyAutoImplementedProperty("ChoiceTypeConverter", choice.Converter, $"new ChoiceTypeConverter(new string[] {{ {avroTypes} }}, new Type[] {{ {types} }})");
            else
                writer.PrivateStaticReadonlyAutoImplementedProperty("ChoiceTypeConverter", choice.Converter, $"new ChoiceTypeConverter(new string[] {{ {avroTypes} }}, new Type[] {{ {types} }})");
        }

        internal static void DeclareEncodeCollectionInternal(this CodeWriter writer, CollectionInfo collection)
        {
            var method = MethodInfo.Encode(collection);
            var valueMethod = MethodInfo.Encode(collection.ElementTypeInfo);
            var keyMethod = collection.ElementsHaveNames ? MethodInfo.Encode(collection.ElementNameTypeInfo) : null;
            var parameters = new List<MethodParameter> { Params.Encoder, collection.MethodParameter };
            var nestedConverters = GetConverterParameters(collection.ElementTypeInfo).ToList();
            parameters.AddRange(nestedConverters);
            writer.WithTypedEncodingExtensionMethod(method, collection, parameters, (returnVariable) =>
            {
                var collectionVariable = collection.MethodParameter.Name;
                writer.WriteLine($"{Params.Encoder.Name}.{method.Name($"Start")}({collectionVariable}.Count, {collectionVariable}.Count);");
                var b = writer.Var("b", "false");
                writer.MultiLineForEach("v", collectionVariable, (v) =>
                {
                    writer.If(b, () => writer.WriteLine($"{Params.Encoder.Name}.{method.Name($"{collection.Element}Separator")}();"));
                    if (collection.ElementsHaveNames)
                        writer.WriteLine($"{Params.Encoder.Name}.{keyMethod.Name()}({collection.ElementVariableName(v)});");
                    var encodeParams = new List<string> { collection.ElementVariableValue(v) };
                    encodeParams.AddRange(nestedConverters.Select(p => p.Name));
                    writer.WriteLine($"{Params.Encoder.Name}.{valueMethod.FullName()}({string.Join(", ", encodeParams)});");
                    writer.WriteLine($"{b} = true;");
                });
                writer.If($"{collectionVariable}.Count > 0", () => writer.WriteLine($"{Params.Encoder.Name}.{method.Name($"BlockStart")}(0);"));
                writer.WriteLine($"{Params.Encoder.Name}.{method.Name($"End")}();");
            });
        }

        internal static void DeclareDecodeCollectionInternal(this CodeWriter writer, CollectionInfo collection)
        {
            var method = MethodInfo.Decode(collection);
            var valueMethod = MethodInfo.Decode(collection.ElementTypeInfo);
            var keyMethod = collection.ElementsHaveNames ? MethodInfo.Decode(collection.ElementNameTypeInfo) : null;
            var parameters = new List<MethodParameter> { Params.Decoder };
            var nestedConverters = GetConverterParameters(collection).ToList();
            parameters.AddRange(nestedConverters);
            writer.WithTypedEncodingExtensionMethod(method, collection, parameters, (returnVariable) =>
            {
                var c = writer.Var("c", $"{Params.Decoder.Name}.{method.Name($"Start")}()");
                var b = writer.Var("b", "false");
                writer.MultiLineWhile($"{c} > 0", () =>
                {
                    writer.MultiLineFor("i", "0", (i) => $"{i} < {c}", (i) => $"{i}++", (i) =>
                    {
                        writer.If(b, () => writer.WriteLine($"{Params.Decoder.Name}.{method.Name($"{collection.Element}Separator")}();"));
                        var decodeParams = new List<string>();
                        decodeParams.AddRange(nestedConverters.Select(p => p.Name));
                        if (collection.ElementsHaveNames)
                        {
                            var key = writer.Var(keyMethod.ReturnVariablePrefix, $"{Params.Decoder.Name}.{keyMethod.Name()}()");
                            writer.WriteLine($"{returnVariable}[{key}] = {Params.Decoder.Name}.{valueMethod.FullName()}({string.Join(", ", decodeParams)});");
                        }
                        else
                        {
                            writer.WriteLine($"{returnVariable}.Add({Params.Decoder.Name}.{valueMethod.FullName()}({string.Join(", ", decodeParams)}));");
                        }
                        writer.WriteLine($"{b} = true;");
                    });
                    writer.WriteLine($"{c} = {Params.Decoder.Name}.{method.Name($"BlockStart")}();");
                });
                writer.WriteLine($"{Params.Decoder.Name}.{method.Name($"End")}();");
            });
        }

        //internal static void FixedMethod(this CodeWriter writer, MethodInfo method, FixedInfo @fixed)
        //{
        //    var parameters = new List<MethodParameter> { Params.Encoder };
        //    writer.ExplicitInterfaceMethod(method.ReturnType, method.Name(), "IAvroObject", parameters, $"{Params.Encoder.Name}.{method.Name(@fixed.TypeInfix)}(Value)");
        //}

        private static string DeclareReturnVariable(this CodeWriter writer, MethodInfo method)
        {
            if (!method.HasReturnValue)
                return null;

            var returnVariable = method.HasReturnValue
                ? writer.Declare(method.ReturnType, method.ReturnVariablePrefix, method.ReturnVariableInitializer)
                : string.Empty;

            return returnVariable;
        }

        private static void ReturnReturnVariable(this CodeWriter writer, MethodInfo method, string returnVariable)
        {
            if (!method.HasReturnValue)
                return;

            writer.Return(returnVariable);
        }

        private static void WithTypedEncodingExtensionMethod(this CodeWriter writer, MethodInfo method, TypeInfo typeInfo, IEnumerable<MethodParameter> parameters, System.Action<string> block)
        {
            var whereClauses = typeInfo.HasGenericConstraint ? new List<WhereClause> { typeInfo.WhereClause } : Enumerable.Empty<WhereClause>();
            System.Action body = () =>
            {
                var returnVariable = writer.DeclareReturnVariable(method);
                block(returnVariable);
                writer.ReturnReturnVariable(method, returnVariable);
            };
            if (typeInfo.InnermostVisibleTypeInfo.HasGenericConstraint)
                writer.WithGenericPublicStaticExtensionMethod(method.ReturnType, method.FullName(), string.Empty, parameters, whereClauses, body);
            else
                writer.WithPublicStaticExtensionMethod(method.ReturnType, method.FullName(), parameters, body);
        }
    }
}
