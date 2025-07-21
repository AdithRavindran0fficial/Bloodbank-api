using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Common.Response
{
    public class ApiResponse<T>
    {
        public string Message { get; set; }
        public T? Data { get; set; }
        public int Status { get; set; }
        public bool Success { get; set; }
        public ApiResponse( string messsage , int status, bool success, T? data = default)
        {
            
            Message = messsage;
            Data = data;
            Status = status;
            Success = success;
            
                
       }

    }
}
