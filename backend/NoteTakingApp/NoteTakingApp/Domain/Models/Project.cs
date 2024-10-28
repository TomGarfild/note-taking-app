namespace NoteTakingApp.Domain.Models;

public record Project
{
    public required string Id { get; init; }
    
    public required string UserId { get; init; }
    
    public required string Name { get; init; }
}