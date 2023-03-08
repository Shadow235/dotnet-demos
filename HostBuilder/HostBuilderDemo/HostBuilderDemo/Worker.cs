using Microsoft.Extensions.Hosting;

namespace HostBuilderDemo;

public class Worker : BackgroundService
{
	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		while (!stoppingToken.IsCancellationRequested) 
		{ 
			await Task.Delay(1000);
			Console.WriteLine("Done");
		}
	}
}
