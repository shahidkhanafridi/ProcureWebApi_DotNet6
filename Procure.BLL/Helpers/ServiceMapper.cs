﻿global using Procure.BLL.Interfaces;
global using Procure.BLL.Services;
using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Procure.BLL.Helpers
{
    public static class ServiceMapper
    {
        public static void MapServices(this IServiceCollection services)
        {
            services.AddTransient<IBaseService, BaseService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUnitService, UnitService>();
        }
    }
}
