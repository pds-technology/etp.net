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

using System.Linq;

namespace Energistics.Avro.Encoding.Json
{
    /// <summary>
    /// A class for counting the bytes required for JSON Avro primitive encoding
    /// </summary>
    public class JsonPrimitiveByteCounter : IPrimitiveEncoder
    {
        private long _count;

        public JsonPrimitiveByteCounter()
            : this(System.Text.Encoding.UTF8, JsonFloatingPointSettings.Default)
        {
        }

        public JsonPrimitiveByteCounter(JsonFloatingPointSettings floatingPointSettings)
            : this(System.Text.Encoding.UTF8, floatingPointSettings)
        {
        }

        public JsonPrimitiveByteCounter(System.Text.Encoding encoding)
            : this (encoding, JsonFloatingPointSettings.Default)
        {
        }

        public JsonPrimitiveByteCounter(System.Text.Encoding encoding, JsonFloatingPointSettings floatingPointSettings)
        {
            FloatingPointSettings = floatingPointSettings;
            EncodingProperties = JsonEncodingProperties.ForEncoding(encoding);
            FloatingPointEncodingProperties = JsonFloatingPointEncodingProperties.ForEncodingAndSettings(encoding, floatingPointSettings);
        }

        public long ByteCount => _count;

        public void Reset() => _count = 0;

        protected void Increment(long increment) => _count += increment;

        public JsonFloatingPointSettings FloatingPointSettings { get; }

        private JsonEncodingProperties EncodingProperties { get; }

        private JsonFloatingPointEncodingProperties FloatingPointEncodingProperties { get; }

        public void EncodeNull() => _count += EncodingProperties.NullSize;

        public void EncodeNullClass<T>(T value) where T : class => EncodeNull();

        public void EncodeNullStruct<T>(T? value) where T : struct => EncodeNull();

        public void EncodeBoolean(bool value) => _count += value ? EncodingProperties.TrueSize : EncodingProperties.FalseSize;

        public void EncodeInt(int value)
        {
                 if (value >= 0 && value <= 9) _count += EncodingProperties.IntegerSizes[0];
            else if (value >= -9 && value <= 99) _count += EncodingProperties.IntegerSizes[1];
            else if (value >= -99 && value <= 999) _count += EncodingProperties.IntegerSizes[2];
            else if (value >= -999 && value <= 9999) _count += EncodingProperties.IntegerSizes[3];
            else if (value >= -9999 && value <= 99999) _count += EncodingProperties.IntegerSizes[4];
            else if (value >= -99999 && value <= 999999) _count += EncodingProperties.IntegerSizes[5];
            else if (value >= -999999 && value <= 9999999) _count += EncodingProperties.IntegerSizes[6];
            else if (value >= -9999999 && value <= 99999999) _count += EncodingProperties.IntegerSizes[7];
            else if (value >= -99999999 && value <= 999999999) _count += EncodingProperties.IntegerSizes[8];
            else if (value >= -999999999 && value <= 2147483647) _count += EncodingProperties.IntegerSizes[9];
            else _count += EncodingProperties.IntegerSizes[10];
        }

        public void EncodeLong(long value)
        {
                 if (value >= 0L && value <= 9L) _count += EncodingProperties.IntegerSizes[0];
            else if (value >= -9L && value <= 99L) _count += EncodingProperties.IntegerSizes[1];
            else if (value >= -99L && value <= 999L) _count += EncodingProperties.IntegerSizes[2];
            else if (value >= -999L && value <= 9999L) _count += EncodingProperties.IntegerSizes[3];
            else if (value >= -9999L && value <= 99999L) _count += EncodingProperties.IntegerSizes[4];
            else if (value >= -99999L && value <= 999999L) _count += EncodingProperties.IntegerSizes[5];
            else if (value >= -999999L && value <= 9999999L) _count += EncodingProperties.IntegerSizes[6];
            else if (value >= -9999999L && value <= 99999999L) _count += EncodingProperties.IntegerSizes[7];
            else if (value >= -99999999L && value <= 999999999L) _count += EncodingProperties.IntegerSizes[8];
            else if (value >= -999999999L && value <= 9999999999L) _count += EncodingProperties.IntegerSizes[9];
            else if (value >= -9999999999L && value <= 99999999999L) _count += EncodingProperties.IntegerSizes[10];
            else if (value >= -99999999999L && value <= 999999999999L) _count += EncodingProperties.IntegerSizes[11];
            else if (value >= -999999999999L && value <= 9999999999999L) _count += EncodingProperties.IntegerSizes[12];
            else if (value >= -9999999999999L && value <= 99999999999999L) _count += EncodingProperties.IntegerSizes[13];
            else if (value >= -99999999999999L && value <= 999999999999999L) _count += EncodingProperties.IntegerSizes[14];
            else if (value >= -999999999999999L && value <= 9999999999999999L) _count += EncodingProperties.IntegerSizes[15];
            else if (value >= -9999999999999999L && value <= 99999999999999999L) _count += EncodingProperties.IntegerSizes[16];
            else if (value >= -99999999999999999L && value <= 999999999999999999L) _count += EncodingProperties.IntegerSizes[17];
            else if (value >= -999999999999999999L && value <= 9223372036854775807L) _count += EncodingProperties.IntegerSizes[18];
            else _count += EncodingProperties.IntegerSizes[19];
        }

        public void EncodeFloat(float value)
        {
            if (float.IsNaN(value))
                _count += FloatingPointEncodingProperties.NaNSize;
            else if (float.IsInfinity(value))
                _count += value < 0.0F ? FloatingPointEncodingProperties.NegativeInfinitySize : FloatingPointEncodingProperties.PositiveInfinitySize;
            else
                _count += System.Text.Encoding.UTF8.GetByteCount(value.ToString(FloatingPointSettings.SingleFormat));
        }

        public void EncodeDouble(double value)
        {
            if (double.IsNaN(value))
                _count += FloatingPointEncodingProperties.NaNSize;
            else if (double.IsInfinity(value))
                _count += value < 0.0 ? FloatingPointEncodingProperties.NegativeInfinitySize : FloatingPointEncodingProperties.PositiveInfinitySize;
            else
                _count += System.Text.Encoding.UTF8.GetByteCount(value.ToString(FloatingPointSettings.DoubleFormat));
        }

        public void EncodeString(string value)
        {
            if (value.Length == 0)
                _count += EncodingProperties.StartEndQuoteSize;
            else
                _count += EncodingProperties.StartEndQuoteSize + System.Text.Encoding.UTF8.GetByteCount(value) + value.Select(c => c < 256 ? EncodingProperties.CharSizeDeltas[c] : 0L).Sum();
        }

        public void EncodeBytes(byte[] value)
        {
            if (value.Length == 0)
                _count += EncodingProperties.StartEndQuoteSize;
            else
                _count += EncodingProperties.StartEndQuoteSize + value.Select(b => EncodingProperties.EncodedCharSizes[b]).Sum();
        }

        public void Flush() { }
    }
}
