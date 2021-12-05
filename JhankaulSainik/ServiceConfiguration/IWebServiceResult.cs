using System;
using System.Collections.Generic;
using System.Text;

namespace JhankaulSainik.ServiceConfiguration
{
    public interface IWebServiceResult
    {
        int ErrorCode { get; set; }
        string ErrorMessage { get; set; }
        bool IsSuccess { get; }
    }
    public interface IWebServiceResult<TData> : IWebServiceResult
    {
        TData Data { get; set; }
    }
}
