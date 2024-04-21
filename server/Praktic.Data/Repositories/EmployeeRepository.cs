using Microsoft.EntityFrameworkCore;
using Praktic.Core.Entities;
using Praktic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktic.Data.Repositories
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Employee> AddAsync(Employee employee)
        {
            
            _context.employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task DeleteAsync(int id)
        {
            var employeeToDelete = GetById(id);
            if (employeeToDelete == null)
            {
                throw new KeyNotFoundException("Employee not found.");
            }

            // Remove the employee from the list

            employeeToDelete.Status = false;
             await _context.SaveChangesAsync();
           
        }

      
        public Employee GetById(int employeeId)
        {
            return _context.employees.Include(u => u.Roles).FirstOrDefault(e => e.Id == employeeId);
        }

        public List<Employee> GetAll()
        {
        
            return _context.employees.Where(e => e.Status == true).Include(u => u.Roles).ToList();

        }

        public async Task<Employee> UpdateAsync(int id,Employee employee)
        {
            var existingEmployee = GetById(id);
            if (existingEmployee == null)
            {
                throw new KeyNotFoundException("Employee not found.");
            }
            existingEmployee.FirstName = employee.FirstName;
            existingEmployee.LastName = employee.LastName;
            existingEmployee.StartWork = employee.StartWork;
            existingEmployee.BirthDate = employee.BirthDate;
            existingEmployee.TypeEmployee = employee.TypeEmployee;
            existingEmployee.Roles =null;
            existingEmployee.Roles = employee.Roles;
            existingEmployee.Status=employee.Status;
            await _context.SaveChangesAsync();
            return employee;
        }
    }
}
