using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClairTourTiny.Infrastructure.Dto.Projects
{
    public class ProjectRecentDto
    {
        public required string EntityNo { get; set; }
        public required string EntityDesc { get; set; }
        public required string ProjectGroup { get; set; }
        public required long DisplayOrder { get; set; }
        public required long GroupDisplayOrder { get; set; }
    }
}
