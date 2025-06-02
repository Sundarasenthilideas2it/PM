using ClairTourTiny.Core.Models.Projects;

namespace ClairTourTiny.Core.Interfaces
{
    public interface IProjectService
    {
        Task<List<Project>> GetProjects(string searchText);
        Task<List<Project>> GetRecentProjects(int numOfProjects);
        Task<List<Project>> GetFavouriteProjects();
    }
}
