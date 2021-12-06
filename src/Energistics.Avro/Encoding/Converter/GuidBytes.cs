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

using System;
using System.Runtime.InteropServices;

namespace Energistics.Avro.Encoding.Converter
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct GuidBytes
    {
        public GuidBytes(Guid value) : this() { Value = value; }
        public GuidBytes(byte[] bytes) : this()
        {
            Byte01 = bytes[0];
            Byte02 = bytes[1];
            Byte03 = bytes[2];
            Byte04 = bytes[3];
            Byte05 = bytes[4];
            Byte06 = bytes[5];
            Byte07 = bytes[6];
            Byte08 = bytes[7];
            Byte09 = bytes[8];
            Byte10 = bytes[9];
            Byte11 = bytes[10];
            Byte12 = bytes[11];
            Byte13 = bytes[12];
            Byte14 = bytes[13];
            Byte15 = bytes[14];
            Byte16 = bytes[15];
        }

        public byte[] Bytes => new byte[] { Byte01, Byte02, Byte03, Byte04, Byte05, Byte06, Byte07, Byte08, Byte09, Byte10, Byte11, Byte12, Byte13, Byte14, Byte15, Byte16 };

        [FieldOffset(0)]
        public Guid Value;

        [FieldOffset(3)]
        private byte Byte01;
        [FieldOffset(2)]
        private byte Byte02;
        [FieldOffset(1)]
        private byte Byte03;
        [FieldOffset(0)]
        private byte Byte04;

        [FieldOffset(5)]
        private byte Byte05;
        [FieldOffset(4)]
        private byte Byte06;

        [FieldOffset(7)]
        private byte Byte07;
        [FieldOffset(6)]
        private byte Byte08;

        [FieldOffset(8)]
        private byte Byte09;
        [FieldOffset(9)]
        private byte Byte10;
        [FieldOffset(10)]
        private byte Byte11;
        [FieldOffset(11)]
        private byte Byte12;
        [FieldOffset(12)]
        private byte Byte13;
        [FieldOffset(13)]
        private byte Byte14;
        [FieldOffset(14)]
        private byte Byte15;
        [FieldOffset(15)]
        private byte Byte16;
    }
}
