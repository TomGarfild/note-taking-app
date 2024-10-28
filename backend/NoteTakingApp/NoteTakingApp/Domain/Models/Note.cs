namespace NoteTakingApp.Domain.Models;

public record Note
{
    public required string Id { get; init; }
    
    public string? Headline { get; init; }
}