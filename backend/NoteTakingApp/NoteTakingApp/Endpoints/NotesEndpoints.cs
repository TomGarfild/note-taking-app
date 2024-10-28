using NoteTakingApp.Domain.Models;

namespace NoteTakingApp.Endpoints;

public static class NotesEndpoints
{
    public static void AddNotesEndpoints(this WebApplication app)
    {
        app.MapGet("/notes/{userId}", (string userId) =>
        {
            return new List<Note>();
        });
    }
}