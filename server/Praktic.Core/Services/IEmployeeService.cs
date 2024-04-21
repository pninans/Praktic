using Praktic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktic.Core.Services
{
    public interface IEmployeeService
    {
       List<Employee> GetAll();

        Employee GetById(int employeeId);

        Task<Employee> AddAsync(Employee employee);

        Task<Employee> UpdateAsync(int id,Employee employee);

        Task DeleteAsync(int id);
    }
}
