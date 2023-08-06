using BuberDinner.Application.Commons.Interfaces.Services;

namespace BuberDinner.Infrastructure.Sevices;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}