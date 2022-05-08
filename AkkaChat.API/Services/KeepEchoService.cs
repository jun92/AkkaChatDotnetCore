using Microsoft.Extensions.Hosting;

namespace AkkaChat.API.Services;

/// 지속적으로 메세지를 보내주는 테스트용 서비스 
public class KeepEchoService : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Start");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Stoped");
        return Task.CompletedTask;
    }
}

