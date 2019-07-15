using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetHtmlValidator.Interfaces
{
    interface IReportCounter
    {
        int ErrorCount { get; set; }
        int WarningCount { get; set; }

        int GetErrorCount();
        int GetWarningCount();
    }
}
