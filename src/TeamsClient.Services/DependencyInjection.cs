using Microsoft.Extensions.DependencyInjection;
using TeamsClient.Services.Contracts;
using TeamsClient.Services.Implementations;

namespace TeamsClient.Services;

/// <summary>
/// Dependency Injection.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Add Services.
    /// </summary>
    /// <param name="services">Services.</param>
    public static void AddServices(this IServiceCollection services)
    {
        services
            .AddScoped<IOneDriveService, OneDriveService>()
            .AddScoped<IChatService, ChatService>();
    }
}