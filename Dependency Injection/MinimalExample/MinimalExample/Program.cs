// https://medium.com/volosoft/asp-net-core-dependency-injection-58bc78c5d369

using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();

services.AddTransient<MyService>();

var serviceProvider = services.BuildServiceProvider();

// IServiceProvider.GetService() vs. IServiceProvider.GetRquiredService()
// GetService() returns null if a service does not exist, GetRequiredService() throws an exception instead.
// If you're using a third-party container, use GetRequiredService where possible - in the event of an exception,
// the third party container may be able to provide diagnostics so you can work out why an expected service wasn't registered.
var myService = serviceProvider.GetService<MyService>();

myService?.DoIt();

public class MyService
{
	public void DoIt()
	{
		Console.WriteLine("Hello MS DI!");
	}
}