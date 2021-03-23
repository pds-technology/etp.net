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

namespace Energistics.Etp.Common.Datatypes
{
    public class GuidGuidSource : IUuidGuidSource
    {
        public GuidGuidSource(Guid guid)
        {
            UuidGuid = guid;
        }

        public bool IsUuidValidGuid => UuidGuid != default(Guid);

        public string RawUuid => UuidGuid.ToString();

        public Guid UuidGuid { get; }

        public string DisplayUuid => UuidGuid.ToString();
    }

    public class UuidGuidSource : IUuidGuidSource
    {
        private readonly IUuid _uuid;

        public UuidGuidSource(IUuid uuid)
        {
            _uuid = uuid;
        }

        public bool IsUuidValidGuid => _uuid.IsValidGuid();

        public string RawUuid => _uuid.ToBase64String();

        public Guid UuidGuid => _uuid.ToGuid();

        public string DisplayUuid => UuidGuid.ToString();
    }

    public class StringGuidSource : IUuidGuidSource
    {
        private readonly string _string;

        public StringGuidSource(string uuid)
        {
            _string = uuid;
        }

        public bool IsUuidValidGuid => CommonExtensions.IsValidGuid(_string);

        public string RawUuid => _string;

        public Guid UuidGuid => CommonExtensions.ToGuid(_string);

        public string DisplayUuid => _string;
    }

    public class HashedStringGuidSource : IUuidGuidSource
    {
        private readonly string _string;
        private readonly Guid _guid;

        public HashedStringGuidSource(Guid namespaceId, string @string)
        {
            _string = @string;
            _guid = GuidUtility.Create(namespaceId, @string ?? string.Empty);
        }

        public HashedStringGuidSource(string @string)
        {
            _string = @string;
            _guid = GuidUtility.CreateEnergisticsEtpGuid(@string ?? string.Empty);
        }

        public bool IsUuidValidGuid => _guid != default(Guid);

        public string RawUuid => _string;

        public Guid UuidGuid => _guid;

        public string DisplayUuid => _string;
    }
}
