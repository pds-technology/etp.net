//-----------------------------------------------------------------------
// ETP DevKit, 1.2
// 
// Copyright 2021 Energistics
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
// 
//-----------------------------------------------------------------------
// This code has been automatically generated.
// Changes will be lost the next time it is regenerated.
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Energistics.Avro;

namespace Energistics.Etp.v12.Datatypes
{
    [AvroNamedType("AttributeMetadataRecord", "Energistics.Etp.v12.Datatypes")]
    public partial class AttributeMetadataRecord
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AttributeMetadataRecord\",\"fields\":[{\"name\":\"attributeId\",\"type\":\"int\"},{\"name\":\"attributeName\",\"type\":\"string\"},{\"name\":\"dataKind\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.ChannelDataKind\",\"type\":\"enum\",\"symbols\":[\"DateTime\",\"ElapsedTime\",\"MeasuredDepth\",\"PassIndexedDepth\",\"TrueVerticalDepth\",\"typeBoolean\",\"typeInt\",\"typeLong\",\"typeFloat\",\"typeDouble\",\"typeString\",\"typeBytes\"]}},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":\"string\"},{\"name\":\"attributePropertyKindUri\",\"type\":\"string\"},{\"name\":\"axisVectorLengths\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}]}";
        [AvroRecordField("attributeId")]
        public int AttributeId { get; set; }
        [AvroRecordField("attributeName")]
        public string AttributeName { get; set; }
        [AvroRecordField("dataKind")]
        public Energistics.Etp.v12.Datatypes.ChannelData.ChannelDataKind DataKind { get; set; }
        [AvroRecordField("uom")]
        public string Uom { get; set; }
        [AvroRecordField("depthDatum")]
        public string DepthDatum { get; set; }
        [AvroRecordField("attributePropertyKindUri")]
        public string AttributePropertyKindUri { get; set; }
        [AvroRecordField("axisVectorLengths")]
        public IList<int> AxisVectorLengths { get; set; }
    }
}
