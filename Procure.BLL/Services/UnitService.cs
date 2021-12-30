using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procure.BLL.Services
{
    public class UnitService : BaseService, IUnitService
    {
        public UnitService(IConfiguration config, IMapper mapper, IHttpContextAccessor httpContext) : base(config, mapper, httpContext)
        {
        }

        public UnitVM? CreateUnit(UnitVM model)
        {
            var theUser = _httpContext.HttpContext.Request.Headers["UserName"].ToString();
            UnitVM result = new();
            Unit objModel = _mapper.Map<Unit>(model);
            DynamicParameters dParams = new();
            dParams.Add(nameof(objModel.UnitCode), string.IsNullOrWhiteSpace(objModel.UnitCode) ? "" : objModel.UnitCode, direction: ParameterDirection.InputOutput);
            dParams.Add(nameof(objModel.UnitName), objModel.UnitName);
            dParams.Add(nameof(objModel.Description), objModel.Description);
            dParams.Add("RetVal", dbType: DbType.String, size: 500, direction: ParameterDirection.Output);

            using IDbConnection db = new SqlConnection(_connString);
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    var recAffected = db.Execute("SP_Unit_Upsert", dParams, commandType: CommandType.StoredProcedure, transaction: tran);
                    result.RetMessage = dParams.Get<string>("RetVal");
                    objModel.UnitCode = dParams.Get<string>("UnitCode");
                    tran.Commit();
                    if (recAffected > 0 && !string.IsNullOrWhiteSpace(objModel.UnitCode))
                        return _mapper.Map<UnitVM>(objModel);
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    try
                    {
                        tran.Rollback();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    throw;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }
        }
        public UnitVM? GetUnit(UnitVM model)
        {
            var theUser = _httpContext.HttpContext.Request.Headers["UserName"].ToString();
            DynamicParameters dParams = new();
            dParams.Add(nameof(model.BranchCode), model.BranchCode);
            dParams.Add(nameof(model.UnitCode), model.UnitCode);

            using IDbConnection db = new SqlConnection(_connString);
            Unit? result = db.Query<Unit>("SP_Unit_Get", dParams, commandType: CommandType.StoredProcedure).FirstOrDefault();
            if (result == null)
            {
                throw new KeyNotFoundException($"Unit not found against code {model.UnitCode}");
            }
            return _mapper.Map<UnitVM>(result);
        }
    }
}
