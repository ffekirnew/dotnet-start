using BuberDinner.Application.Commons.Interfaces.Authentication;
using BuberDinner.Application.Commons.Interfaces.Persistence;
using BuberDinner.Application.Commons.Interfaces.Services;
using BuberDinner.Infrastructure.Authentication;
using BuberDinner.Infrastructure.Persistence;
using BuberDinner.Infrastructure.Sevices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Infrastructure;

public static class DependencyInjection {

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration) {
        services.AddSingleton<IJwtGenerator, JwtGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddScoped<IUserRepository, UserRepository>();
        
        return services;
    }
}
