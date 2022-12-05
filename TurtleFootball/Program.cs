using System.Text;
using System.Text.Json;
using WatsonWebsocket;

internal class Program
{

    public static WatsonWsClient _client;

    private static async Task Main(string[] args)
    {
        _client = new WatsonWsClient("127.0.0.1", 9090, false);
        _client.ServerConnected += ServerConnected;
        _client.ServerDisconnected += ServerDisconnected;
        _client.MessageReceived += MessageReceived;
        await _client.StartAsync();

        while (Console.Read()!='q')
        {
        }
    }

    private static void MessageReceived(object? sender, MessageReceivedEventArgs e)
    {
        Console.WriteLine(Encoding.UTF8.GetString(e.Data));
    }

    private static void ServerDisconnected(object? sender, EventArgs e)
    {
        
    }

    private static void ServerConnected(object? sender, EventArgs e)
    {
        Console.WriteLine("连接成功");
        var replyMess = JsonSerializer.Serialize(new
        {
            op = "subscribe",
            topic = "/turtle1/pose",
            type = "turtlesim/msg/Pose"
        });
        _client.SendAsync(replyMess);
        // 创建小乌龟
        CreateTurtle(new Spawn(1, 1, 0, "turtle2"));
        CreateTurtle(new Spawn(0, 0, 0, "turtle3"));
        CreateTurtle(new Spawn(0, 1, 0, "turtle4"));
        CreateTurtle(new Spawn(1, 0, 0, "turtle5"));
        
    }

    private static async void CreateTurtle(Spawn spawn)
    {
        var mk = JsonSerializer.Serialize(new
        {
            op = "call_service",
            service = "/spawn",
            args = spawn
        });
        await _client.SendAsync(mk);

    }

    internal sealed record class Spawn(double x, double y, double theta,string name);
    internal sealed record class Geometry(double x, double y, double z);
    internal sealed record class Twits(Geometry linear, Geometry angular);
}