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

namespace Energistics.Etp.v12
{
    /// <summary>
    /// Provides protocol and message ID information for messages using reflection.
    /// </summary>
    public static partial class MessageReflection
    {
        /// <summary>
        /// Tries to get the protocol number for an ETP message.
        /// </summary>
        /// <param name="messageBodyType">The message body type to get the protocol for.</param>
        /// <returns>The protocol number on success; -1 otherwise.</returns>
        public static int TryGetProtocolNumber(Type messageBodyType)
        {
            int protocol;
            if (ProtocolByMessage.TryGetValue(messageBodyType, out protocol))
                return protocol;

            return -1;
        }

        /// <summary>
        /// Tries to get the message type number for an ETP message.
        /// </summary>
        /// <param name="messageBodyType">The message body type to get the protocol for.</param>
        /// <returns>The message type number on success; -1 otherwise.</returns>
        public static int TryGetMessageTypeNumber(Type messageBodyType)
        {
            int messageType;
            if (MessageTypeByMessage.TryGetValue(messageBodyType, out messageType))
                return messageType;

            return -1;
        }

        /// <summary>
        /// Checks whether the message body type is registered.
        /// </summary>
        /// <param name="messageBodyType">The message body type to check.</param>
        /// <returns><c>true</c> if the message type is registered; <c>false</c> otherwise.</returns>
        public static bool IsMessageTypeRegistered(Type messageBodyType)
        {
            return MessageTypeByMessage.ContainsKey(messageBodyType);
        }

        /// <summary>
        /// Registers the message type.
        /// </summary>
        /// <param name="messageBodyType">The message body type to register.</param>
        /// <param name="protocol">The message's protocol.</param>
        /// <param name="messageType">The message's message type.</param>
        public static void RegisterMessageType(Type messageBodyType, int protocol, int messageType)
        {
            ProtocolByMessage[messageBodyType] = protocol;
            MessageTypeByMessage[messageBodyType] = messageType;
        }
    }
}
