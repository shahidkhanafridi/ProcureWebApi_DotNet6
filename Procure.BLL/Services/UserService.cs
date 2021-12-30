using Microsoft.AspNetCore.Http;
using Procure.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procure.BLL.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(IConfiguration config, IMapper mapper, IHttpContextAccessor httpContext) : base(config, mapper, httpContext)
        {
        }
    }
}
