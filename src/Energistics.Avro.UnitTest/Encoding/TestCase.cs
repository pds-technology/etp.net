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

namespace Energistics.Avro.Encoding
{
    public class TestCase
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public long BinaryByteCount { get; set; }
        public byte[] BinaryEncoding { get; set; }
        public long JsonByteCount { get; set; }
        public string JsonEncoding { get; set; }
    }

    public class TestCase<T> : TestCase
    {
        public Action<TestCase<T>, IPrimitiveEncoder> PrimitiveEncode { get; set; }
        public Func<TestCase<T>, IPrimitiveDecoder, object> PrimitiveDecode { get; set; }
        public Action<TestCase<T>, IAvroEncoder> AvroEncode { get; set; }
        public Func<TestCase<T>, IAvroDecoder, object> AvroDecode { get; set; }
        public new T Value { get => (T)base.Value; set => base.Value = value; }
        public Func<TestCase<T>, object> Convert { get; set; }
        public Func<TestCase<T>, object> Unconvert { get; set; }
        public object Converted { get; set; }
        public object EncodingStyle { get; set; }
    }
}
