using BuberDinner.Application.Commons.Interfaces;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtGenerator _jwtGenerator;

    public AuthenticationService(IJwtGenerator jwtGenerator)
    {
        _jwtGenerator = jwtGenerator;
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "Name",
            "LastName",
            email,
            "token");    
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // Check if a user already exists
        // Create user (generate a unique id)
        // Generate a token
        var token = _jwtGenerator.GenerateToken(Guid.NewGuid(), "Name", "LastName");
        Guid userId = Guid.NewGuid();
        return new AuthenticationResult(
            userId,
            firstName,
            lastName,
            email,
            token);
    }
}