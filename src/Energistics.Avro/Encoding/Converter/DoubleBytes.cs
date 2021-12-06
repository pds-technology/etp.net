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
    internal struct DoubleBytes
    {
        public DoubleBytes(double value) : this() { Value = value; }
        public DoubleBytes(byte[] bytes) : this()
        {
            Byte1 = bytes[0];
            Byte2 = bytes[1];
            Byte3 = bytes[2];
            Byte4 = bytes[3];
            Byte5 = bytes[4];
            Byte6 = bytes[5];
            Byte7 = bytes[6];
            Byte8 = bytes[7];
        }

        public byte[] Bytes => new byte[] { Byte1, Byte2, Byte3, Byte4, Byte5, Byte6, Byte7, Byte8 };

        [FieldOffset(0)]
        public double Value;

        [FieldOffset(0)]
        private byte Byte1;
        [FieldOffset(1)]
        private byte Byte2;
        [FieldOffset(2)]
        private byte Byte3;
        [FieldOffset(3)]
        private byte Byte4;
        [FieldOffset(4)]
        private byte Byte5;
        [FieldOffset(5)]
        private byte Byte6;
        [FieldOffset(6)]
        private byte Byte7;
        [FieldOffset(7)]
        private byte Byte8;
    }
}
