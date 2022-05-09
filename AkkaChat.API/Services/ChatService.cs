
using System.Collections.Concurrent;
using System.Net.WebSockets;

public class ChatService 
{
    protected readonly IDictionary<WebSocket, ChatSession> _chatSession;
    public ChatService()
    {
        _chatSession = new ConcurrentDictionary<WebSocket, ChatSession>();
    }

    public void AddChatSession(WebSocket newWebSocket)
    {
        _chatSession.Add(newWebSocket, new ChatSession(newWebSocket));
    }

    public void Echo()
    {
        foreach(var chat in _chatSession)
        {
            chat.Value.SendEcho();
        }
    }
}