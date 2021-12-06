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

using System;
using System.Collections.Generic;
using System.Linq;

namespace Energistics.CodeGen.Code
{
    /// <summary>
    /// Helper extension methods for <see cref="CodeWriter"/>s for code generation.
    /// </summary>
    public static class CodeWriterExtensions
    {
        public static void WriteSeparator(this CodeWriter writer)
        {
            writer.WriteLine();
            writer.WriteLine("=========================================================================================");
            writer.WriteLine("=========================================================================================");
            writer.WriteLine();
        }

        public static void ApacheHeader(this CodeWriter writer, string module, string version, string copyrightYear)
        {
            writer.WriteLine($@"//-----------------------------------------------------------------------");
            writer.WriteLine($@"// {module}, {version}");
            writer.WriteLine($@"// ");
            writer.WriteLine($@"// Copyright {copyrightYear} Energistics");
            writer.WriteLine($@"// ");
            writer.WriteLine($@"// Licensed under the Apache License, Version 2.0 (the ""License"");");
            writer.WriteLine($@"// you may not use this file except in compliance with the License.");
            writer.WriteLine($@"// You may obtain a copy of the License at");
            writer.WriteLine($@"// ");
            writer.WriteLine($@"//     http://www.apache.org/licenses/LICENSE-2.0");
            writer.WriteLine($@"// ");
            writer.WriteLine($@"// Unless required by applicable law or agreed to in writing, software");
            writer.WriteLine($@"// distributed under the License is distributed on an ""AS IS"" BASIS,");
            writer.WriteLine($@"// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.");
            writer.WriteLine($@"// See the License for the specific language governing permissions and");
            writer.WriteLine($@"// limitations under the License.");
            writer.WriteLine($@"//-----------------------------------------------------------------------");
            writer.WriteLine($@"// ");
            writer.WriteLine($@"//-----------------------------------------------------------------------");
            writer.WriteLine($@"// This code has been automatically generated.");
            writer.WriteLine($@"// Changes will be lost the next time it is regenerated.");
            writer.WriteLine($@"//-----------------------------------------------------------------------");
            writer.WriteLine();
        }

        public static void XmlSummary(this CodeWriter writer, string summary)
        {
            writer.WriteLine($"/// <summary>");
            writer.WriteLine($"/// {summary}");
            writer.WriteLine($"/// </summary>");
        }

        public static void ReserveVariables(this CodeWriter writer, params string[] variables)
        {
            foreach (var v in variables)
                writer.GetUniqueVariable(v);
        }

        private static void WithScope(this CodeWriter writer, Action block)
        {
            writer.PushScope();
            block();
            writer.PopScope();
        }

        private static void WithIndentation(this CodeWriter writer, Action block)
        {
            writer.PushIndentation();
            block();
            writer.PopIndentation();
        }

        private static void WithIndentation(this CodeWriter writer, string expression)
        {
            writer.PushIndentation();
            writer.WriteLine(expression);
            writer.PopIndentation();
        }

        private static void WithCurlyBraces(this CodeWriter writer, string terminator, Action block)
        {
            writer.WriteLine($"{{");
            block();
            writer.WriteLine($"}}{terminator}");
        }

        private static void WithMultiLineBlock(this CodeWriter writer, Action block) => writer.WithCurlyBraces(string.Empty, () => writer.WithScope(block));

        private static void WithSingleOrMultiLineBlock(this CodeWriter writer, bool multiLine, Action block)
        {
            if (multiLine)
                writer.WithMultiLineBlock(block);
            else
                writer.WithScope(block);
        }

        public static void WithMultiLineInitializer(this CodeWriter writer, string terminator, Action block) => writer.WithCurlyBraces(terminator, () => writer.WithIndentation(block));

        public static void WithNamespace(this CodeWriter writer, string @namespace, Action block)
        {
            writer.WriteLine($"namespace {@namespace}");
            writer.WithMultiLineBlock(block);
        }

        public static void UsingNamespaces(this CodeWriter writer, params string[] namespaces)
        {
            foreach (var @namespace in namespaces)
                writer.WriteLine($"using {@namespace};");
            writer.WriteLine();
        }

