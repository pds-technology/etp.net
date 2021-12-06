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

using Energistics.Json;
using System.IO;

namespace Energistics.Avro.Encoding.Json
{
    /// <summary>
    /// Helper methods for JSON encoding of Avro byte arrays.
    /// </summary>
    public static class BytesEncoding
    {
        /// <summary>
        /// Encodes a byte array.
        /// </summary>
        /// <param name="bytes">The byte array to encode.</param>
        /// <param name="writer">The writer to write the encoded string to.</param>
        public static void Encode(byte[] bytes, TextWriter writer)
        {
            for (int i = 0; i < bytes.Length; i++)
            {
                writer.Write(StringEncoding.CharStrings[bytes[i]]);
            }
        }

        /// <summary>
        /// Encodes a byte array.
        /// </summary>
        /// <param name="bytes">The byte array to encode.</param>
        /// <returns>The encoded byte array.</returns>
        public static string Encode(byte[] bytes)
        {
            using (var writer = new StringWriter())
            {
                Encode(bytes, writer);
                return writer.ToString();
            }
        }

        /// <summary>
        /// Decodes a byte array from a string.
        /// </summary>
        /// <param name="string">The string to decode.</param>
        /// <returns>The decoded byte array.</returns>
        public static byte[] Decode(string @string)
        {
            var bytes = new byte[StringEncoding.GetDecodedCharCount(@string)];
            var b = 0;
            for (int i = 0; i < @string.Length;)
            {
                if (@string[i] == '\\')
                {
                    var c = StringEncoding.DecodeEscapedChar(@string, ref i);
                    if (c >= 256)
                        throw new InvalidDataException($"Invalid byte character in: '{@string}'");
                    bytes[b++] = (byte)c;
                }
                else
                {
                    if (@string[i] >= 256)
                        throw new InvalidDataException($"Invalid byte character in: '{@string}'");
                    bytes[b++] = (byte)@string[i++];
                }
            }

            return bytes;
        }
    }
}
