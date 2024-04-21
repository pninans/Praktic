//using Praktic.Core.Entities;
//using Praktic.Core.Repositories;
//using Praktic.Core.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Praktic.Service
//{
//    public class RoleService:IRoleService
//    {
//        private readonly IRoleRepository _roleRepository;
//        public RoleService(IRoleRepository roleRepository)
//        {
//            _roleRepository = roleRepository;
//        }

//        public async Task<Role> AddAsync(Role role)
//        {
//          return await  _roleRepository.AddAsync(role);
//        }

//        public async Task DeleteAsync(int id)
//        {
//           await _roleRepository.DeleteAsync(id);
//        }

       

//        public Role GetById(int roleId)
//        {
//           return _roleRepository.GetById(roleId);
//        }

//        public List<Role> GetAll()
//        {
//            return _roleRepository.GetAll();
//        }

//        public async Task<Role> UpdateAsync(int id,Role role)
//        {
//           return await _roleRepository.UpdateAsync(id,role);
//        }
//    }
//}
