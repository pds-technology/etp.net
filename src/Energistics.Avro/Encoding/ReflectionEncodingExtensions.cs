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
// 
//-----------------------------------------------------------------------
// This code has been automatically generated.
// Changes will be lost the next time it is regenerated.
//-----------------------------------------------------------------------

using System;
using System.Reflection;

namespace Energistics.Avro.Encoding
{
    /// <summary>
    /// Extension methods for reflection.
    /// </summary>
    public static class ReflectionEncodingExtensions
    {
        public static IChoiceTypeConverter GetChoiceTypeConverter(this MemberInfo memberInfo)
        {
            if (memberInfo == null)
                throw new ArgumentNullException(nameof(memberInfo));

            var union = memberInfo.GetCustomAttribute<AvroChoiceAttribute>();
            if (union == null)
                throw new InvalidOperationException($"{nameof(memberInfo)} missing AvroUnionAttribute.");

            return new ChoiceTypeConverter(union.AvroTypes, union.Types);
        }

        public static INullableTypeConverter GetNullableTypeConverterForStruct<T>(this MemberInfo memberInfo) where T : struct
        {
            if (memberInfo == null)
                throw new ArgumentNullException(nameof(memberInfo));

            var nullable = memberInfo.GetCustomAttribute<AvroNullableAttribute>();
            if (nullable == null)
                throw new InvalidOperationException($"{nameof(memberInfo)} missing AvroNullableAttribute.");

            return new NullableTypeConverter(nullable.NullFirst, nullable.ValueAvroType);
        }

        public static INullableTypeConverter GetNullableTypeConverterForClass<T>(this MemberInfo memberInfo) where T : class
        {
            if (memberInfo == null)
                throw new ArgumentNullException(nameof(memberInfo));

            var nullable = memberInfo.GetCustomAttribute<AvroNullableAttribute>();
            if (nullable == null)
                throw new InvalidOperationException($"{nameof(memberInfo)} missing AvroNullableAttribute.");

            return new NullableTypeConverter(nullable.NullFirst, nullable.ValueAvroType);
        }
    }
}
