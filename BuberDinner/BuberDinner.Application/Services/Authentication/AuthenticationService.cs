using BuberDinner.Application.Commons.Interfaces.Authentication;
using BuberDinner.Application.Commons.Interfaces.Persistence;
using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtGenerator _jwtGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtGenerator jwtGenerator, IUserRepository userRepository)
    {
        _jwtGenerator = jwtGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationResult Login(string email, string password)
    {
        // Check if the user exists
        if (_userRepository.GetUserByEmail(email) is not User user)
        {
            throw new Exception("User with that email does not exist");
        }
        // Check if the passwordk is correct

        if (user.Password != password)
        {
            throw new Exception("Password is incorrect");
        }
        // Generate a JWT token
        var token = _jwtGenerator.GenerateToken(user);
        // Return the result
        return new AuthenticationResult(user, token);
    }

    public AuthenticationResult Register(
        string firstName,
        string lastName,
        string email,
        string password
    )
    {
        // Check if a user already exists, If exists, throw an exception
        if (_userRepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("User with that email already exists");
        }
        // Create user (generate a unique id)
        Guid userId = Guid.NewGuid();
        var user = new User
        {
            Id = userId,
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        };

        // Generate a token
        var token = _jwtGenerator.GenerateToken(user);
        return new AuthenticationResult(user, token);
    }
}
