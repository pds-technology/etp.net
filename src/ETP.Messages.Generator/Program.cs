using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ETP.Messages.Generator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ETP v1.1");
            GenerateProtocolsAndMessages("EtpVersion.v11", @"v11\etp.avpr", "Energistics.", "Energistics.Etp.v11.");
            Console.WriteLine("ETP v1.2");
            GenerateProtocolsAndMessages("EtpVersion.v12", @"v12\etp.avpr");
        }

        private static void GenerateProtocolsAndMessages(string etpVersion, string fileName, string namespacePrefix = null, string namespacePrefixReplacement = null)
        {
            var json = JObject.Parse(File.ReadAllText(fileName));
            var protocols = new Dictionary<string, int>();
            var messagesByProtocol = new Dictionary<string, Dictionary<string, int>>();
            var messagesNamespaces = new Dictionary<string, Dictionary<string, string>>();

            foreach (var type in json["types"].Where(x => x.Value<string>("protocol") != null))
            {
                var @namespace = type.Value<string>("namespace");
                var protocolName = @namespace.Substring(@namespace.LastIndexOf('.') + 1);
                var protocolNumber = type.Value<int>("protocol");
                protocols[protocolName] = protocolNumber;

                if (!messagesByProtocol.TryGetValue(protocolName, out var messages))
                {
                    messages = new Dictionary<string, int>();
                    messagesByProtocol[protocolName] = messages;
                    messagesNamespaces[protocolName] = new Dictionary<string, string>();
                }

                messages[type.Value<string>("name")] = type.Value<int>("messageType");
                messagesNamespaces[protocolName][type.Value<string>("name")] = string.IsNullOrEmpty(namespacePrefix) ? @namespace : @namespace.Replace(namespacePrefix, namespacePrefixReplacement);
            }

            PrintProtocols(protocols);

            PrintMessageTypes(protocols, messagesByProtocol);

            PrintProtocolNames(protocols);

            PrintMessageNames(protocols, messagesByProtocol);

            PrintMessageReflectionDefinitions(protocols, messagesByProtocol, messagesNamespaces);
        }

        private static void PrintProtocols(Dictionary<string, int> protocols)
        {
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.WriteLine($"/// <summary>");
            Console.WriteLine($"/// An enumeration of ETP protocols.");
            Console.WriteLine($"/// </summary>");
            Console.WriteLine($"public enum Protocols");
            Console.WriteLine($"{{");

            foreach (var protocol in protocols.Keys.OrderBy(k => protocols[k]))
            {
                Console.WriteLine($"    {protocol} = {protocols[protocol]},");
            }

            Console.WriteLine($"}}");
        }

        private static void PrintMessageTypes(Dictionary<string, int> protocols, Dictionary<string, Dictionary<string, int>> messagesByProtocol)
        {
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.WriteLine($"/// <summary>");
            Console.WriteLine($"/// Provides enumerations of protocol message types.");
            Console.WriteLine($"/// </summary>");
            Console.WriteLine($"public static class MessageTypes");
            Console.WriteLine($"{{");

            var firstProtocol = true;
            foreach (var protocol in protocols.Keys.OrderBy(k => protocols[k]))
            {
                if (firstProtocol)
                {
                    firstProtocol = false;
                }
                else
                {
                    Console.WriteLine();
                }
                Console.WriteLine($"    /// <summary>");
                Console.WriteLine($"    /// An enumeration of {protocol} protocol message types.");
                Console.WriteLine($"    /// </summary>");
                Console.WriteLine($"    public enum {protocol}");
                Console.WriteLine($"    {{");

                var messages = messagesByProtocol[protocol];

                foreach (var message in messages.Keys.OrderBy(k => messages[k]))
                {
                    Console.WriteLine($"        {message} = {messages[message]},");
                }

                Console.WriteLine($"    }}");
            }

            Console.WriteLine($"}}");
        }

        private static void PrintProtocolNames(Dictionary<string, int> protocols)
        {
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.WriteLine($"/// <summary>");
            Console.WriteLine($"/// Provides string representations of ETP protocol names.");
            Console.WriteLine($"/// </summary>");
            Console.WriteLine($"public static partial class ProtocolNames");
            Console.WriteLine($"{{");
            Console.WriteLine($"    /// <summary>");
            Console.WriteLine($"    /// The dictionary of protocol names.");
            Console.WriteLine($"    /// </summary>");
            Console.WriteLine($"    private static Dictionary<int, string> Names {{ get; }} = new Dictionary<int, string>");
            Console.WriteLine($"    {{");

            foreach (var protocol in protocols.Keys.OrderBy(k => protocols[k]))
            {
                Console.WriteLine($"        [{protocols[protocol]}] = \"{protocol}\",");
            }
            Console.WriteLine($"    }};");

            Console.WriteLine($"}}");
        }

        private static void PrintMessageNames(Dictionary<string, int> protocols, Dictionary<string, Dictionary<string, int>> messagesByProtocol)
        {
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.WriteLine($"/// <summary>");
            Console.WriteLine($"/// Provides string representations of protocol message names.");
            Console.WriteLine($"/// </summary>");
            Console.WriteLine($"public static partial class MessageNames");
            Console.WriteLine($"{{");
            Console.WriteLine($"    /// <summary>");
            Console.WriteLine($"    /// The dictionary of protocol names.");
            Console.WriteLine($"    /// </summary>");
            Console.WriteLine($"    private static Dictionary<int, Dictionary<int, string>> Names {{ get; }} = new Dictionary<int, Dictionary<int, string>>");
            Console.WriteLine($"    {{");

            foreach (var protocol in protocols.Keys.OrderBy(k => protocols[k]))
            {
                Console.WriteLine($"        [{protocols[protocol]}] = new Dictionary<int, string>");
                Console.WriteLine($"        {{");

                var messages = messagesByProtocol[protocol];

                foreach (var message in messages.Keys.OrderBy(k => messages[k]))
                {
                    Console.WriteLine($"            [{messages[message]}] = \"{message}\",");
                }

                Console.WriteLine($"        }},");

            }
            Console.WriteLine($"    }};");

            Console.WriteLine($"}}");
        }

        private static void PrintMessageReflectionDefinitions(Dictionary<string, int> protocols, Dictionary<string, Dictionary<string, int>> messagesByProtocol, Dictionary<string, Dictionary<string, string>> messageNamespaces)
        {
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.WriteLine($"/// <summary>");
            Console.WriteLine($"/// Provides ETP message information by message type.");
            Console.WriteLine($"/// </summary>");
            Console.WriteLine($"public static partial class MessageReflection");
            Console.WriteLine($"{{");
            Console.WriteLine($"    /// <summary>");
            Console.WriteLine($"    /// The hash set of ETP messages.");
            Console.WriteLine($"    /// </summary>");
            Console.WriteLine($"    private static Dictionary<Type, int> ProtocolByMessage {{ get; }} = new Dictionary<Type, int>");
            Console.WriteLine($"    {{");

            foreach (var protocol in protocols.Keys.OrderBy(k => protocols[k]))
            {
                var messages = messagesByProtocol[protocol];
                var namespaces = messageNamespaces[protocol];
                foreach (var message in messages.Keys.OrderBy(k => messages[k]))
                {
                    Console.WriteLine($"        [typeof({namespaces[message]}.{message})] = {protocols[protocol]},");
                }
            }

            Console.WriteLine($"    }};");

            Console.WriteLine($"    ");

            Console.WriteLine($"    /// <summary>");
            Console.WriteLine($"    /// The hash set of ETP messages.");
            Console.WriteLine($"    /// </summary>");
            Console.WriteLine($"    private static Dictionary<Type, int> MessageTypeByMessage {{ get; }} = new Dictionary<Type, int>");
            Console.WriteLine($"    {{");

            foreach (var protocol in protocols.Keys.OrderBy(k => protocols[k]))
            {
                var messages = messagesByProtocol[protocol];
                var namespaces = messageNamespaces[protocol];
                foreach (var message in messages.Keys.OrderBy(k => messages[k]))
                {
                    Console.WriteLine($"        [typeof({namespaces[message]}.{message})] = {messages[message]},");
                }
            }

            Console.WriteLine($"    }};");

            Console.WriteLine($"}}");
        }
    }
}
