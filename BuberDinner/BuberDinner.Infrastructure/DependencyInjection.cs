using BuberDinner.Application.Commons.Interfaces;
using BuberDinner.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Infrastructure;

public static class DependencyInjection {

    public static IServiceCollection AddInfrastructure(this IServiceCollection services) {
        services.AddSingleton<IJwtGenerator, JwtGenerator>();
        
        return services;
    }
}