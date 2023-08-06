namespace BuberDinner.Application.Commons.Interfaces.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}