using Microsoft.Extensions.DependencyInjection;
using MultipleProjectDependency.DataHandler;

namespace MultipleProjectDependency.Processor;

public class Processor : IProcessor
{
	private readonly IServiceProvider _serviceProvider;

	public Processor(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
	}

	public void Call()
	{
		Console.WriteLine("Processor.Call: ");

		// IServiceProvider.GetService() vs. IServiceProvider.GetRquiredService()
		// GetService() returns null if a service does not exist, GetRequiredService() throws an exception instead.
		// If you're using a third-party container, use GetRequiredService where possible - in the event of an exception,
		// the third party container may be able to provide diagnostics so you can work out why an expected service wasn't registered.
		var handler = _serviceProvider.GetRequiredService<Handler>();

		Console.WriteLine(handler.Read());
		handler.Write("Log from Processor");
	}
}
