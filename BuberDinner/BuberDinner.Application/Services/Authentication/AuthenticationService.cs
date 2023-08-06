using BuberDinner.Application.Commons.Interfaces.Authentication;

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
        Guid userId = Guid.NewGuid();
        var token = _jwtGenerator.GenerateToken(userId, "Name", "LastName");

        return new AuthenticationResult(
            userId,
            firstName,
            lastName,
            email,
            token);
    }
}