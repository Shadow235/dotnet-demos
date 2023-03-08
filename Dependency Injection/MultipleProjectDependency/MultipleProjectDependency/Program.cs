using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MultipleProjectDependency.DataHandler.Extensions;
using MultipleProjectDependency.Processor.Extensions;
using MultipleProjectDependency.Services;

IHost host = Host.CreateDefaultBuilder(args)
	.ConfigureServices((context, services) =>
	{
		services.AddHandler();
		services.AddProcessor(); // add dependency from Processor project
		services.AddHostedService<ProcessorDemoServices>(); // for testing 
	}).Build();

await host.RunAsync();