using Microsoft.AspNetCore.Mvc;

namespace Lab6.Services.ApiVersion
{
    public interface IApiVersionData
    {
        int Get();
        string GetV2();
        Task<HttpResponseMessage> GetV3();
    }
}
