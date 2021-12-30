
global using AutoMapper;
global using Microsoft.Extensions.Configuration;
global using Dapper;
global using System.Data;
global using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;

namespace Procure.BLL
{
    public class BaseService : IBaseService
    {
        protected readonly IConfiguration _config;
        protected readonly IMapper _mapper;
        protected string _connString = string.Empty;
        protected string _sqlText = string.Empty;
        protected readonly IHttpContextAccessor _httpContext;
        public BaseService(IConfiguration config, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _config = config;
            _mapper = mapper;
            _connString = _config.GetConnectionString("DefaultConn");
            _httpContext = httpContext;
        }
    }
}