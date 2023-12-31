using BuberDinner.Application.Commons.Interfaces.Persistence;
using BuberDinner.Domain.Entities;

namespace BuberDinner.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    // private readonly DbContext _context;
    private static readonly List<User> _users = new();

    public void Add(User user)
    {
      _users.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
      return _users.SingleOrDefault(u => u.Email == email);
    }
}
