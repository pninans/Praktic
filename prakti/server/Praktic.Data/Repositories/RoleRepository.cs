//using Praktic.Core.Entities;
//using Praktic.Core.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Praktic.Data.Repositories
//{
//    public class RoleRepository:IRoleRepository
//    {
//        private readonly DataContext _context;
//        public RoleRepository(DataContext context)
//        {
//            _context = context;
//        }

//        public async Task<Role> AddAsync(Role role)
//        {
//           _context.roles.Add(role);
//           await _context.SaveChangesAsync();
//            return role;
//        }

//        public async Task DeleteAsync(int id)
//        {
//            var roleToDelete = GetById(id);
//            if (roleToDelete == null)
//            {
//                throw new KeyNotFoundException("Role not found.");
//            }

//            // Remove the employee from the list
//            _context.roles.Remove(roleToDelete);
//           await _context.SaveChangesAsync();
//        }

      

//        public Role GetById(int roleId)
//        {
//            return _context.roles.FirstOrDefault(e => e.Id == roleId);
//        }

//        public List<Role> GetAll()
//        {
//            return _context.roles.ToList();
//        }

//        public async Task<Role> UpdateAsync(int id,Role role)
//        {
//            var existingRole =GetById(id);
//            if (existingRole == null)
//            {
//                throw new KeyNotFoundException("Role not found.");
//            }

//            existingRole.IsPrincipal = role.IsPrincipal;
//            existingRole.EnterWorking = role.EnterWorking;
//            existingRole.Name = role.Name;
//            await _context.SaveChangesAsync();
//            return role;
//        }
//    }
//}
