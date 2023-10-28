using AutoMapper;
using CarImport.Core.Models.Customer;
using CarImport.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer,CustomerDTO>().ReverseMap();
        }
    }
}
