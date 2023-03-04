namespace Freddie.API.Models;

public record Student
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Score { get; set; }
}