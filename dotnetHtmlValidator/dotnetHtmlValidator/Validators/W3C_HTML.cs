using System;
using System.Configuration;
using dotnetHtmlValidator.Helpers;

namespace dotnetHtmlValidator
{
    public class W3C_HTML : BaseValidator
    {
        public W3C_HTML()
        {
            var manager = ConfigurationManager.OpenExeConfiguration(this.GetType().Assembly.Location);
            ValidatorUrl = manager.AppSettings.Settings["w3c_URL"].Value;
        }

        public string GetHtmlReport(string pageUrl)
        {
            RestHelper restHelper = new RestHelper(ValidatorUrl);
            restHelper.restRequest.AddQueryParameter("doc", pageUrl);

            return restHelper.GET().Content;
        }

        public string GetJsonReport(string pageUrl)
        {
            RestHelper restHelper = new RestHelper(ValidatorUrl);
            restHelper.restRequest.AddQueryParameter("doc", pageUrl);
            restHelper.restRequest.AddQueryParameter("out", "json");

            return restHelper.GET().Content;
        }

        public Model.W3C.W3C_Html_Json_Model GetJsonReportObjectized(string pageUrl)
        {
            RestHelper restHelper = new RestHelper(ValidatorUrl);
            restHelper.restRequest.AddQueryParameter("doc", pageUrl);
            restHelper.restRequest.AddQueryParameter("out", "json");

            return restHelper.GET<Model.W3C.W3C_Html_Json_Model>();
        }

        public Model.W3C.W3C_Html_Report GetReport(string pageUrl)
        {
            RestHelper restHelper = new RestHelper(ValidatorUrl);
            restHelper.restRequest.AddQueryParameter("doc", pageUrl);
            restHelper.restRequest.AddQueryParameter("out", "json");

            var reportJson = restHelper.GET<Model.W3C.W3C_Html_Json_Model>();
            return new Model.W3C.W3C_Html_Report(reportJson);
        }
    }
}
