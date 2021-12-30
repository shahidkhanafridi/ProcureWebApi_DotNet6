using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procure.BLL.Helpers
{
    public static class CustomExtensions
    {
        public static string GetControllerName(this IHttpContextAccessor httpContextAccessor)
        {
            return "";
        }
    }
}
