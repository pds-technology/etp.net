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
using Energistics.Avro.Encoding;
using System;

namespace Energistics.Avro.Encoding
{
    public static partial class TestData
    {
        private class GuidTestCase : TestCase<Guid>
        {
            public GuidTestCase()
            {
                AvroEncode = (t, encoder) => encoder.EncodeGuid(t.Value, (GuidEncodingStyle)t.EncodingStyle);
                AvroDecode = (t, decoder) => decoder.DecodeGuid((GuidEncodingStyle)t.EncodingStyle);
            }
        }

        public static void EncodeGuid(this IAvroEncoder encoder, Guid value, GuidEncodingStyle style)
        {
            switch (style)
            {
                case GuidEncodingStyle.Rfc4122String: encoder.EncodeUuidGuidAsRfc4122String(value); return;
                case GuidEncodingStyle.Bytes: encoder.EncodeUuidGuidAsBytes(value); return;
                case GuidEncodingStyle.Fixed: encoder.EncodeUuidGuidAsFixed(value); return;
                default:
                    throw new ArgumentException("Invalid style", nameof(style));
            }
        }

        public static Guid DecodeGuid(this IAvroDecoder decoder, GuidEncodingStyle style)
        {
            switch (style)
            {
                case GuidEncodingStyle.Rfc4122String: return decoder.DecodeUuidGuidAsRfc4122String();
                case GuidEncodingStyle.Bytes: return decoder.DecodeUuidGuidAsBytes();
                case GuidEncodingStyle.Fixed: return decoder.DecodeUuidGuidAsFixed();
                default:
                    throw new ArgumentException("Invalid style", nameof(style));
            }
        }

        public static TestCase<Guid>[] Guid => new TestCase<Guid>[] { GuidAsRfc4122String, GuidAsBytes, GuidAsFixed };

        public static TestCase<Guid> GuidAsRfc4122String => new GuidTestCase
        {
            Name = nameof(GuidAsRfc4122String),
            Value = System.Guid.Parse("00112233-4455-6677-8899-aabbccddeeff"),
            BinaryEncoding = new byte[] { 0x48, 0x30, 0x30, 0x31, 0x31, 0x32, 0x32, 0x33, 0x33, 0x2D, 0x34, 0x34, 0x35, 0x35, 0x2D, 0x36, 0x36, 0x37, 0x37, 0x2D, 0x38, 0x38, 0x39, 0x39, 0x2D, 0x61, 0x61, 0x62, 0x62, 0x63, 0x63, 0x64, 0x64, 0x65, 0x65, 0x66, 0x66 },
            BinaryByteCount = 37L,
            JsonEncoding = "\"00112233-4455-6677-8899-aabbccddeeff\"",
            JsonByteCount = 38L,
            Convert = (t) => AvroConverter.GuidToRfc4122String(t.Value),
            Unconvert = (t) => AvroConverter.Rfc4122StringToGuid((string)t.Converted),
            Converted = "00112233-4455-6677-8899-aabbccddeeff",
            EncodingStyle = GuidEncodingStyle.Rfc4122String,
        };

        public static TestCase<Guid> GuidAsBytes => new GuidTestCase
        {
            Name = nameof(GuidAsBytes),
            Value = System.Guid.Parse("00112233-4455-6677-8899-aabbccddeeff"),
            BinaryEncoding = new byte[] { 0x20, 0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xaa, 0xbb, 0xcc, 0xdd, 0xee, 0xff },
            BinaryByteCount = 17L,
            JsonEncoding = "\"\\u0000\\u0011\\\"3DUfw\\u0088\\u0099ª»ÌÝîÿ\"",
            JsonByteCount = 45L,
            Convert = (t) => AvroConverter.GuidToBytes(t.Value),
            Unconvert = (t) => AvroConverter.BytesToGuid((byte[])t.Converted),
            Converted = new byte[] { 0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xaa, 0xbb, 0xcc, 0xdd, 0xee, 0xff },
            EncodingStyle = GuidEncodingStyle.Bytes,
        };

        public static TestCase<Guid> GuidAsFixed => new GuidTestCase
        {
            Name = nameof(GuidAsFixed),
            Value = System.Guid.Parse("00112233-4455-6677-8899-aabbccddeeff"),
            BinaryEncoding = new byte[] { 0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xaa, 0xbb, 0xcc, 0xdd, 0xee, 0xff },
            BinaryByteCount = 16L,
            JsonEncoding = "\"\\u0000\\u0011\\\"3DUfw\\u0088\\u0099ª»ÌÝîÿ\"",
            JsonByteCount = 45L,
            Convert = (t) => AvroConverter.GuidToFixed(t.Value),
            Unconvert = (t) => AvroConverter.FixedToGuid((byte[])t.Converted),
            Converted = new byte[] { 0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xaa, 0xbb, 0xcc, 0xdd, 0xee, 0xff },
            EncodingStyle = GuidEncodingStyle.Fixed,
        };
    }
}
