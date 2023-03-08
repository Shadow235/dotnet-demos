using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace MultipleProjectDependency.Processor.Extensions
{
	public static class ServiceRegistration
	{
		public static IServiceCollection AddProcessor(this IServiceCollection services)
		{
			services.AddSingleton<IProcessor, Processor>();

			return services;
		}
	}
}
