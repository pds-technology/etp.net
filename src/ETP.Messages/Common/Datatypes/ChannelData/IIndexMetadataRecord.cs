//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2018 Energistics
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

namespace Energistics.Etp.Common.Datatypes.ChannelData
{
    public interface IIndexMetadataRecord : Avro.Specific.ISpecificRecord
    {
		int IndexKind { get; set; }

		string Uom { get; set; }

        string DepthDatum { get; set; }

        int Direction { get; set; }

        string Mnemonic { get; set; }

        string Description { get; set; }

        string Uri { get; set; }

        IDictionary CustomData { get; set; }

        int Scale { get; set; }

        string TimeDatum { get; set; }

    }
}
