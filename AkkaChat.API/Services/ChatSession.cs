using System.Net.WebSockets;

public class ChatSession
{
    protected readonly WebSocket _socket;
    public ChatSession(WebSocket socket)
    {
        _socket = socket;
    }

    public void SendEcho()
    {
        // await _socket.SendAsync();
        throw new NotImplementedException();
    }
}