        public static void Attribute(this CodeWriter writer, string name, IEnumerable<string> parameters = null)
        {
            writer.WriteLine($"[{name}{(parameters == null ? string.Empty : $"({string.Join(", ", parameters)})")}]");
        }

        private static void WithEnum(this CodeWriter writer, string access, string name, Action block, string baseType = null)
        {
            var modifiers = $"{access}";
            var inheritance = $"{(!string.IsNullOrEmpty(baseType) ? $": {baseType}" : string.Empty)}";
            writer.WriteLine($"{modifiers} enum {name}{inheritance}");

            writer.WithMultiLineBlock(block);
        }

        public static void WithPublicEnum(this CodeWriter writer, string name, Action block)
            => writer.WithEnum("public", name, block, baseType: null);

        public static void EnumValue(this CodeWriter writer, string name, string value = null)
            => writer.WriteLine($"{name}{(string.IsNullOrEmpty(value) ? string.Empty : $" = {value}")},");

        private static void WithClass(this CodeWriter writer, string access, string name, Action block, string genericType = null, bool @static = false, bool partial = false, bool @sealed = false, IEnumerable<string> inheritedTypes = null, IEnumerable<string> whereClauses = null)
        {
            var modifiers = $"{access}{(@static ? " static" : string.Empty)}{(@sealed ? " sealed" : string.Empty)}{(partial ? " partial" : string.Empty)}";
            var generic = $"{(string.IsNullOrEmpty(genericType) ? string.Empty : $"<{genericType}>")}";
            var inheritance = $"{((inheritedTypes?.Any() ?? false) ? $" : {string.Join(", ", inheritedTypes)}" : string.Empty)}";
            writer.WriteLine($"{modifiers} class {name}{generic}{inheritance}");
            if (whereClauses?.Any() ?? false)
            {
                writer.WithIndentation(() =>
                {
                    foreach (var where in whereClauses)
                        writer.WriteLine(where);
                });
            }

            writer.WithMultiLineBlock(block);
        }

        public static void WithPublicStaticClass(this CodeWriter writer, string name, Action block)
            => writer.WithClass("public", name, block, @static: true);

        public static void WithPublicStaticPartialClass(this CodeWriter writer, string name, Action block)
            => writer.WithClass("public", name, block, @static: true, partial: true);

        public static void WithPublicPartialClass(this CodeWriter writer, string name, IEnumerable<string> inheritedTypes, Action block)
            => writer.WithClass("public", name, block, inheritedTypes: inheritedTypes, partial: true);

        public static void WithInternalStaticClass(this CodeWriter writer, string name, Action block)
            => writer.WithClass("internal", name, block, @static: true);

        public static void WithPublicClass(this CodeWriter writer, string name, IEnumerable<string> inheritedTypes, Action block)
            => writer.WithClass("public", name, block, inheritedTypes: inheritedTypes);

        public static void WithInternalClass(this CodeWriter writer, string name, IEnumerable<string> inheritedTypes, Action block)
            => writer.WithClass("internal", name, block, inheritedTypes: inheritedTypes);


        private static void Field(this CodeWriter writer, string access, string type, string name, bool @static = false, bool @const = false, bool @readonly = false, string initializerExpression = null, Action initializerBlock = null)
        {
            var modifiers = $"{access}{(@static ? " static" : string.Empty)}{(@const ? " const" : string.Empty)}{(@readonly ? " readonly" : string.Empty)}";
            var initialization = $"{((string.IsNullOrEmpty(initializerExpression) && initializerBlock == null) ? string.Empty : (initializerBlock == null ? $" = {initializerExpression}" : $" ="))}";
            var endOfLine = initializerBlock == null ? ";" : string.Empty;

            writer.WriteLine($"{modifiers} {type} {name}{initialization}{endOfLine}");
            if (initializerBlock != null)
                writer.WithMultiLineInitializer(";", initializerBlock);
        }

        public static void PublicStaticReadonlyField(this CodeWriter writer, string type, string name, string initializerExpression = null, Action initializerBlock = null)
            => writer.Field("public", type, name, @static: true, @readonly: true, initializerExpression: initializerExpression, initializerBlock: initializerBlock);

        public static void PrivateStaticReadonlyField(this CodeWriter writer, string type, string name, string initializerExpression = null, Action initializerBlock = null)
            => writer.Field("private", type, name, @static: true, @readonly: true, initializerExpression: initializerExpression, initializerBlock: initializerBlock);

