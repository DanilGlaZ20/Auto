using System;
using System.Threading.Tasks;
using Auto.Data.Entities;
using Auto.InfoOwnerServer;
using EasyNetQ;
using Grpc.Net.Client;
using Auto.Messages;

class Program
{
    private static OwnerInfo.OwnerInfoClient grpcClient;
    private static IBus bus;

    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting Auto.OwnerInfoClient");
        var amqp = "amqp://user:rabbitmq@localhost:5672";
        bus = RabbitHutch.CreateBus(amqp);
        Console.WriteLine("Connected to bus; Listening for NewOwnerMessages");
        var grpcAddress = "https://localhost:7297";
        using var chanel = GrpcChannel.ForAddress(grpcAddress);
        grpcClient = new OwnerInfo.OwnerInfoClient(chanel);
        Console.WriteLine($"Connected to gRPC on {grpcAddress}");
        var subscribeId = $"Auto.OwnerInfoClient@{Environment.MachineName}";
        await bus.PubSub.SubscribeAsync<NewOwnerMessage>(subscribeId, HandleNewOwnerMessage);
        Console.WriteLine("Press Enter to exit");
        Console.ReadLine();
    }

    private static async Task HandleNewOwnerMessage(NewOwnerMessage message)
    {
        Console.WriteLine($"new owner; {message.Serial + " " + message.Number}");
        var ownerRequest = new OwnerInfoRequest()
        {
            RegisterNumber = message.Serial + "&" + message.Number
        };
        var ownerReply = await grpcClient.GetOwnerInfoAsync(ownerRequest);
        Console.WriteLine($"Owner {message.MiddleName + " " + message.FirstName + " " + message.LastName} driver licence {ownerReply.DriverLicence}");
        var newOwnerInfoMessage = new NewOwnerMessage(message.FirstName, message.MiddleName, message.LastName, message.Age, message.Experience, message.Serial, message.Number);
        await bus.PubSub.PublishAsync(newOwnerInfoMessage);
    }
}