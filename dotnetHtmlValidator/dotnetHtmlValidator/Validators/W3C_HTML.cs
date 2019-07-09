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

        
        public void GetHtmlReport(string pageUrl)
        {
            RestHelper restHelper = new RestHelper(ValidatorUrl);

            restHelper.restRequest.AddQueryParameter("doc", pageUrl);
            restHelper.restRequest.AddQueryParameter("out", "json");
            var result = restHelper.GET();
        }
    }
}
