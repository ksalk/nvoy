using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nvoy.Clients;

namespace Nvoy;

public static class NvoyServiceCollectionExtensions
{
    public static IServiceCollection AddNvoy(this IServiceCollection services, IConfiguration configuration)
    {
        // Register OpenAI options from configuration
        services.Configure<NvoyOpenAIOptions>(configuration.GetSection(NvoyOpenAIOptions.SectionName));

        // Register the NvoyChatClient
        services.AddScoped<INvoyChatClient, NvoyOpenAIChatClient>();

        return services;
    }
}
