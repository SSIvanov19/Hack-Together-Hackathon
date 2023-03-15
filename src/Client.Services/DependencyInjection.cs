using Microsoft.Extensions.DependencyInjection;
using Client.Services.Contracts;
using Client.Services.Implementations;

namespace Client.Services;

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
            .AddScoped<IChatService, ChatService>()
            .AddScoped<IEventsService, EventsService>();
    }
}