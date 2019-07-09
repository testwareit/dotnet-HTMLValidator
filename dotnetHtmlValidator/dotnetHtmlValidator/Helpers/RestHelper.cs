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

        public async void POST(string url, object payload)
        {
            restRequest.Resource = url;
            restRequest.AddObject(payload);
            Task<IRestResponse> t = restClient.ExecuteTaskAsync(restRequest);
            t.Wait();
            var restResponse = await t;
        }

        public async Task<IRestResponse> GET()
        {
            restRequest.Method = Method.GET;
            Task<IRestResponse> t = restClient.ExecuteTaskAsync(restRequest);
            t.Wait();
            return await t;
        }
        public async void GET(string url)
        {
            restRequest.Resource = url;
            restRequest.Method = Method.GET;
            Task<IRestResponse> t = restClient.ExecuteTaskAsync(restRequest);
            t.Wait();
            var restResponse = await t;
        }
    }
}
