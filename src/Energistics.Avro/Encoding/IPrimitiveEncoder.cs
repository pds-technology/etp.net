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

namespace Energistics.Avro.Encoding
{
    /// <summary>
    /// An interface for encoding Avro primitive data
    /// </summary>
    public interface IPrimitiveEncoder
    {
        void EncodeNull();
        void EncodeNullClass<T>(T value) where T : class;
        void EncodeNullStruct<T>(T? value) where T : struct;
        void EncodeBoolean(bool value);
        void EncodeInt(int value);
        void EncodeLong(long value);
        void EncodeFloat(float value);
        void EncodeDouble(double value);
        void EncodeString(string value);
        void EncodeBytes(byte[] value);
        void Flush();
    }
}
