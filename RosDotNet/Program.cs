using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

class Program
{
    static async Task Main(string[] args)
    {

        Uri webSocketUri = new("ws://localhost:9090");

        using SocketsHttpHandler handler = new();
        using ClientWebSocket ws = new();

        // 连接
        await ws.ConnectAsync(webSocketUri, default);

        // 构造发送的 Json 内容
        var replyMess = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(new{
            op= "subscribe",
            topic = "/chatter",
            type = "std_msgs/String"
        }));
        // 发送
        await ws.SendAsync(new ArraySegment<byte>(replyMess), WebSocketMessageType.Text, true, default);

        // 接收一次消息
        var bytes = new byte[1024];
        var result = await ws.ReceiveAsync(bytes, default);
        string res = Encoding.UTF8.GetString(bytes, 0, result.Count);
        Console.WriteLine(res);

        // 关闭退出
        await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "Client closed", default);
    }


}