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
    [HttpGet("/connect")]
    public async Task<ActionResult> Connect()
    {
        await Task.CompletedTask;
        return Ok("Success");
    }
}
