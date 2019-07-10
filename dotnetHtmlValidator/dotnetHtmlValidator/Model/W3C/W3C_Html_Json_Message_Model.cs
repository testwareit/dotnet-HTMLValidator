using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetHtmlValidator.Model.W3C
{
    public class W3C_Html_Json_Message_Model
    {
        public string Extract { get; set; }
        public int FirstColumn { get; set; }
        public int FirstLine { get; set; }
        public int HiliteStart { get; set; }
        public int HiliteLength { get; set; }
        public int LastLine { get; set; }
        public int LastColumn { get; set; }
        public string Message { get; set; }
        public string SubType { get; set; }
        public string Type { get; set; }
    }
}
