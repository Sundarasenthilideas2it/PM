using ClairTourTiny.Core.Interfaces;
using ClairTourTiny.Core.Models.Projects;
using Microsoft.AspNetCore.Mvc;

namespace ClairTourTiny.API.Controllers.V2
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProjectController(IProjectService projectService) : ControllerBase
    {
        private IProjectService _projectService = projectService;

        [HttpGet("favorites")]
        [ProducesResponseType(typeof(List<Project>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFavoriteProjects() => Ok(await _projectService.GetFavouriteProjects());

        [HttpGet("recent")]
        [ProducesResponseType(typeof(List<Project>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetRecentProjects([FromQuery] int numberOfProjects = 100)
        {
            var projects = await _projectService.GetRecentProjects(numberOfProjects);
            return Ok(projects);
        }

        [HttpGet("search/{searchTerm}")]
        [ProducesResponseType(typeof(List<Project>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SearchProjects(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return Ok(new List<Project>());
            }
            try
            {
                var projects = await _projectService.GetProjects(searchTerm);
                return Ok(projects);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
