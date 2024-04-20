using Praktic.Core.Entities;
using Type = Praktic.Core.Entities.Type;

namespace Praktic.API.Models
{
    
    public class EmployeePostModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime BirthDate { get; set; }
        public Type TypeEmployee { get; set; }
        public List<RolePostModel> Roles { get; set; }
        public string Tz { get; set; }
    }
}
