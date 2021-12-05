using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JhankaulSainik.ServiceConfiguration
{
    public class WebService : Constants, IWebService
    {
        private async Task<WebServiceResult<T>> SendRequest<T>(string action, string parameters, string method)
        {
            try
            {
                HttpClient httpClient = new HttpClient
                {
                    BaseAddress = new Uri(BaseURL)
                };
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = null;
                WebServiceResult<T> result = new WebServiceResult<T>();
                if(method == "POST")
                {
                    HttpContent Content = new StringContent(parameters, Encoding.UTF8, "application/json");
                    response = await httpClient.PostAsync(action, Content);
                }
                else if(method == "GET")
                {
                    HttpRequestMessage req1 = new HttpRequestMessage(HttpMethod.Get, action)
                    {
                        Content = new StringContent(parameters, Encoding.UTF8, "application/json")
                    };
                    response = await httpClient.GetAsync(req1.RequestUri);
                }
                if(response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    if(!string.IsNullOrEmpty(responseString))
                    {
                        var dataResult = JsonConvert.DeserializeObject<WebServiceResult<object>>(responseString);
                        result.ErrorCode = result.ErrorCode;
                        result.ErrorMessage = dataResult.ErrorMessage;
                        if(dataResult.Data != null)
                        {
                            var dataValue = JsonConvert.DeserializeObject<T>(dataResult.Data.ToString());
                            result.Data = dataValue;
                        }
                    }
                    else
                    {
                        result.ErrorCode = 1;
                        result.ErrorMessage = response.ReasonPhrase;
                    }
                }
                else
                {
                    result.ErrorCode = 1;
                    result.ErrorMessage = response.ReasonPhrase;
                }
                return result;
            }
            catch (Exception Ex)
            {
                if (Ex.InnerException.Message == "Error: Connection Failure (Network is unreachable)")
                {
                    return new WebServiceResult<T>() { ErrorCode = 1, ErrorMessage = "Please chekc your internet connection." };
                }
                else
                {
                    return new WebServiceResult<T>() { ErrorCode = 1, ErrorMessage = Ex.Message };
                }
            }
        }

        public Task<WebServiceResult<T>> SendRequestAsync<T>(string action, string parameters, string method)
        {
            return Task.Run(() =>
            {
                return SendRequest<T>(action, parameters, method);
            });
        }
        public Task<WebServiceResult<T>> GetAsync<T>(string action, string objectdata)
        {
            return SendRequestAsync<T>(action, objectdata, "GET");
        }

        public Task<WebServiceResult<T>> PostAsync<T>(string action, string objectdata)
        {
            return SendRequestAsync<T>(action, objectdata, "POST");
        }

        public WebService()
        {

        }
    }
}
