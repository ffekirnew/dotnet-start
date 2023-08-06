using BuberDinner.Application.Commons.Interfaces.Authentication;
using BuberDinner.Application.Commons.Interfaces.Services;
using BuberDinner.Infrastructure.Authentication;
using BuberDinner.Infrastructure.Sevices;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Infrastructure;

public static class DependencyInjection {

    public static IServiceCollection AddInfrastructure(this IServiceCollection services) {
        services.AddSingleton<IJwtGenerator, JwtGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        
        return services;
    }
}