using Microsoft.Extensions.Hosting;
using MultipleProjectDependency.Processor;

namespace MultipleProjectDependency.Services;

public class ProcessorDemoServices : BackgroundService
{
	private IProcessor _processor;

	public ProcessorDemoServices(IProcessor processor)
	{
		_processor = processor;
	}

	protected override Task ExecuteAsync(CancellationToken stoppingToken)
	{
		_processor.Call();

		return Task.CompletedTask;
	}
}
