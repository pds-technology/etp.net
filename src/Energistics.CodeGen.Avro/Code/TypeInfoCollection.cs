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

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Energistics.CodeGen.Avro.Code.TypeInfos;
using Energistics.Avro.Schemas;
using Energistics.Avro.Schemas.Navigation;
using Energistics.CodeGen.Avro.Code.TypeInfos.LogicalTypeInfos;

namespace Energistics.CodeGen.Avro.Code
{
    public sealed class TypeInfoCollection
    {
        public TypeInfoCollection()
            : this(NamingOptions.Default)
        {
        }

        public TypeInfoCollection(NamingOptions namingOptions)
        {
            NamingOptions = namingOptions;
        }

        public Dictionary<string, TypeInfo> TypeInfosByName { get; } = new Dictionary<string, TypeInfo>();

        public Dictionary<string, TypeInfo> TypeInfosByDescriptor { get; } = new Dictionary<string, TypeInfo>();

        private Dictionary<string, int> UniqueNameCounters { get; } = new Dictionary<string, int>();

        private TypeResolverCollection TypeResolverCollection { get; } = new TypeResolverCollection();

        public NamingOptions NamingOptions { get; }

        public void AddTypeCollection(TypeCollection typeCollection)
        {
            var queue = new Queue<Type>(typeCollection.TypesByDescriptor.Values);
            var deferred = new Dictionary<Type, int>();

            while (queue.Count > 0)
            {
                var type = queue.Dequeue();

                var dependencies = type.GetAllDependencies();

                if (!dependencies.All(d => TypeInfosByDescriptor.ContainsKey(d)))
                {
                    var count = dependencies.Count(d => TypeInfosByDescriptor.ContainsKey(d));
                    if (!deferred.TryGetValue(type, out var prevCount) || count > prevCount)
                    {
                        deferred[type] = count;
                        queue.Enqueue(type);
                        continue;
                    }
                    else
                    {
                        throw new InvalidDataException($"Missing dependencies for '{type.GetDescriptor()}'");
                    }
                }

                AddType(type);
            }
        }

        public void AddType(Type type)
        {
            if (type == null)
                throw new System.ArgumentNullException(nameof(type));

            var dependencies = type.GetAllDependencies();

            if (!dependencies.All(TypeInfosByDescriptor.ContainsKey))
                throw new InvalidDataException($"Missing required dependencies for '{type.GetDescriptor()}': {string.Join(", ", dependencies.Where(t => !TypeInfosByDescriptor.ContainsKey(t)).Select(t => $"'{t}'"))}");

            type.CreateTypeInfos(NamingOptions, TypeResolverCollection, TypeInfosByDescriptor, UniqueNameCounters);
            foreach (var typeInfo in TypeInfosByDescriptor.Values.Where(t => t is NamedTypeInfo))
                TypeInfosByName[typeInfo.FullName] = typeInfo;
        }

        public void AddPrimitives()
        {
            foreach (var primitiveInfo in PrimitiveInfo.PrimitiveInfos)
                AddTypeInfo(primitiveInfo);
        }

        public void AddRepresentativeTypes()
        {
            AddTypeInfo(AvroObjectInfo.TAvroObject);
            AddTypeInfo(EnumInfo.TEnum);

            AddTypeInfo(DateInfo.DateDateTimeAsInt());
            AddTypeInfo(DateInfo.DateDateTimeOffsetAsInt());

            AddTypeInfo(DurationInfo.DurationTimeSpanAsIso8601String());
            AddTypeInfo(DurationInfo.DurationTimeSpanAsFixed());

            AddTypeInfo(LocalTimestampMicrosInfo.LocalTimestampMicrosInfoMicrosDateTimeAsLong());
            AddTypeInfo(LocalTimestampMicrosInfo.LocalTimestampMicrosInfoMicrosDateTimeOffsetAsLong());

            AddTypeInfo(LocalTimestampMillisInfo.LocalTimestampMillisInfoDateTimeAsLong());
            AddTypeInfo(LocalTimestampMillisInfo.LocalTimestampMillisInfoDateTimeAsLong());

            AddTypeInfo(MicrosecondsInfo.MicrosecondsInfoTimeSpanAsLong());

            AddTypeInfo(MillisecondsInfo.MillisecondsTimeSpanAsLong());

            AddTypeInfo(TimeMicrosInfo.TimeMicrosTimeSpanAsLong());
            AddTypeInfo(TimeMicrosInfo.TimeMicrosDateTimeAsLong());
            AddTypeInfo(TimeMicrosInfo.TimeMicrosDateTimeOffsetAsLong());

            AddTypeInfo(TimeMillisInfo.TimeMillisTimeSpanAsInt());
            AddTypeInfo(TimeMillisInfo.TimeMillisDateTimeAsInt());
            AddTypeInfo(TimeMillisInfo.TimeMillisDateTimeOffsetAsInt());

            AddTypeInfo(TimestampInfo.TimestampDateTimeAsIso8601String());
            AddTypeInfo(TimestampInfo.TimestampDateTimeOffsetAsIso8601String());

            AddTypeInfo(TimestampMicrosInfo.TimestampMicrosDateTimeAsLong());
            AddTypeInfo(TimestampMicrosInfo.TimestampMicrosDateTimeOffsetAsLong());

            AddTypeInfo(TimestampMillisInfo.TimestampMillisDateTimeAsLong());
            AddTypeInfo(TimestampMillisInfo.TimestampMillisDateTimeOffsetAsLong());

            AddTypeInfo(UuidInfo.UuidGuidAsRfc4122String());
            AddTypeInfo(UuidInfo.UuidGuidAsBytes());
            AddTypeInfo(UuidInfo.UuidGuidAsFixed());
        }

        private void AddTypeInfo(TypeInfo typeInfo)
        {
            var descriptor = typeInfo.GetDescriptor();
            if (TypeInfosByDescriptor.ContainsKey(descriptor))
                return;

            TypeInfosByDescriptor[descriptor] = typeInfo;
            if (typeInfo is NamedTypeInfo)
                TypeInfosByName[descriptor] = typeInfo;
        }

        public void AddTypeResolver(ITypeResolver typeResolver) => TypeResolverCollection.AddResolver(typeResolver);
    }
}
