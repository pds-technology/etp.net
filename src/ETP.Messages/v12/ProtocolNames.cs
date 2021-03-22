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

namespace Energistics.Etp.v12
{
    /// <summary>
    /// Provides string representations of ETP protocol names.
    /// </summary>
    public static partial class ProtocolNames
    {
        /// <summary>
        /// Gets the name of a protocol.
        /// </summary>
        /// <typeparam name="TProtocol">The protocol enum.</typeparam>
        /// <param name="protocol">The protocol.</param>
        /// <returns>The protocol name.</returns>
        public static string GetProtocolName<TProtocol>(TProtocol protocol) where TProtocol : struct
        {
            return GetProtocolName(Convert.ToInt32(protocol));
        }

        /// <summary>
        /// Gets the name of a protocol.
        /// </summary>
        /// <param name="protocol">The protocol.</param>
        /// <returns>The protocol name.</returns>
        public static string GetProtocolName(int protocol)
        {
            string name;
            if (Names.TryGetValue(protocol, out name))
                return name;

            return $"Protocol {protocol}";
        }

        /// <summary>
        /// Checks whether there is a protocol name registered for the specified protocol.
        /// </summary>
        /// <param name="protocol">The protocol.</param>
        /// <returns><c>true</c> if the protocol name is registered; <c>false</c> otherwise.</returns>
        public static bool IsProtocolNameRegistered(int protocol)
        {
            return Names.ContainsKey(protocol);
        }

        /// <summary>
        /// Registers the name of a protocol.
        /// </summary>
        /// <param name="protocol">The protocol.</param>
        /// <param name="protocolName">The protocol name.</param>
        public static void RegisterProtocolName(int protocol, string protocolName)
        {
            Names[protocol] = protocolName;
        }
    }
}