        private static void Property(this CodeWriter writer, string access, string type, string name, bool @new = false, bool @static = false, bool @virtual = false, bool @abstract = false, bool @override = false, string explicitInterface = null, bool hasGet = false, bool hasSet = false, string initializerExpression = null, Action initializerBlock = null, string getExpression = null, Action getBlock = null, string setExpression = null, Action setBlock = null)
        {
            var modifiers = $"{(@new ? "new " : string.Empty)}{(string.IsNullOrEmpty(access) ? string.Empty : $"{access} ")}{(@static ? "static " : string.Empty)}{(@virtual ? "virtual " : string.Empty)}{(@abstract ? "abstract " : string.Empty)}{(@override ? "override " : string.Empty)}";
            var @interface = string.IsNullOrEmpty(explicitInterface) ? string.Empty : $"{explicitInterface}.";

            if ((hasGet && (getBlock != null || getExpression != null)) || (hasSet && (setBlock != null || setExpression != null)))
            {
                if ((hasGet && (getBlock != null || getExpression != null)) && (hasSet && (setBlock != null || setExpression != null)))
                {
                    writer.WriteLine($"{modifiers}{type} {@interface}{name}");
                    writer.WithMultiLineBlock(() =>
                    {
                        if (getExpression != null)
                            writer.WriteLine($"get => {getExpression};");
                        else
                        {
                            writer.WriteLine("get");
                            writer.WithMultiLineBlock(getBlock);
                        }
                        if (setExpression != null)
                            writer.WriteLine($"set => {setExpression};");
                        else
                        {
                            writer.WriteLine("set");
                            writer.WithMultiLineBlock(setBlock);
                        }
                    });
                }
                else if (hasGet && (getBlock != null || getExpression != null))
                {
                    if (getExpression != null)
                        writer.WriteLine($"{modifiers}{type} {@interface}{name} => {getExpression};");
                    else
                    {
                        writer.WriteLine($"{modifiers}{type} {@interface}{name} => {getExpression};");
                        writer.WithMultiLineBlock(() =>
                        {
                            writer.WriteLine("get");
                            writer.WithMultiLineBlock(getBlock);
                        });
                    }
                }
                else if (hasSet && (setBlock != null || setExpression != null))
                {
                    writer.WriteLine($"{modifiers}{type} {@interface}{name}");
                    writer.WithMultiLineBlock(() =>
                    {
                        if (setExpression != null)
                            writer.WriteLine($"set => {setExpression};");
                        else
                        {
                            writer.WriteLine("set");
                            writer.WithMultiLineBlock(setBlock);
                        }
                    });
                }
                else
                    throw new NotImplementedException();
            }
            else
            {
                var getSet = (hasGet || hasSet) ? $" {{ {(hasGet ? "get;" : string.Empty)}{(hasGet && hasSet ? " " : string.Empty)}{(hasSet ? "set;" : string.Empty)} }}" : string.Empty;
                var initialization = $"{((string.IsNullOrEmpty(initializerExpression) && initializerBlock == null) ? string.Empty : (!string.IsNullOrEmpty(initializerExpression) ? $" = {initializerExpression}" : $" ="))}";
                var endOfLine = ((initializerBlock != null) || (initializerExpression == null && initializerBlock == null)) ? string.Empty : ";";
                writer.WriteLine($"{modifiers}{type} {@interface}{name}{getSet}{initialization}{endOfLine}");
                if (initializerBlock != null)
                    writer.WithMultiLineInitializer(";", initializerBlock);
            }
        }

        public static void PublicStaticReadonlyAutoImplementedProperty(this CodeWriter writer, string type, string name, string initializerExpression = null, Action initializerBlock = null)
            => writer.Property("public", type, name, @static: true, hasGet: true, initializerExpression: initializerExpression, initializerBlock: initializerBlock);

        public static void PrivateStaticReadonlyAutoImplementedProperty(this CodeWriter writer, string type, string name, string initializerExpression = null, Action initializerBlock = null)
            => writer.Property("private", type, name, @static: true, hasGet: true, initializerExpression: initializerExpression, initializerBlock: initializerBlock);

