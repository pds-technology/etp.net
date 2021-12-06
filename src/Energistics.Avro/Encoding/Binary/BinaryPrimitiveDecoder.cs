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
using System;
using System.IO;

namespace Energistics.Avro.Encoding.Binary
{
    /// <summary>
    /// A class for binary Avro primitive decoding
    /// </summary>
    public class BinaryPrimitiveDecoder : IPrimitiveDecoder
    {
        public BinaryPrimitiveDecoder(byte[] bytes)
            : this(new MemoryStream(bytes))
        {
            OwnStream = true;
        }

        public BinaryPrimitiveDecoder(Stream stream)
        {
            Stream = stream;
        }

        private Stream Stream { get; }

        private bool Disposed { get; set; }

        private bool OwnStream { get; }

        protected byte[] DecodeRaw(int byteCount)
        {
            var bytes = new byte[byteCount];
            Stream.Read(bytes, 0, byteCount);

            return bytes;
        }

        public void DecodeNull() { }

        public T DecodeNullClass<T>() where T : class => null;

        public T? DecodeNullStruct<T>() where T : struct => null;

        public bool DecodeBoolean() => Stream.ReadByte() == 0 ? false : true;

        public int DecodeInt()
        {
            // From: https://github.com/apache/avro/blob/master/lang/csharp/src/apache/main/IO/BinaryDecoder.cs
            uint b = (uint)Stream.ReadByte();
            uint n = b & 0x7FU;
            int shift = 7;
            var count = 0;
            while ((b & 0x80) != 0 && count++ < 5)
            {
                b = (uint)Stream.ReadByte();
                n |= (b & 0x7FU) << shift;
                shift += 7;
            }
            if ((b & 0x80) != 0) throw new InvalidDataException("Max integer bytes exceeded");
            int value = (int)n;
            return (-(value & 0x01)) ^ ((value >> 1) & 0x7FFFFFFF);
        }

        public long DecodeLong()
        {
            // From: https://github.com/apache/avro/blob/master/lang/csharp/src/apache/main/IO/BinaryEncoder.cs
            uint b = (uint)Stream.ReadByte();
            ulong n = b & 0x7FUL;
            int shift = 7;
            var count = 0;
            while ((b & 0x80) != 0 && count++ < 10)
            {
                b = (uint)Stream.ReadByte();
                n |= (b & 0x7FUL) << shift;
                shift += 7;
            }
            if ((b & 0x80) != 0) throw new InvalidDataException("Max long bytes exceeded");
            long value = (long)n;
            return (-(value & 0x01L)) ^ ((value >> 1) & 0x7FFFFFFFFFFFFFFFL);
        }

        public float DecodeFloat()
        {
            var bytes = DecodeRaw(4);
            return AvroConverter.BytesToFloat(bytes);
        }

        public double DecodeDouble()
        {
            var bytes = DecodeRaw(8);
            return AvroConverter.BytesToDouble(bytes);
        }

        public string DecodeString()
        {
            var byteCount = DecodeLong();
            if (byteCount > int.MaxValue) throw new InvalidDataException("Max string length exceeded.");

            var bytes = DecodeRaw((int)byteCount);
            var @string = System.Text.Encoding.UTF8.GetString(bytes, 0, bytes.Length);

            return @string;
        }

        public byte[] DecodeBytes()
        {
            var byteCount = DecodeLong();
            if (byteCount > int.MaxValue) throw new InvalidDataException("Max byte array length exceeded.");

            return DecodeRaw((int)byteCount);
        }

        private void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    if (OwnStream)
                        Stream.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                Disposed = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~BinaryPrimitiveDecoder()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }
    }
}
