using Gremlin.Net.Driver;
using NoteTakingApp.Domain.Models;

namespace NoteTakingApp.Infrastructure.Repositories;

public class ProjectsRepository(IGremlinClient gremlinClient)
{
    public async Task AddProject(Project project)
    {
        var addProject = $"g.addV('Project')" +
                           $".property('id', '{project.Id}')" +
                           $".property('userId', '{project.UserId}')" +
                           $".property('name', '{project.Name}')";
        await gremlinClient.SubmitAsync(addProject);
    }
}