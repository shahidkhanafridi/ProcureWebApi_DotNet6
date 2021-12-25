using Procure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procure.BLL.Helpers
{
    public static class ResponseHelper
    {
        public static ApiResponse Success()
        {
            return new ApiResponse();
        }
        public static ApiResponse Success(object data)
        {
            return new ApiResponse() { Data = data, IsSuccess = true };
        }
        public static ApiResponse Success(string message)
        {
            return new ApiResponse() { Message = message, IsSuccess = true };
        }
        public static ApiResponse Success(object data, string message)
        {
            return new ApiResponse() { Data = data, Message = message, IsSuccess = true };
        }

        public static ApiResponse Error(string message)
        {
            return new ApiResponse() { IsError = true, Message = message };
        }
        public static ApiResponse ExceptionResponse(string message)
        {
            return new ApiResponse() { IsException = true, Message = message };
        }
    }
}
