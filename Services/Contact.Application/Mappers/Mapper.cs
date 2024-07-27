﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Application.Mappers
{
    public class Mapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod!.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });
            return config.CreateMapper();
        });


        public static IMapper ProductMapper => Lazy.Value;
    }
}
