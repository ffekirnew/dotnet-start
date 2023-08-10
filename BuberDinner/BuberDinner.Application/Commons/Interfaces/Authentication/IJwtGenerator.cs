using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Commons.Interfaces.Authentication;

public interface IJwtGenerator
{
    string GenerateToken(User user);
}
