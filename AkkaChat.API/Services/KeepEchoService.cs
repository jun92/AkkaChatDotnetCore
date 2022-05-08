using Microsoft.Extensions.Hosting;

namespace AkkaChat.API.Services;
/// 지속적으로 메세지를 보내주는 테스트용 서비스 
public class KeepEchoService : IHostedService
{
    protected readonly ChatService _chatService;
    public KeepEchoService(ChatService chatService)
    {
        _chatService = chatService;
    }
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        int i = 0;
        while(!cancellationToken.IsCancellationRequested)
        {
            Console.WriteLine($"Start({i++}) - cancelRequests{cancellationToken.IsCancellationRequested}");
            await Task.Delay(1000);
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Stoped");
        return Task.CompletedTask;
    }
}

