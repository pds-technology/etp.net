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
using System.Collections.Generic;

namespace Energistics.Etp.v11
{
    /// <summary>
    /// Provides string representations of protocol message names.
    /// </summary>
    public static partial class MessageNames
    {
        /// <summary>
        /// Gets the name of a protocol message.
        /// </summary>
        /// <typeparam name="TProtocol">The protocol enum.</typeparam>
        /// <typeparam name="TMessageType">The message type enum.</typeparam>
        /// <param name="protocol">The protocol.</param>
        /// <param name="messageType">The message type.</param>
        /// <returns>The message name.</returns>
        public static string GetMessageName<TProtocol,TMessageType>(TProtocol protocol, TMessageType messageType) where TProtocol : struct where TMessageType : struct, IConvertible
        {
            return GetMessageName(Convert.ToInt32(protocol), Convert.ToInt32(messageType));
        }

        /// <summary>
        /// Gets the name of a protocol message.
        /// </summary>
        /// <typeparam name="TMessageType">The message type enum.</typeparam>
        /// <param name="protocol">The protocol.</param>
        /// <param name="messageType">The message type.</param>
        /// <returns>The message name.</returns>
        public static string GetMessageName<TMessageType>(int protocol, TMessageType messageType) where TMessageType : struct, IConvertible
        {
            return GetMessageName(protocol, Convert.ToInt32(messageType));
        }

        /// <summary>
        /// Gets the name of a protocol message.
        /// </summary>
        /// <param name="protocol">The protocol.</param>
        /// <param name="messageType">Type of the message.</param>
        /// <returns>The message name.</returns>
        public static string GetMessageName(int protocol, int messageType)
        {
            // Override protocol when message is protocol exception or acknowledge.
            protocol = GetLookupProtocolForMessage(protocol, messageType);

            Dictionary<int, string> protocolNames;
            if (!Names.TryGetValue(protocol, out protocolNames))
                return $"Message {messageType}";
            
            string name;
            if (protocolNames.TryGetValue(messageType, out name))
                return name;

            return $"Message {messageType}";
        }

        /// <summary>
        /// Checks whether there is a message name registered for the specified message type.
        /// </summary>
        /// <param name="protocol">The message's protocol.</param>
        /// <param name="messageType">The message's message type.</param>
        /// <returns><c>true</c> if the message name is registered; <c>false</c> otherwise.</returns>
        public static bool IsMessageNameRegistered(int protocol, int messageType)
        {
            // Override protocol when message is protocol exception or acknowledge.
            protocol = GetLookupProtocolForMessage(protocol, messageType);

            Dictionary<int, string> protocolNames;
            if (!Names.TryGetValue(protocol, out protocolNames))
                return false;

            return protocolNames.ContainsKey(messageType);
        }

        /// <summary>
        /// Gets the protocol number to use when looking up the message name for the message type.
        /// For Acknowledge and ProtocolException messages, this is always the Core protocol.
        /// For all other messages, it is the input protocol.
        /// </summary>
        /// <param name="protocol">The input protocol.</param>
        /// <param name="messageType">The message type.</param>
        /// <returns>The protocol number to use when looking up the message name for the message type.</returns>
        private static int GetLookupProtocolForMessage(int protocol, int messageType)
        {
            // Override protocol when message is protocol exception or acknowledge.
            if (messageType == (int)MessageTypes.Core.ProtocolException || messageType == (int)MessageTypes.Core.Acknowledge)
                return (int)Protocols.Core;

            return protocol;
        }

        /// <summary>
        /// Registers the name of a message type.
        /// </summary>
        /// <param name="protocol">The message type's protocol.</param>
        /// <param name="messageType">The message type.</param>
        /// <param name="messageName">The message name.</param>
        public static void RegisterMessageName(int protocol, int messageType, string messageName)
        {
            Dictionary<int, string> protocolNames;
            if (!Names.TryGetValue(protocol, out protocolNames))
            {
                protocolNames = new Dictionary<int, string>();
                Names[protocol] = protocolNames;
            }

            protocolNames[messageType] = messageName;
        }
    }
}
