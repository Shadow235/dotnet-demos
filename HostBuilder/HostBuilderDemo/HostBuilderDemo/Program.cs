
using HostBuilderDemo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder(args)
	.ConfigureServices((context, services) => 
	{
		services.AddHostedService<Worker>();
	}).Build();

await host.RunAsync();