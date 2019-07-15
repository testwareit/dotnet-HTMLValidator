using dotnetHtmlValidator.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace dotnetHtmlValidator.Validators
{
    internal class W3C_Html_Validator_Helper
    {
        IW3CHtmlReportGenerator generator;

        public object GenerateReportByType(IW3CHtmlReportGenerator generatorType, string urlToValidate)
        {
            generator = generatorType;
            return generator.CallValidatorForReport(urlToValidate);
        }
    }

    internal class W3C_ReportGenerator_Custom : W3C_ReportGenerator_JsonAsObject
    {
        public W3C_ReportGenerator_Custom()
        {

        }
    }

    internal class W3C_ReportGenerator_Json : BaseW3CValidator, IW3CHtmlReportGenerator
    {
        public RestHelper restHelper { get; set; }

        public object CallValidatorForReport(string urlToValidate)
        {
            restHelper = new RestHelper(ValidatorUrl);
            restHelper.restRequest.AddQueryParameter("doc", urlToValidate);
            restHelper.restRequest.AddQueryParameter("out", "json");

            return restHelper.GET().Content;
        }
    }

    internal class W3C_ReportGenerator_JsonAsObject : BaseW3CValidator, IW3CHtmlReportGenerator
    {
        public RestHelper restHelper { get; set; }

        public object CallValidatorForReport(string urlToValidate)
        {
            restHelper = new RestHelper(ValidatorUrl);
            restHelper.restRequest.AddQueryParameter("doc", urlToValidate);
            restHelper.restRequest.AddQueryParameter("out", "json");

            return restHelper.GET<Model.W3C.W3C_Html_JsonResponse>();
        }
    }

    internal class W3C_ReportGenerator_Html : BaseW3CValidator, IW3CHtmlReportGenerator
    {
        public RestHelper restHelper { get; set; }

        public object CallValidatorForReport(string urlToValidate)
        {
            restHelper = new RestHelper(ValidatorUrl);
            restHelper.restRequest.AddQueryParameter("doc", urlToValidate);
            restHelper.restRequest.AddQueryParameter("out", "html");

            return restHelper.GET().Content;
        }
    }
}
