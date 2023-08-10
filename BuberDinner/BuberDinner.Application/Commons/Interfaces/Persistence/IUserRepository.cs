using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Commons.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}