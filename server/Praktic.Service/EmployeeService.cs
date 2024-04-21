using Praktic.Core.Entities;
using Praktic.Core.Repositories;
using Praktic.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktic.Service
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> AddAsync(Employee employee)
        {
           return await _employeeRepository.AddAsync(employee);
        }

        public async Task DeleteAsync(int id)
        {
           await _employeeRepository.DeleteAsync(id);
        }

      
        public Employee GetById(int employeeId)
        {
           return _employeeRepository.GetById(employeeId);
        }

        public List<Employee> GetAll()
        {
          return  _employeeRepository.GetAll();
        }

        public async Task<Employee> UpdateAsync(int id,Employee employee)
        {
          return await  _employeeRepository.UpdateAsync(id,employee);
        }
    }
}
