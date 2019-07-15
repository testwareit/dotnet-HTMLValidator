using dotnetHtmlValidator.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetHtmlValidator
{
    public class W3C_Html_Validator
    {
        public string GenerateJsonReport(string urlToValidate)
        {
            W3C_Html_Validator_Helper w3C_Html_Validator_Helper = new W3C_Html_Validator_Helper();
            return w3C_Html_Validator_Helper.GenerateReportByType(new W3C_ReportGenerator_Json(), urlToValidate).ToString();
        }

        public Model.W3C.W3C_Html_JsonResponse GenerateJsonAsObjectReport(string urlToValidate)
        {
            W3C_Html_Validator_Helper w3C_Html_Validator_Helper = new W3C_Html_Validator_Helper();
            return w3C_Html_Validator_Helper.GenerateReportByType(new W3C_ReportGenerator_JsonAsObject(), urlToValidate) as Model.W3C.W3C_Html_JsonResponse;
        }

        public string GenerateHtmlReport(string urlToValidate)
        {
            W3C_Html_Validator_Helper w3C_Html_Validator_Helper = new W3C_Html_Validator_Helper();
            return w3C_Html_Validator_Helper.GenerateReportByType(new W3C_ReportGenerator_Html(), urlToValidate).ToString();
        }
    }
}
