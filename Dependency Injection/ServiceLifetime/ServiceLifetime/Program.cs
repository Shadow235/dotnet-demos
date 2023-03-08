// Source: https://medium.com/volosoft/asp-net-core-dependency-injection-58bc78c5d369

using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();

services.AddSingleton<SingletonService>();
services.AddTransient<TransientService>();
services.AddScoped<ScopedService>();

var serviceProvider = services.BuildServiceProvider();


// Singleton - object of service class is created only once and every other GetService will return the same object for the class

// 1. Call create new object of SingletonService class
var singleton1 = serviceProvider.GetRequiredService<SingletonService>();

// 2. Call returns same object from 1. call
var singleton2 = serviceProvider.GetRequiredService<SingletonService>(); // singleton1 == singleton2 -> they reference same object


// Transient - New object of service is created everytime on each GetService (GetRequiredService)

// 1. Call create new object of TransientService class
var transient1 = serviceProvider.GetRequiredService<TransientService>();

// 2. Call create new object of TransientService class 
var transient2 = serviceProvider.GetRequiredService<TransientService>();


// Scoped - scope is similar to singleton, but service is created once per scope

using (var scope = serviceProvider.CreateScope())
{
	// 1. Call create new object of ScopedService
	var scoped1 = serviceProvider.GetRequiredService<ScopedService>();

	// 2. Call returns object from 1. Call
	var scoped2 = serviceProvider.GetRequiredService<ScopedService>();
}

using (var scope = serviceProvider.CreateScope())
{
	// 3. Call new object is created
	var scoped3 = serviceProvider.GetRequiredService<ScopedService>();

	// 4. Call returns object from 3. Call
	var scoped4 = serviceProvider.GetRequiredService<ScopedService>();
}


class SingletonService
{
	public SingletonService()
	{
		Console.WriteLine("SingletonService constructor");
	}
}

class TransientService
{
	public TransientService()
	{
		Console.WriteLine("TransientService constructor");
	}
}

class ScopedService
{
	public ScopedService()
	{
		Console.WriteLine("ScopedService constructor");
	}
}