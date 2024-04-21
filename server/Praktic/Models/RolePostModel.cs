using Praktic.Core.Entities;

namespace Praktic.API.Models
{

    public class RolePostModel
    {
        public bool IsPrincipal { get; set; }
        public DateTime EnterWorking { get; set; }
        public RoleName Name { get; set; }

    }
}
