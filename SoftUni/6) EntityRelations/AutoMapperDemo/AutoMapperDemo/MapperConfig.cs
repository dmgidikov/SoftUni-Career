using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperDemo
{
    public class MapperConfig
    {
        public static Mapper InitializeAutomapper()
        {
            var confing = new MapperConfiguration(cfg =>
            cfg.CreateMap<Employee, EmployeeDTO>()
            .ForMember(x => x.FullName, y => y.MapFrom(x => x.Name))
            .ForMember(x => x.Dept, y => y.MapFrom(x => x.Department)));

            var mapper = new Mapper(confing);

            return mapper;
        }
    }
}
