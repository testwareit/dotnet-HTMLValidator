﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetHtmlValidator.Model.W3C
{
    public class W3CHtml_ReportModel_Message
    {
        public string Extract { get; set; }
        public int FirstColumn { get; set; }
        public int FirstLine { get; set; }
        public int HiliteStart { get; set; }
        public int HiliteLength { get; set; }
        public int LastLine { get; set; }
        public int LastColumn { get; set; }
        public string Message { get; set; }
        public string ParsedMessage { get; set; }
        public string SubType { get; set; }
        public string Type { get; set; }
    }
}
