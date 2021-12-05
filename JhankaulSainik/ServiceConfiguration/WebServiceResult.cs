using System;
using System.Collections.Generic;
using System.Text;

namespace JhankaulSainik.ServiceConfiguration
{
    public class WebServiceResult : IWebServiceResult
    {
        public WebServiceResult()
        {

        }
        public int ErrorCode { get ; set ; }
        public string ErrorMessage { get ; set ; }

        public bool IsSuccess
        {
            get
            {
                return ErrorCode == 0 ? true : false;
            }
        }
    }
    public class WebServiceResult<TData> : WebServiceResult, IWebServiceResult<TData>
    {
        public TData Data { get ; set ; }
    }
    //public class WebSeviceResult<T>
    //{
    //}
}
