namespace BuberDinner.Application.Commons.Interfaces;


public interface IJwtGenerator
{
    string GenerateToken(Guid userId, string firstName, string lastName);
}