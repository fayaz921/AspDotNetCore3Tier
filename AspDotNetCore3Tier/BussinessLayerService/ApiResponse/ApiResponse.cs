using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayerService.ApiResponse
{
    public class ApiResponse<T>
    {
        public T? Data { get; set; }
        public bool IsSuccess { get; set; }
        public string? Error { get; set; }

        public static ApiResponse<T> SuccessResponse(T? data)
        {
            return new ApiResponse<T>
            {
                Data = data,
                IsSuccess = true
            };
        }

        public static ApiResponse<T> FailureResponse(string? error)
        {
            return new ApiResponse<T>
            {
                Error = error,
                IsSuccess = false
            };
        }
    }
}
