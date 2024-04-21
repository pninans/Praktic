using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktic.Core.Entities
{
    public enum RoleName { TECHER, PRINCIPAL, DEVELOPER }
    public class Role
    {
        public int Id { get; set; }
        public bool IsPrincipal { get; set; }
        public DateTime EnterWorking { get; set; }
        public RoleName Name { get; set; }

     
    }
}
