using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace dotnetHtmlValidator.Helpers
{
    public abstract class BaseW3CValidator: BaseValidator
    {
        public BaseW3CValidator()
        {
            var manager = ConfigurationManager.OpenExeConfiguration(this.GetType().Assembly.Location);
            ValidatorUrl = manager.AppSettings.Settings["w3c_URL"].Value;
        }
    }
}
