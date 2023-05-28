using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using Lab6.Services.ApiVersion;
using ApiVersion = Microsoft.AspNetCore.Mvc.ApiVersion;

namespace Lab6.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    //[Authorize]
    public class ApiVersionsController : ControllerBase
    {
        private readonly IApiVersionData _apiVersion;

        public ApiVersionsController(IApiVersionData apiVersion)
        {
            _apiVersion = apiVersion;
        }

        [HttpGet]
        public int Get()
        {
            return _apiVersion.Get();
        }

        [HttpGet, MapToApiVersion("2.0")]
        public string GetV2()
        {
            return _apiVersion.GetV2();
        }

        [HttpGet, MapToApiVersion("3.0")]
        [ProducesResponseType(typeof(HttpResponseMessage), 201)]
        public Task<HttpResponseMessage> GetV3()
        {
            return _apiVersion.GetV3();
        }
    }
}
