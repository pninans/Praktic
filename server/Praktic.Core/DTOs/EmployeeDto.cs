using Praktic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktic.Core.DTOs
{
    public enum Type { MALE, FEMALE }
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime BirthDate { get; set; }
        public Type TypeEmployee { get; set; }
        public List<Role> Roles { get; set; }
        public string Tz { get; set; }
    }
}
