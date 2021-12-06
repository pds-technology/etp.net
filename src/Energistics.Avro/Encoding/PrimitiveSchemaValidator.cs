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

using System.IO;

namespace Energistics.Avro.Encoding
{
    /// <summary>
    /// A class for validating Avro primitive data against its Avro schema
    /// </summary>
    public class PrimitiveSchemaValidator : IPrimitiveEncoder
    {
        protected bool IsNullExpected { get; set; }

        protected virtual string Context { get; }

        public void EncodeNull()
        {
            if (!IsNullExpected)
                RaiseError("Unexpected null value.");

            IsNullExpected = false;
        }

        public void EncodeNullClass<T>(T value) where T : class => EncodeNull();

        public void EncodeNullStruct<T>(T? value) where T : struct => EncodeNull();

        public void EncodeBoolean(bool value) { }

        public void EncodeInt(int value) { }

        public void EncodeLong(long value) { }

        public void EncodeFloat(float value) { }

        public void EncodeDouble(double value) { }

        public void EncodeString(string value)
        {
            if (value == null)
                RaiseError("Unexpected null string.");
        }

        public void EncodeBytes(byte[] value)
        {
            if (value == null)
                RaiseError("Unexpected null byte array.");
        }

        public void Flush() { }

        protected void RaiseError(string error)
        {
            var context = Context;
            if (string.IsNullOrEmpty(context))
                throw new InvalidDataException(error);
            else
                throw new InvalidDataException($"Error in {context}: {error}");
        }
    }
}
