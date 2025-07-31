using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Nvoy.DependancyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddNvoy(this IServiceCollection services, IConfiguration configuration)
    {
        // Register OpenAI options from configuration
        services.Configure<OpenAIOptions>(configuration.GetSection(OpenAIOptions.SectionName));

        return services;
    }
}
