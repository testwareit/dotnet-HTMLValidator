using NUnit.Framework;
using dotnetHtmlValidator;

namespace dotnetHtmlValidator_Test
{
    public class W3C_HTML_Test
    {
        public string urlToTest = "https://testware.it";

        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Test1()
        {
            W3C_HTML w3C_HTML = new W3C_HTML();

            w3C_HTML.GetHtmlReport(urlToTest);
        }
    }
}