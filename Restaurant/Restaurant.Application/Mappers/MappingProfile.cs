using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Restaurant.Application.Responses;
using Restaurant.Core.Entities;

namespace Restaurant.Application.Mappers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer,CustomerResponse>().ReverseMap();
        }
    }
}
