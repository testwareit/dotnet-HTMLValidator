using System;
using System.Configuration;
using dotnetHtmlValidator.Helpers;
using dotnetHtmlValidator.Interfaces;

namespace dotnetHtmlValidator
{
    public class W3C_HTML_Obsolete : BaseValidator
    {
        public W3C_HTML_Obsolete()
        {
            var manager = ConfigurationManager.OpenExeConfiguration(this.GetType().Assembly.Location);
            ValidatorUrl = manager.AppSettings.Settings["w3c_URL"].Value;
        }

        public int ErrorCount; 
        public int WarningCount; 

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

        public Model.W3C.W3C_Html_JsonResponse GetJsonReportObjectized(string pageUrl)
        {
            RestHelper restHelper = new RestHelper(ValidatorUrl);
            restHelper.restRequest.AddQueryParameter("doc", pageUrl);
            restHelper.restRequest.AddQueryParameter("out", "json");

            return restHelper.GET<Model.W3C.W3C_Html_JsonResponse>();
        }

        public Model.W3C.W3CHtml_ReportModel GetReport(string pageUrl)
        {
            RestHelper restHelper = new RestHelper(ValidatorUrl);
            restHelper.restRequest.AddQueryParameter("doc", pageUrl);
            restHelper.restRequest.AddQueryParameter("out", "json");

            var reportJson = restHelper.GET<Model.W3C.W3C_Html_JsonResponse>();
            return new Model.W3C.W3CHtml_ReportModel(reportJson);
        }

        private int GetErrorCount()
        {
            int count = 0;



            return count;
        }
    }
}
