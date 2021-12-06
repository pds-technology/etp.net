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

using Energistics.CodeGen.Avro.Code.TypeInfos;
using System.Collections.Generic;
using System.Linq;

namespace Energistics.CodeGen.Avro.Code
{
    public static class TypeInfoExtensions
    {
        public static IEnumerable<EnumInfo> EnumInfos(this TypeInfoCollection typeInfoCollection)
            => typeInfoCollection.TypeInfosByName.Values.Where(t => t is EnumInfo).Cast<EnumInfo>().OrderBy(t => t.Namespace).ThenBy(t => t.Name);

        public static IEnumerable<FixedInfo> FixedInfos(this TypeInfoCollection typeInfoCollection)
            => typeInfoCollection.TypeInfosByName.Values.Where(t => t is FixedInfo).Cast<FixedInfo>().OrderBy(t => t.Namespace).ThenBy(t => t.Name);

        public static IEnumerable<RecordInfo> RecordInfos(this TypeInfoCollection typeInfoCollection)
            => typeInfoCollection.TypeInfosByName.Values.Where(t => t is RecordInfo).Cast<RecordInfo>().OrderBy(t => t.Namespace).ThenBy(t => t.Name);

        public static IEnumerable<ChoiceInfo> ChoiceInfos(this TypeInfoCollection typeInfoCollection)
            => typeInfoCollection.TypeInfosByDescriptor.Values.Where(t => t is ChoiceInfo).Cast<ChoiceInfo>().OrderBy(t => t.UniqueName);

        public static IEnumerable<NullableInfo> NullableInfos(this TypeInfoCollection typeInfoCollection)
            => typeInfoCollection.TypeInfosByDescriptor.Values.Where(t => t is NullableInfo).Cast<NullableInfo>().OrderBy(t => t.GetDescriptor());

        public static IEnumerable<NullableInfo> NullableInfosWithNestedValue(this TypeInfoCollection typeInfoCollection)
            => typeInfoCollection.TypeInfosByDescriptor.Values.Where(t => t is NullableInfo && t.HasNestedValue()).Select(t => t.ToOriginalOrGenericClone()).DistinctByDescriptor().Cast<NullableInfo>().OrderBy(t => t.GetDescriptor());

        public static IEnumerable<ArrayInfo> ArrayInfosWithNestedValue(this TypeInfoCollection typeInfoCollection)
            => typeInfoCollection.TypeInfosByDescriptor.Values.Where(t => t is ArrayInfo && t.HasNestedValue()).Select(t => t.ToOriginalOrGenericClone()).DistinctByDescriptor().Cast<ArrayInfo>().OrderBy(t => t.GetDescriptor());

        public static IEnumerable<MapInfo> MapInfosWithNestedValue(this TypeInfoCollection typeInfoCollection)
            => typeInfoCollection.TypeInfosByDescriptor.Values.Where(t => t is MapInfo && t.HasNestedValue()).Select(t => t.ToOriginalOrGenericClone()).DistinctByDescriptor().Cast<MapInfo>().OrderBy(t => t.GetDescriptor());

        private static IEnumerable<TypeInfo> DistinctByDescriptor(this IEnumerable<TypeInfo> typeInfos)
        {
            var hashSet = new HashSet<string>();
            foreach (var typeInfo in typeInfos)
            {
                if (hashSet.Add(typeInfo.GetDescriptor()))
                    yield return typeInfo;
            }
        }

        public static string GetUniqueName(this Dictionary<string, int> uniqueNameCounters, string prefix)
        {
            if (!uniqueNameCounters.ContainsKey(prefix))
            {
                uniqueNameCounters[prefix] = 1;
                return prefix;
            }
            else
            {
                var count = uniqueNameCounters[prefix]++;
                return $"{prefix}{count}";
            }
        }

        public static TypeInfo GetInnerTypeInfo(this TypeInfo typeInfo)
        {
            if (typeInfo is NullableInfo n)
                return n.ValueTypeInfo;
            else if (typeInfo is CollectionInfo c)
                return c.ElementTypeInfo;

            return null;
        }

        public static IEnumerable<TypeInfo> GetAllInnerTypeInfos(this TypeInfo typeInfo)
        {
            if (typeInfo is NullableInfo n)
                yield return n.ValueTypeInfo;
            else if (typeInfo is CollectionInfo c)
                yield return c.ElementTypeInfo;
            else if (typeInfo is ChoiceInfo choiceInfo)
            {
                foreach (var t in choiceInfo.ChoiceTypeInfos)
                    yield return t;
            }

            yield break;
        }

        private static bool HasNestedValue(this TypeInfo typeInfo)
        {
            var innerTypeInfo = typeInfo.GetInnerTypeInfo();

            return innerTypeInfo is NullableInfo || innerTypeInfo is CollectionInfo;
        }

        private static TypeInfo ToOriginalOrGenericClone(this TypeInfo typeInfo)
        {
            var innerTypeInfo = typeInfo.GetInnerTypeInfo();
            if (innerTypeInfo == null)
            {
                if (typeInfo is EnumInfo)
                    return EnumInfo.TEnum;
                else if (typeInfo is AvroObjectInfo)
                    return AvroObjectInfo.TAvroObject;
                else
                    return typeInfo;
            }
            else
            {
                var innerOriginalOrGenericClone = innerTypeInfo.ToOriginalOrGenericClone();
                if (typeInfo is ArrayInfo)
                    return new ArrayInfo(null, innerOriginalOrGenericClone);
                else if (typeInfo is MapInfo)
                    return new MapInfo(null, innerOriginalOrGenericClone);
                else if (typeInfo is NullableInfo n)
                    return new NullableInfo(null, innerOriginalOrGenericClone, n.NullFirst, n.UniqueName);
                else
                    return null;
            }
        }
    }
}
