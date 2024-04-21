using AutoMapper;
using Praktic.Core.DTOs;
using Praktic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktic.Core.Mapping
  { 
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Employee, EmployeeDto>().ReverseMap();
            }
        }
    }

