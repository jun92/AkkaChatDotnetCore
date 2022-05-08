
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
}