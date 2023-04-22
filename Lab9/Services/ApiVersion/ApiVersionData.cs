using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http.Headers;

namespace Lab6.Services.ApiVersion
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    public class ApiVersionData : IApiVersionData
    {
        public int Get()
        {
            return 1;
        }

        public string GetV2()
        {
            return "test";
        }

        public Task<HttpResponseMessage> GetV3()
        {
            HttpResponseMessage response = null;
            var memoryStream = new MemoryStream();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sample Sheet");
                worksheet.Cell("A1").Value = "Hello World!";
                workbook.SaveAs("HelloWorld.xlsx");

                memoryStream.Seek(0, SeekOrigin.Begin);

                response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StreamContent(memoryStream);
                response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
                //response.Content.Headers.ContentDisposition.FileName = "test.xlsx";
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

                response.Content.Headers.ContentLength = memoryStream.Length;
                memoryStream.Seek(0, SeekOrigin.Begin);
            }

            return Task.FromResult(response);
        }
    }
}
