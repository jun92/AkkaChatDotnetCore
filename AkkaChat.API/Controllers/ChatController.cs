using System.Net.WebSockets;
using Microsoft.AspNetCore.Mvc;

namespace AkkaChat.API.Controllers;

[ApiController]
[Route("/api/v1/chat")]
public class ChatController : ControllerBase
{
    private readonly ILogger<ChatController> _logger;
    public ChatController(ILogger<ChatController> logger)
    {
        _logger = logger;
    }
    [HttpGet("/ws/connect")]
    public async Task<ActionResult> Connect()
    {
        if (HttpContext.WebSockets.IsWebSocketRequest)
        {
            WebSocket webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
            await Task.CompletedTask;
            return Ok("Terminated");
        }
        else 
        {
            return BadRequest("This is for websocket");
        }
    }
}
