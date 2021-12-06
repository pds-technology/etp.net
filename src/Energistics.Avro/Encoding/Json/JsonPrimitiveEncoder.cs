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

using Energistics.Json;
using System;
using System.IO;
using System.Linq;

namespace Energistics.Avro.Encoding.Json
{
    /// <summary>
    /// A class for JSON Avro primitive encoding
    /// </summary>
    public class JsonPrimitiveEncoder : IPrimitiveEncoder, System.IDisposable
    {
        public JsonPrimitiveEncoder(Stream stream)
            : this(stream, JsonFloatingPointSettings.Default)
        {
            OwnWriter = true;
        }

        public JsonPrimitiveEncoder(TextWriter writer)
            : this(writer, JsonFloatingPointSettings.Default)
        {
        }

        public JsonPrimitiveEncoder(Stream stream, JsonFloatingPointSettings floatingPointSettings)
            : this (new StreamWriter(stream, System.Text.Encoding.UTF8), floatingPointSettings)
        {
            OwnWriter = true;
        }

        public JsonPrimitiveEncoder(TextWriter writer, JsonFloatingPointSettings floatingPointSettings)
        {
            Writer = writer;
            FloatingPointSettings = floatingPointSettings;
            EncodingProperties = JsonEncodingProperties.ForEncoding(writer.Encoding);
            FloatingPointEncodingProperties = JsonFloatingPointEncodingProperties.ForEncodingAndSettings(writer.Encoding, floatingPointSettings);
        }

        private bool Disposed { get; set; }

        private TextWriter Writer { get; }

        private bool OwnWriter { get; }

        public JsonFloatingPointSettings FloatingPointSettings { get; }

        private JsonEncodingProperties EncodingProperties { get; }

        private JsonFloatingPointEncodingProperties FloatingPointEncodingProperties { get; }

        protected void EncodeRaw(char c) => Writer.Write(c);

        protected void EncodeRaw(string @string) => Writer.Write(@string);

        public void EncodeNull() => Writer.Write("null");

        public void EncodeNullClass<T>(T value) where T : class => EncodeNull();

        public void EncodeNullStruct<T>(T? value) where T : struct => EncodeNull();

        public void EncodeBoolean(bool value) => Writer.Write(value ? "true" : "false");

        public void EncodeInt(int value) => Writer.Write(value);

        public void EncodeLong(long value) => Writer.Write(value);

        public void EncodeFloat(float value)
        {
            if (float.IsNaN(value))
                Writer.Write(FloatingPointSettings.NaN);
            else if (float.IsPositiveInfinity(value))
                Writer.Write(FloatingPointSettings.PositiveInfinity);
            else if (float.IsNegativeInfinity(value))
                Writer.Write(FloatingPointSettings.NegativeInfinity);
            else
                Writer.Write(value.ToString(FloatingPointSettings.SingleFormat));
        }

        public void EncodeDouble(double value)
        {
            if (double.IsNaN(value))
                Writer.Write(FloatingPointSettings.NaN);
            else if (double.IsPositiveInfinity(value))
                Writer.Write(FloatingPointSettings.PositiveInfinity);
            else if (double.IsNegativeInfinity(value))
                Writer.Write(FloatingPointSettings.NegativeInfinity);
            else
                Writer.Write(value.ToString(FloatingPointSettings.DoubleFormat));
        }

        public void EncodeString(string value)
        {
            Writer.Write('\"');
            StringEncoding.Encode(value, Writer);
            Writer.Write('\"');
        }

        public void EncodeBytes(byte[] value)
        {
            Writer.Write('\"');
            BytesEncoding.Encode(value, Writer);
            Writer.Write('\"');
        }

        public void Flush() => Writer.Flush();

        protected virtual void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    if (OwnWriter)
                        Writer.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                Disposed = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~JsonPrimitiveEncoder()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
