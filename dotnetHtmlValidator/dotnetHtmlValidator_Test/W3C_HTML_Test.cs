using NUnit.Framework;
using dotnetHtmlValidator;
using FluentAssertions;

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
        public void Smoke_HtmlReport()
        {
            W3C_HTML w3C_HTML = new W3C_HTML();

            var report = w3C_HTML.GetHtmlReport(urlToTest);

            report.ToString()
                .Should().Contain($"Showing results for {urlToTest}", "Verify html report returned");
        }

        [Test]
        public void Smoke_JsonReport()
        {
            W3C_HTML w3C_HTML = new W3C_HTML();

            var report = w3C_HTML.GetJsonReport(urlToTest);

            report
                .Should().Contain("\"url\":\"https://testware.it\"", " Verify json report returned");
        }

        [Test]
        public void Smoke_Report()
        {
            W3C_HTML w3C_HTML = new W3C_HTML();

            var report = w3C_HTML.GetReport(urlToTest);

            report
                .Should().NotBeNull("Verify if report returned is not null");
            report.URL
                .Should().NotBeNullOrEmpty("Verify if URL element is returned");
        }
    }
}