        public static void InternalStaticReadonlyAutoImplementedProperty(this CodeWriter writer, string type, string name, string initializerExpression = null, Action initializerBlock = null)
            => writer.Property("internal", type, name, @static: true, hasGet: true, initializerExpression: initializerExpression, initializerBlock: initializerBlock);

        public static void PublicAutoImplementedProperty(this CodeWriter writer, string type, string name, string initializerExpression = null, Action initializerBlock = null)
            => writer.Property("public", type, name, hasGet: true, hasSet: true, initializerExpression: initializerExpression, initializerBlock: initializerBlock);

        public static void ExplicitInterfaceReadonlyProperty(this CodeWriter writer, string type, string name, string explicitInterface, string getExpression = null, Action getBlock = null)
            => writer.Property(null, type, name, explicitInterface: explicitInterface, hasGet: true, getExpression: getExpression, getBlock: getBlock);

        public static void ExplicitInterfaceProperty(this CodeWriter writer, string type, string name, string explicitInterface, string getExpression = null, Action getBlock = null, string setExpression = null, Action setBlock = null)
            => writer.Property(null, type, name, explicitInterface: explicitInterface, hasGet: true, hasSet: true, getExpression: getExpression, getBlock: getBlock, setExpression: setExpression, setBlock: setBlock);

        public static void ReserveParameters(this CodeWriter writer, IEnumerable<MethodParameter> parameters)
        {
            if (parameters == null)
                return;

            writer.ReserveVariables(parameters.Select(p => p.Name).ToArray());
        }

        private static void Method(this CodeWriter writer, string returnType, string name, string access = null, string explicitInterface = null, string genericType = null, bool @static = false, bool @virtual = false, bool @abstract = false, bool @override = false, bool @new = false, bool extension = false, IEnumerable<MethodParameter> parameters = null, IEnumerable<WhereClause> whereClauses = null, string bodyExpression = null, Action bodyBlock = null)
        {
            var modifiers = $"{(@new ? "new " : string.Empty)}{(string.IsNullOrEmpty(access) ? string.Empty : $"{access} ")}{(@static ? "static " : string.Empty)}{(@virtual ? "virtual " : string.Empty)}{(@abstract ? "abstract " : string.Empty)}{(@override ? "override " : string.Empty)}";
            var @interface = string.IsNullOrEmpty(explicitInterface) ? string.Empty : $"{explicitInterface}.";
            var generic = $"{(string.IsNullOrEmpty(genericType) ? string.Empty : $"<{genericType}>")}";
            var @this = extension ? "this " : string.Empty;
            var @params = (parameters?.Any() ?? false) ? string.Join(", ", parameters.Select(p => p.Declaration)) : string.Empty;
            var inlineWhere = (bodyBlock == null && (whereClauses?.Any() ?? false)) ? $" {string.Join(" ", whereClauses.Select(w => w.Declaration))}" : string.Empty;
            var body = $"{((string.IsNullOrEmpty(bodyExpression) && bodyBlock == null) ? string.Empty : (bodyBlock == null ? $" => {bodyExpression}" : string.Empty))}";
            var endOfLine = bodyBlock == null ? ";" : string.Empty;

            writer.WriteLine($"{modifiers}{returnType} {@interface}{name}{generic}({@this}{@params}){inlineWhere}{body}{endOfLine}");
            if (bodyBlock != null)
            {
                if (whereClauses?.Any() ?? false)
                {
                    writer.WithIndentation(() =>
                    {
                        foreach (var where in whereClauses)
                            writer.WriteLine(where.Declaration);
                    });
                }
                writer.WithMultiLineBlock(() =>
                {
                    writer.ReserveParameters(parameters);
                    bodyBlock();
                });
            }
        }

        public static void PublicStaticExtensionMethod(this CodeWriter writer, string returnType, string name, IEnumerable<MethodParameter> parameters, string bodyExpression)
            => writer.Method(returnType, name, access: "public", @static: true, extension: true, parameters: parameters, bodyExpression: bodyExpression);

        public static void GenericPublicStaticExtensionMethod(this CodeWriter writer, string returnType, string name, string genericType, IEnumerable<MethodParameter> parameters, IEnumerable<WhereClause> whereClauses, string bodyExpression)
            => writer.Method(returnType, name, access: "public", @static: true, extension: true, genericType: genericType, parameters: parameters, whereClauses: whereClauses, bodyExpression: bodyExpression);

