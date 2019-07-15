using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetHtmlValidator.Model.W3C
{
    public class W3CHtml_ReportModel
    {
        public string URL { get; set; }
        public List<W3CHtml_ReportModel_Message> messages { get; set; }

        public W3CHtml_ReportModel(W3C_Html_JsonResponse baseModel)
        {
            this.URL = baseModel.URL;
            this.messages = new List<W3CHtml_ReportModel_Message>();

            foreach (var message in baseModel.messages)
            {
                this.messages.Add(new W3CHtml_ReportModel_Message()
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
