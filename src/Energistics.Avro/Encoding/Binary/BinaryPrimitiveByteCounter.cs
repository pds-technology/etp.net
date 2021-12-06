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

namespace Energistics.Avro.Encoding.Binary
{
    /// <summary>
    /// A class for counting the bytes required for binary Avro primitive encoding
    /// </summary>
    public class BinaryPrimitiveByteCounter : IPrimitiveEncoder
    {
        private long _count;

        public long ByteCount => _count;

        public void Reset() => _count = 0;

        protected void Increment(long increment) => _count += increment;

        public void EncodeNull() { }

        public void EncodeNullClass<T>(T value) where T : class => EncodeNull();

        public void EncodeNullStruct<T>(T? value) where T : struct => EncodeNull();

        public void EncodeBoolean(bool value) => _count++;

        public void EncodeInt(int value)
        {
                 if (value >= -64 && value < 64) _count += 1L;
            else if (value >= -8192 && value < 8192) _count += 2L;
            else if (value >= -1048576 && value < 1048576) _count += 3L;
            else if (value >= -134217728 && value < 134217728) _count += 4L;
            else _count += 5L;
        }

        public void EncodeLong(long value)
        {
                 if (value >= -64L && value < 64L) _count += 1L;
            else if (value >= -8192L && value < 8192L) _count += 2L;
            else if (value >= -1048576L && value < 1048576L) _count += 3L;
            else if (value >= -134217728L && value < 134217728L) _count += 4L;
            else if (value >= -17179869184L && value < 17179869184L) _count += 5L;
            else if (value >= -2199023255552L && value < 2199023255552L) _count += 6L;
            else if (value >= -281474976710656L && value < 281474976710656L) _count += 7L;
            else if (value >= -36028797018963968L && value < 36028797018963968L) _count += 8L;
            else if (value >= -4611686018427387904L && value < 4611686018427387904L) _count += 9L;
            else _count += 10L;
        }

        public void EncodeFloat(float value) => _count += 4L;

        public void EncodeDouble(double value) => _count += 8L;

        public void EncodeString(string value)
        {
            EncodeInt(value.Length);
            _count += System.Text.Encoding.UTF8.GetByteCount(value);
        }

        public void EncodeBytes(byte[] value)
        {
            EncodeInt(value.Length);
            _count += value.Length;
        }

        public void Flush() { }
    }
}
