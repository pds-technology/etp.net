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
            GenerateProtocolsAndMessages(@"v11\etp.avpr");
            Console.WriteLine("ETP v1.2");
            GenerateProtocolsAndMessages(@"v12\etp.avpr");
        }

        private static void GenerateProtocolsAndMessages(string fileName)
        {
            var json = JObject.Parse(File.ReadAllText(fileName));
            var protocols = new Dictionary<string, int>();
            var messagesByProtocol = new Dictionary<string, Dictionary<string, int>>();

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
                }

                messages[type.Value<string>("name")] = type.Value<int>("messageType");
            }

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
    }
}
