using System;
using System.Text.Json;
using System.Threading.Tasks;
using Auto.Data.Entities;
using Auto.Messages;
using Microsoft.AspNetCore.SignalR.Client;
using EasyNetQ;
//using Auto.Messages;
using Newtonsoft.Json;
using JsonSerializer = EasyNetQ.JsonSerializer;

namespace Auto.SignalR
{

    public static class Program
    {
        private const string SIGNALR_HUB_URL = "http://localhost:5000/hub";
        private static HubConnection hub;

        public static async Task Main(string[] args)
        {
            hub = new HubConnectionBuilder().WithUrl(SIGNALR_HUB_URL).Build();
            await hub.StartAsync();
            Console.WriteLine("Hub started!");
            Console.WriteLine("Press any key to send a message (Ctrl-C to quit)");
            var ampq = "amqp://user:rabbitmq@localhost:5672";
            using var bus = RabbitHutch.CreateBus(ampq);
            Console.WriteLine("Connected to bus! Listenning for newOwnerInfoMessages");
            var subscriberId = $"Auto.SignalR@{Environment.MachineName}";
            await bus.PubSub.SubscribeAsync<NewOwnerMessage>(subscriberId, HandleNewOwnerMessage);
            Console.ReadLine();
        }

        private static async void HandleNewOwnerMessage(NewOwnerMessage nom)
        {
            var csvRow =
                $"{nom.MiddleName} {nom.FirstName} {nom.LastName} : {nom.Age}, {nom.Experience}, {nom.Serial} {nom.Number}";
            Console.WriteLine(csvRow);
            var json = System.Text.Json.JsonSerializer.Serialize(nom, JsonSettings());
            await hub.SendAsync("NotifyWebUsers", "Auto.SinalR", json);
        }

        static JsonSerializerOptions JsonSettings() =>
            new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
    }
}