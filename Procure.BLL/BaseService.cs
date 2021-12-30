
global using AutoMapper;
global using Microsoft.Extensions.Configuration;
global using Dapper;
global using System.Data;
global using System.Data.SqlClient;


namespace Procure.BLL
{
    public class BaseService : IBaseService
    {
        protected readonly IConfiguration _config;
        protected readonly IMapper _mapper;
        protected string _connString = string.Empty;
        protected string _sqlText = string.Empty;
        public BaseService(IConfiguration config, IMapper mapper)
        {
            _config = config;
            _mapper = mapper;
            _connString = _config.GetConnectionString("DefaultConn");
        }
    }
}