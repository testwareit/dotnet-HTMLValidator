using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace dotnetHtmlValidator.Helpers
{
    public class RestHelper
    {
        RestClient restClient;
        public RestRequest restRequest;

        public RestHelper(string baseUrl)
        {
            restClient = new RestClient(baseUrl);
            restRequest = new RestRequest();
        }

        #region GET
        public T GET<T>() where T: new()
        {
            restRequest.Method = Method.GET;
            var response = restClient.ExecuteTaskAsync<T>(restRequest);
            response.Wait();
            return response.Result.Data;
        }

        public IRestResponse GET()
        {
            restRequest.Method = Method.GET;
            Task<IRestResponse> t = restClient.ExecuteTaskAsync(restRequest);
            t.Wait();
            return t.Result;
        }
        public IRestResponse GET(string url)
        {
            restRequest.Resource = url;
            restRequest.Method = Method.GET;
            Task<IRestResponse> t = restClient.ExecuteTaskAsync(restRequest);
            t.Wait();
            return t.Result;
        }
        public object GETContent()
        {
            return GET().Content;
        }
        #endregion


        #region POST
        public IRestResponse POST(string url, object payload)
        {
            restRequest.Resource = url;
            restRequest.AddObject(payload);
            Task<IRestResponse> t = restClient.ExecuteTaskAsync(restRequest);
            t.Wait();
            return t.Result;
        }
        #endregion
    }
}
