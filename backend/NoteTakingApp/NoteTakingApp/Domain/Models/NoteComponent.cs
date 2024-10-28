namespace NoteTakingApp.Domain.Models;

public record NoteComponent
{
    public required string Id { get; init; }
    
    public required NoteComponentType Type { get; init; }
    
    public required string Value { get; init; }
}