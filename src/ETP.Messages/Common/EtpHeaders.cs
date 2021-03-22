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

namespace Energistics.Etp.Common
{
    /// <summary>
    /// ETP header names.
    /// </summary>
    public static class EtpHeaders
    {
        /// <summary>
        ///  The Authorization Header name
        /// </summary>
        public const string Authorization = "Authorization";

        /// <summary>
        /// The ETP encoding header name.
        /// </summary>
        public const string Encoding = "etp-encoding";

        /// <summary>
        /// The ETP session header name.
        /// </summary>
        public const string Session = "etp-session";

        /// <summary>
        /// The ETP GetVersion header name.
        /// </summary>
        public const string GetVersion = "GetVersion";

        /// <summary>
        /// The ETP GetVersions header name.
        /// </summary>
        public const string GetVersions = "GetVersions";
    }
}
