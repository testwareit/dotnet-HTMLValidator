using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetHtmlValidator.Model.W3C
{
    public class W3C_Html_JsonResponse : IJsonable
    {
        public string URL { get; set; }
        public List<W3C_Html_JsonResponse_Message> messages { get; set; }
    }
}
