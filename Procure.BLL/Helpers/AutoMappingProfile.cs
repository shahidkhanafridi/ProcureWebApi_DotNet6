global using Procure.Data.Entities;
global using Procure.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procure.BLL.Helpers
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<Unit, UnitVM>()
                .ForMember(d => d.StatusLabel, o => o.MapFrom(s => s.IsActive ? "Active" : "Inactive"))
                ;
            CreateMap<UnitVM, Unit>();
        }
    }
}
