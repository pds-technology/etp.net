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

using System.Collections;
using Energistics.Etp.Common.Datatypes.Object;

namespace Energistics.Etp.Common.Datatypes.ChannelData
{
    public interface IChannelMetadataRecord : Avro.Specific.ISpecificRecord
    {
	    string ChannelUri { get; set; }

	    long ChannelId { get; set; }

        //IList<IIndexMetadataRecord> Indexes { get; set; }
        IList Indexes { get; set; }

        string ChannelName { get; set; }

        string DataType { get; set; }

        string Uom { get; set; }

        long? StartIndex { get; set; }

        long? EndIndex { get; set; }

        string Description { get; set; }

        //IChannelStatuses Status { get; set; }
        int Status { get; set; }

        string ContentType { get; set; }

        string Source { get; set; }

        string MeasureClass { get; set; }

        string Uuid { get; set; }

        //IDictionary<string, IDataValue> CustomData { get; set; }
        IDictionary CustomData { get; set; }

        IDataObject DomainObject { get; set; }

        //IList<IAttributeMetadataRecord> AttributeMetadata { get; set; }
        IList AttributeMetadata { get; set; }
    }
}
