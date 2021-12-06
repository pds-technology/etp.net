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

using System.Runtime.InteropServices;

namespace Energistics.Avro.Encoding.Converter
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct FloatBytes
    {
        public FloatBytes(float value) : this() { Value = value; }
        public FloatBytes(byte[] bytes) : this()
        {
            Byte1 = bytes[0];
            Byte2 = bytes[1];
            Byte3 = bytes[2];
            Byte4 = bytes[3];
        }

        public byte[] Bytes => new byte[] { Byte1, Byte2, Byte3, Byte4 };

        [FieldOffset(0)]
        public float Value;

        [FieldOffset(0)]
        private byte Byte1;
        [FieldOffset(1)]
        private byte Byte2;
        [FieldOffset(2)]
        private byte Byte3;
        [FieldOffset(3)]
        private byte Byte4;
    }
}
