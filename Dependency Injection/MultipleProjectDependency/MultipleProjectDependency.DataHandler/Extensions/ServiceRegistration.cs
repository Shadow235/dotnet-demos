using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace MultipleProjectDependency.DataHandler.Extensions;

public static class ServiceRegistration
{
	public static IServiceCollection AddHandler(this IServiceCollection services)
	{
		services.AddSingleton<Handler>();

		return services;
	}
}
