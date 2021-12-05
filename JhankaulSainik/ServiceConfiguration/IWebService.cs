using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JhankaulSainik.ServiceConfiguration
{
    public interface IWebService
    {
        Task<WebServiceResult<T>> PostAsync<T>(string action, string objectdata);
        Task<WebServiceResult<T>> GetAsync<T>(string action, string objectdata);
    }
}
