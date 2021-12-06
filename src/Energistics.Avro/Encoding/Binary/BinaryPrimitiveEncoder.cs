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

using Energistics.Avro.Encoding.Converter;
using System.IO;

namespace Energistics.Avro.Encoding.Binary
{
    /// <summary>
    /// A class for binary Avro primitive encoding
    /// </summary>
    public class BinaryPrimitiveEncoder : IPrimitiveEncoder
    {
        public BinaryPrimitiveEncoder(Stream stream)
        {
            Stream = stream;
        }

        private Stream Stream { get; }

        protected void EncodeRaw(byte[] bytes, int count) => Stream.Write(bytes, 0, count);

        protected void EncodeRaw(byte[] bytes) => EncodeRaw(bytes, bytes.Length);

        public void EncodeNull() { }

        public void EncodeNullClass<T>(T value) where T : class => EncodeNull();

        public void EncodeNullStruct<T>(T? value) where T : struct => EncodeNull();

        public void EncodeBoolean(bool value) => Stream.WriteByte(value ? (byte)1 : (byte)0);

        public void EncodeInt(int value)
        {
            // From: https://github.com/apache/avro/blob/master/lang/csharp/src/apache/main/IO/BinaryEncoder.cs
            ulong n = unchecked((uint)((value << 1) ^ (value >> 31)));
            while ((n & ~0x7FU) != 0)
            {
                Stream.WriteByte((byte)((n & 0x7FU) | 0x80U));
                n >>= 7;
            }
            Stream.WriteByte((byte)n);
        }

        public void EncodeLong(long value)
        {
            // From: https://github.com/apache/avro/blob/master/lang/csharp/src/apache/main/IO/BinaryEncoder.cs
            ulong n = unchecked((ulong)((value << 1) ^ (value >> 63)));
            while ((n & ~0x7FUL) != 0)
            {
                Stream.WriteByte((byte)((n & 0x7FUL) | 0x80UL));
                n >>= 7;
            }
            Stream.WriteByte((byte)n);
        }

        public void EncodeFloat(float value) => EncodeRaw(AvroConverter.FloatToBytes(value));

        public void EncodeDouble(double value) => EncodeRaw(AvroConverter.DoubleToBytes(value));

        public void EncodeString(string value)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(value);
            EncodeInt(bytes.Length);
            EncodeRaw(bytes);
        }

        public void EncodeBytes(byte[] value)
        {
            EncodeInt(value.Length);
            EncodeRaw(value);
        }

        public void Flush() => Stream.Flush();
    }
}