        public static void WithPublicStaticExtensionMethod(this CodeWriter writer, string returnType, string name, IEnumerable<MethodParameter> parameters, Action bodyBlock)
            => writer.Method(returnType, name, access: "public", @static: true, extension: true, parameters: parameters, bodyBlock: bodyBlock);

        public static void WithGenericPublicStaticExtensionMethod(this CodeWriter writer, string returnType, string name, string genericType, IEnumerable<MethodParameter> parameters, IEnumerable<WhereClause> whereClauses, Action bodyBlock)
            => writer.Method(returnType, name, access: "public", @static: true, extension: true, genericType: genericType, parameters: parameters, whereClauses: whereClauses, bodyBlock: bodyBlock);

        public static void ExplicitInterfaceMethod(this CodeWriter writer, string returnType, string name, string explicitInterface, IEnumerable<MethodParameter> parameters, string bodyExpression)
            => writer.Method(returnType, name, explicitInterface: explicitInterface, parameters: parameters, bodyExpression: bodyExpression);

        public static void WithExplicitInterfaceMethod(this CodeWriter writer, string returnType, string name, string explicitInterface, IEnumerable<MethodParameter> parameters, Action bodyBlock)
            => writer.Method(returnType, name, explicitInterface: explicitInterface, parameters: parameters, bodyBlock: bodyBlock);

        private static void Constructor(this CodeWriter writer, string name, string access = null, bool @static = false, IEnumerable<MethodParameter> parameters = null, string thisExpression = null, string baseExpression = null, Action bodyBlock = null)
        {
            var modifiers = $"{(string.IsNullOrEmpty(access) ? string.Empty : $"{access} ")}{(@static ? "static " : string.Empty)}";
            var @params = (parameters?.Any() ?? false) ? string.Join(", ", parameters.Select(p => p.Declaration)) : string.Empty;

            writer.WriteLine($"{modifiers} {name}({@params})");
            if (baseExpression != null)
                writer.WithIndentation($": base({baseExpression})");
            if (thisExpression != null)
                writer.WithIndentation($": this({thisExpression})");

            writer.WithMultiLineBlock(() =>
            {
                writer.ReserveParameters(parameters);
                bodyBlock();
            });
        }

        public static void WithPublicConstructor(this CodeWriter writer, string name, IEnumerable<MethodParameter> parameters, Action bodyBlock)
            => writer.Constructor(name, access: "public", parameters: parameters, bodyBlock: bodyBlock);

        public static void WithPublicConstructorWithBase(this CodeWriter writer, string name, IEnumerable<MethodParameter> parameters, string baseExpression, Action bodyBlock)
            => writer.Constructor(name, access: "public", parameters: parameters, baseExpression: baseExpression, bodyBlock: bodyBlock);

        public static void DictionaryInitializer(this CodeWriter writer, string key, string value, Action valueBlock = null)
        {
            if (valueBlock == null)
                writer.WriteLine($"[{key}] = {value},");
            else
            {
                writer.WriteLine($"[{key}] = {value}");
                writer.WithMultiLineInitializer(",", valueBlock);
            }
        }

        public static void PropertyInitializer(this CodeWriter writer, string property, string value, Action valueBlock = null)
        {
            if (valueBlock == null)
                writer.WriteLine($"{property} = {value},");
            else
            {
                writer.WriteLine($"{property} = {value}");
                writer.WithMultiLineInitializer(",", valueBlock);
            }
        }

        public static string Declare(this CodeWriter writer, string type, string variablePrefix, string initializerExpression = null, Action initializerBlock = null)
        {
            var var = writer.GetUniqueVariable(variablePrefix);
            var initializer = string.IsNullOrEmpty(initializerExpression) ? string.Empty : $" = {initializerExpression}";
            var endOfLine = initializerBlock == null ? ";" : string.Empty;
            writer.WriteLine($"{type} {var}{initializer}{endOfLine}");
            if (initializerBlock != null)
                writer.WithMultiLineInitializer(";", initializerBlock);

            return var;
        }

