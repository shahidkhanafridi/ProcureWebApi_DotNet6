using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procure.Data.Models
{
    public interface IApiResponse
    {
    }
    public class ApiResponse : IApiResponse
    {
        public bool? IsError { get; set; }
        public bool? IsSuccess { get; set; }
        public bool? IsException { get; set; }
        public string? StatucCode { get; set; }
        public string? Message { get; set; }
        public Object? Data { get; set; }
    }
}
