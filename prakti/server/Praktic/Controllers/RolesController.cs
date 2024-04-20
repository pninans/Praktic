//using Microsoft.AspNetCore.Mvc;
//using Praktic.API.Models;
//using Praktic.Core.Entities;
//using Praktic.Core.Services;
//using System.Security.Principal;
//using System.Xml.Linq;

//namespace Praktic.API.Controllers
//{
//    [Route("api/[controller]")]
//    public class RolesController
//    {
//        private readonly IRoleService _roleService;
//        public RolesController(IRoleService roleService)
//        {
//            _roleService = roleService;
//        }
//        // GET: api/<EmployeesController>
//        [HttpGet]
//        public IEnumerable<Role> Get()
//        {
//            return _roleService.GetAll();
//        }

//        // GET api/<EmployeesController>/5
//        [HttpGet("{id}")]
//        public Role Get(int id)
//        {
//            return _roleService.GetById(id);
//        }

//        // POST api/<EmployeesController>
//        [HttpPost]
//        public async Task<Role> Post([FromBody] RolePostModel role)
//        {
//            var roleToAdd = new Role { IsPrincipal = role.IsPrincipal, EnterWorking = role.EnterWorking, Name = role.Name };
//            return await _roleService.AddAsync(roleToAdd);
//        }

//        // PUT api/<EmployeesController>/5
//        [HttpPut("{id}")]
//        public async Task<Role> Put(int id, [FromBody] RolePostModel role)
//        {
//            var roleToUpdate = new Role { IsPrincipal = role.IsPrincipal, EnterWorking = role.EnterWorking, Name = role.Name };
//            return await _roleService.UpdateAsync(id, roleToUpdate);
//        }

//        // DELETE api/<EmployeesController>/5
//        [HttpDelete("{id}")]
//        public async Task Delete(int id)
//        {
//            await _roleService.DeleteAsync(id);
//        }
//    }
//}