        public static string Var(this CodeWriter writer, string variablePrefix, string initializerExpression = null, Action initializerBlock = null) => writer.Declare("var", variablePrefix, initializerExpression: initializerExpression, initializerBlock: initializerBlock);

        public static void ForEach(this CodeWriter writer, string variablePrefix, string enumerable, Action<string> block)
            => writer.ForEach(variablePrefix, enumerable, false, block);

        public static void MultiLineForEach(this CodeWriter writer, string variablePrefix, string enumerable, Action<string> block)
            => writer.ForEach(variablePrefix, enumerable, true, block);

        private static void ForEach(this CodeWriter writer, string variablePrefix, string enumerable, bool multiLine, Action<string> block)
        {
            var var = writer.GetUniqueVariable(variablePrefix);
            writer.WriteLine($"foreach (var {var} in {enumerable})");
            writer.WithSingleOrMultiLineBlock(multiLine, () => block(var));
        }

        public static void For(this CodeWriter writer, string variablePrefix, string variableInitializer, Func<string, string> conditionExpression, Func<string, string> incrementExpression, Action<string> block)
            => writer.For(variablePrefix, variableInitializer, conditionExpression, incrementExpression, false, block);

        public static void MultiLineFor(this CodeWriter writer, string variablePrefix, string variableInitializer, Func<string, string> conditionExpression, Func<string, string> incrementExpression, Action<string> block)
            => writer.For(variablePrefix, variableInitializer, conditionExpression, incrementExpression, true, block);

        private static void For(this CodeWriter writer, string variablePrefix, string variableInitializer, Func<string, string> conditionExpression, Func<string, string> incrementExpression, bool multiLine, Action<string> block)
        {
            var var = writer.GetUniqueVariable(variablePrefix);
            writer.WriteLine($"for (var {var} = {variableInitializer}; {conditionExpression(var)}; {incrementExpression(var)})");
            writer.WithSingleOrMultiLineBlock(multiLine, () => block(var));
        }

        public static void If(this CodeWriter writer, string condition, Action block)
            => writer.If(condition, false, block);

        public static void MultiLineIf(this CodeWriter writer, string condition, Action block)
            => writer.If(condition, true, block);

        private static void If(this CodeWriter writer, string condition, bool multiLine, Action block)
        {
            writer.WriteLine($"if ({condition})");
            writer.WithSingleOrMultiLineBlock(multiLine, block);
        }

        public static void Else(this CodeWriter writer, Action block)
            => writer.Else(false, block);

        public static void MultiLineElse(this CodeWriter writer, Action block)
            => writer.Else(true, block);

        private static void Else(this CodeWriter writer, bool multiLine, Action block)
        {
            writer.WriteLine($"else");
            writer.WithSingleOrMultiLineBlock(multiLine, block);
        }

        public static void While(this CodeWriter writer, string condition, Action block)
            => writer.While(condition, false, block);

        public static void MultiLineWhile(this CodeWriter writer, string condition, Action block)
            => writer.While(condition, true, block);

        private static void While(this CodeWriter writer, string condition, bool multiLine, Action block)
        {
            writer.WriteLine($"while ({condition})");
            writer.WithSingleOrMultiLineBlock(multiLine, block);
        }

        public static void Switch(this CodeWriter writer, string condition, Action block)
        {
            writer.WriteLine($"switch ({condition})");
            writer.WithSingleOrMultiLineBlock(true, block);
        }

        public static void Case(this CodeWriter writer, string @case, string expression)
        {
            writer.WriteLine($"case {@case}: {expression}");
        }
        public static void MultiLineCase(this CodeWriter writer, string @case, Action block)
        {
            writer.WriteLine($"case {@case}:");
            writer.WithIndentation(block);
        }

        public static void DefaultCase(this CodeWriter writer, string expression)
        {
            writer.WriteLine($"default: {expression}");
        }

        public static void Break(this CodeWriter writer) => writer.WriteLine("break;");

        public static void Continue(this CodeWriter writer) => writer.WriteLine("continue;");

        public static void Return(this CodeWriter writer, string value)
        {
            writer.WriteLine($"return {value};");
        }

        public static void YieldReturn(this CodeWriter writer, string value)
        {
            writer.WriteLine($"yield return {value};");
        }
    }
}
