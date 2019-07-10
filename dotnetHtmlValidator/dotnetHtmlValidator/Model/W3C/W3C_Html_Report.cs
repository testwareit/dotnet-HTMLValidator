using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetHtmlValidator.Model.W3C
{
    public class W3C_Html_Report
    {
        public string URL { get; set; }
        public List<W3C_Html_Report_Message_Model> messages { get; set; }

        public W3C_Html_Report(W3C_Html_Json_Model baseModel)
        {
            this.URL = baseModel.URL;
            this.messages = new List<W3C_Html_Report_Message_Model>();

            foreach (var message in baseModel.messages)
            {
                this.messages.Add(new W3C_Html_Report_Message_Model()
                {
                    Extract = message.Extract,
                    FirstColumn = message.FirstColumn,
                    FirstLine = message.FirstLine,
                    HiliteLength = message.HiliteLength,
                    HiliteStart = message.HiliteStart,
                    LastColumn = message.LastColumn,
                    LastLine = message.LastLine,
                    Message = message.Message,
                    ParsedMessage = ParseMessage(message.FirstLine, message.FirstColumn, message.LastLine, message.LastColumn),
                    SubType = message.SubType,
                    Type = message.Type
                });
            }
        }

        private string ParseMessage(int firstLine, int firstColumn, int lastLine, int lastColumn)
        {
            if (firstLine == 0) { firstLine = lastLine; }
            return $"From line {firstLine}, column {firstColumn}, to line {lastLine}, column {lastColumn}";
        }
    }
}
