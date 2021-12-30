
using System.Data.SqlClient;
namespace Procure.Api.Helpers
{
    public static class ExceptionHandler
    {
        public static ApiResponse HandleEx(this Exception ex, IMapper mapper, string defaultMessage)
        {
            string retMessage = defaultMessage;
            if (ex.InnerException != null)
            {
                switch (ex.InnerException)
                {
                    case SqlException sqlEx:
                        switch (sqlEx.Number)
                        {
                            case int n when n >= 60000:
                                retMessage = sqlEx.Message;
                                break;
                        }
                        break;
                }
            }
            else
            {
                int errNum = ((System.Data.SqlClient.SqlException)ex).Number;
                retMessage = ex.Message;
                ExceptionModel exceptionModel = mapper.Map<ExceptionModel>(ex);
                //if (exceptionModel.Number >= 60000)
                //{
                retMessage = UniqueKeyVoilation(exceptionModel);
                //}
            }
            return ResponseHelper.Error(retMessage);
        }
        public static string UniqueKeyVoilation(ExceptionModel ex)
        {
            string retMessage = string.Empty;
            if (ex.Message.Contains("UC_") && ex.Message.Contains("UC_UnitCode"))
            {
                retMessage = "Record(s) already exist";
            }
            return retMessage;
        }
    }

    public class ExceptionModel
    {
        public int Number { get; set; }
        public string Message { get; set; }
    }
}
