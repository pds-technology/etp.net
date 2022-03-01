//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2019 Energistics
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
using System.Linq;
using System.Linq.Expressions;

namespace Energistics.Avro.Encoding.Converter
{
    /// <summary>
    /// An base class for converting enum values to and from string or integer values.
    /// </summary>
    public static class AvroEnumConverter<TEnum>
        where TEnum : struct, System.Enum
    {
        /// <summary>
        /// Static constructor.
        /// </summary>
        static AvroEnumConverter()
        {
            if (typeof(TEnum).GetEnumUnderlyingType() != typeof(int))
                throw new System.InvalidOperationException($"Enum values must be integers.");

            var stringIndexLookup = new Dictionary<string, int>();

            var fieldInfos = typeof(TEnum).GetFields().Where(fi => fi.FieldType.IsEnum);

            var counter = 0;
            var stringValues = new List<string>();
            foreach (var fieldInfo in fieldInfos)
            {
                var @int = System.Convert.ToInt32(fieldInfo.GetRawConstantValue());
                if (@int != counter++)
                    throw new System.InvalidOperationException($"Enum values not sequential for {typeof(TEnum).FullName}.");

                var @string = fieldInfo.GetAvroEnumSymbol();
                stringValues.Add(@string);
                stringIndexLookup[@string] = @int;
            }

            EnumToIntConverter = GenerateConverter<TEnum, int>();
            IntToEnumConverter = GenerateConverter<int, TEnum>();
            MaxEnumValue = stringValues.Count - 1;
            StringValues = stringValues.ToArray();
            StringIndexLookup = stringIndexLookup;
        }

        private static System.Func<TFrom, TTo> GenerateConverter<TFrom, TTo>()
        {
            // Based on https://stackoverflow.com/a/26289874/74601
            var parameter = Expression.Parameter(typeof(TFrom));
            var dynamicMethod = Expression.Lambda<System.Func<TFrom, TTo>>(
                Expression.Convert(parameter, typeof(TTo)),
                parameter);
            return dynamicMethod.Compile();
        }

        private static System.Func<TEnum, int> EnumToIntConverter { get; }

        private static System.Func<int, TEnum> IntToEnumConverter { get; }

        private static int MaxEnumValue { get; }

        private static string[] StringValues { get; }

        private static Dictionary<string, int> StringIndexLookup { get; }

        /// <summary>
        /// Checks if the specified enum value index is valid.
        /// </summary>
        /// <param name="index">The enum index value to check.</param>
        /// <returns><c>true</c> if the value index is valid; <c>false</c> otherwise.</returns>
        private static bool IsValidIndex(int index) => index >= 0 && index <= MaxEnumValue;

        /// <summary>
        /// Checks if the specified enum value is valid.
        /// </summary>
        /// <param name="value">The enum value to check.</param>
        /// <returns><c>true</c> if the value is valid; <c>false</c> otherwise.</returns>
        public static bool IsValid(TEnum value) => IsValidIndex(EnumToInt(value));

        /// <summary>
        /// Converts the enum value to its underlying integer value.
        /// </summary>
        /// <param name="value">The enum value to get the underlying integer value for.</param>
        /// <returns>The underlying integer value.</returns>
        public static int EnumToInt(TEnum value) => EnumToIntConverter(value);

        /// <summary>
        /// Converts the enum value to its string value.
        /// </summary>
        /// <param name="value">The enum value to get the string value for.</param>
        /// <returns>The string value.</returns>
        public static string EnumToString(TEnum value) => IndexToString(EnumToInt(value));

        /// <summary>
        /// Converts the integer value to its corresponding enum value.
        /// </summary>
        /// <param name="int">The integer value to get the corresponding enum value for.</param>
        /// <returns>The enum value.</returns>
        public static TEnum IntToEnum(int @int) => IntToEnumConverter(@int);

        /// <summary>
        /// Converts the string value to its corresponding enum value.
        /// </summary>
        /// <param name="string">The string value to get the corresponding enum value for.</param>
        /// <returns>The enum value.</returns>
        public static TEnum StringToEnum(string @string) => IntToEnum(StringToIndex(@string));

        /// <summary>
        /// Converts the enum index value to its string value.
        /// </summary>
        /// <param name="index">The enum index value to get the string value for.</param>
        /// <returns>The string value.</returns>
        private static string IndexToString(int index)
        {
            if (!IsValidIndex(index))
                throw new System.ArgumentException($"Unexpected enum value: {index}.");

            return StringValues[index];
        }

        /// <summary>
        /// Converts the string value to its corresponding enum index value.
        /// </summary>
        /// <param name="string">The string value to get the corresponding enum index value for.</param>
        /// <returns>The enum index value.</returns>
        private static int StringToIndex(string @string)
        {
            if (@string == null)
                throw new System.ArgumentNullException(nameof(@string));
            if (@string.Length == 0)
                throw new System.ArgumentException("Empty string.", nameof(@string));
            if (!StringIndexLookup.TryGetValue(@string, out int index))
                throw new System.ArgumentException($"Invalid enum value: {@string}.", nameof(@string));

            return index;
        }
    }
}
