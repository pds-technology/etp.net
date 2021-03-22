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

namespace Energistics.Etp.Common
{
    /// <summary>
    /// Constants for ETP roles.
    /// </summary>
    public static class Roles
    {
        /// <summary>
        /// The client role.
        /// </summary>
        public const string Client = "client";

        /// <summary>
        /// The server role.
        /// </summary>
        public const string Server = "server";

        /// <summary>
        /// The consumer role.
        /// </summary>
        public const string Consumer = "consumer";

        /// <summary>
        /// The producer role.
        /// </summary>
        public const string Producer = "producer";

        /// <summary>
        /// The customer role.
        /// </summary>
        public const string Customer = "customer";

        /// <summary>
        /// The store role.
        /// </summary>
        public const string Store = "store";

        private static Dictionary<string, string> RoleCounterparts = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            [Client] = Server,
            [Server] = Client,
            [Producer] = Consumer,
            [Consumer] = Producer,
            [Customer] = Store,
            [Store] = Customer,
        };

        /// <summary>
        /// Gets the name of the counterpart role for the specified role.
        /// </summary>
        /// <param name="role"></param>
        /// <returns>The counterpart role.</returns>
        public static string GetCounterpartRole(string role)
        {
            string counterpartRole;
            if (RoleCounterparts.TryGetValue(role, out counterpartRole))
                return counterpartRole;

            return null;
        }

        /// <summary>
        /// Registers custom roles.
        /// </summary>
        /// <param name="role">The role.</param>
        /// <param name="counterpartRole">The role's counterpart.</param>
        public static void RegisterRoles(string role, string counterpartRole)
        {
            RoleCounterparts[role] = counterpartRole;
            RoleCounterparts[counterpartRole] = role;
        }
    }
}
