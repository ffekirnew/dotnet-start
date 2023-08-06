using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BuberDinner.Application.Commons.Interfaces.Authentication;
using BuberDinner.Application.Commons.Interfaces.Services;
using Microsoft.IdentityModel.Tokens;

namespace BuberDinner.Infrastructure.Authentication;


public class JwtGenerator : IJwtGenerator {
    private readonly IDateTimeProvider _dateTimeProvider;

    public JwtGenerator(IDateTimeProvider dateTimeProvider)
    {
        _dateTimeProvider = dateTimeProvider;
    }

    public string GenerateToken(Guid userId, string firstName, string lastName) {
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("super-secret-key")),
            SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim> {
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var securityToken = new JwtSecurityToken(
            issuer: "BuberDinner",
            audience: "BuberDinner",
            expires: _dateTimeProvider.UtcNow.AddMinutes(60),
            signingCredentials: signingCredentials,
            claims: claims);
        
        // return new JwtSecurityTokenHandler().WriteToken(securityToken);
        return "hello";
    }
}