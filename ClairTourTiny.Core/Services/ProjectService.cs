using AutoMapper;
using ClairTourTiny.Core.Interfaces;
using ClairTourTiny.Core.Models.Projects;
using ClairTourTiny.Infrastructure;
using ClairTourTiny.Infrastructure.Dto.Projects;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ClairTourTiny.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly ClairTourTinyContext _clairTourTinyContext;
        private readonly IMapper _mapper;

        public ProjectService(ClairTourTinyContext clairTourTinyContext, IMapper mapper)
        {
            _clairTourTinyContext = clairTourTinyContext;
            _mapper = mapper;
        }

        public async Task<List<Project>> GetFavouriteProjects()
        {
            var projectDtos = await _clairTourTinyContext.ExecuteStoredProcedureAsync<ProjectFavouriteDto>("get_favorite_projects", []);
            return _mapper.Map<List<Project>>(projectDtos);
        }

        public async Task<List<Project>> GetProjects(string searchText)
        {
            var param = new SqlParameter("@search", searchText);
            var projectDtos = await _clairTourTinyContext.ExecuteStoredProcedureAsync<ProjectSearchDto>("search_for_project", param);
            return _mapper.Map<List<Project>>(projectDtos);
        }

        public async Task<List<Project>> GetRecentProjects(int numOfProjects)
        {
            var param = new SqlParameter("@number_of_projects",numOfProjects);
            var projectDtos = await _clairTourTinyContext.ExecuteStoredProcedureAsync<ProjectRecentDto>("get_recent_projects", param);
            return _mapper.Map<List<Project>>(projectDtos);
        }
    }
}
