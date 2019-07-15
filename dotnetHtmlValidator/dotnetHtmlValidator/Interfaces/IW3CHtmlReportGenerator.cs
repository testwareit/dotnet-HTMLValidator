using dotnetHtmlValidator.Helpers;
using dotnetHtmlValidator.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetHtmlValidator
{
    interface IW3CHtmlReportGenerator
    {
        RestHelper restHelper { get; set; }
        object CallValidatorForReport(string urlToValidate);
        
    }
}
