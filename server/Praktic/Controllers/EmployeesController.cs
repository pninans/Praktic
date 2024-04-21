using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Praktic.API.Models;
using Praktic.Core;
using Praktic.Core.DTOs;
using Praktic.Core.Entities;
using Praktic.Core.Services;
using System.Data;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Praktic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    //[Authorize]
  

    public class EmployeesController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmployeesController(IEmployeeService employeeService,IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
         
        }
        // GET: api/<EmployeesController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _employeeService.GetAll();
            var listDto = new List<EmployeeDto>();
            foreach (var employee in list)
            {
                listDto.Add(_mapper.Map<EmployeeDto>(employee));
            }
            return Ok(listDto);
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var employee = _employeeService.GetById(id);
            var employeeDto = _mapper.Map<EmployeeDto>(employee);
            return Ok(employeeDto);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public async Task<Employee>  Post([FromBody] EmployeePostModel employee)
        {

            var employeeToAdd = new Employee
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                StartWork = employee.StartWork,
                BirthDate = employee.BirthDate,
                Roles = ConvertToRoleList(employee.Roles),
                Tz = employee.Tz,
                TypeEmployee = employee.TypeEmployee,
                Status = true
            };

            return await _employeeService.AddAsync(employeeToAdd);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public async Task<Employee> Put(int id,[FromBody] EmployeePostModel employee)
        {
           var employeeToUpdate = new Employee { FirstName = employee.FirstName, LastName = employee.LastName,
             StartWork = employee.StartWork, BirthDate = employee.BirthDate, Roles = ConvertToRoleList(employee.Roles),
              Tz = employee.Tz,TypeEmployee=employee.TypeEmployee,Status=true };
           return await _employeeService.UpdateAsync(id, employeeToUpdate);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
             await _employeeService.DeleteAsync(id);
        }
        private List<Role> ConvertToRoleList(List<RolePostModel> rolePostModels)
        {
            Console.WriteLine("dfghhmgfd");
            if (rolePostModels == null)
                return null;

            var roles = new List<Role>();
            foreach (var rolePostModel in rolePostModels)
            {
                Console.WriteLine(rolePostModel.Name);
                Console.WriteLine(rolePostModel.EnterWorking);
                Console.WriteLine(rolePostModel.IsPrincipal);
                roles.Add(new Role
                {
                    IsPrincipal = rolePostModel.IsPrincipal,
                    EnterWorking = rolePostModel.EnterWorking,
                    Name = rolePostModel.Name
                });
            }
            return roles;
        }
    }
}
