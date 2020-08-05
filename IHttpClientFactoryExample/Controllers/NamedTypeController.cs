using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IHttpClientFactoryExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NamedTypeController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public NamedTypeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        [Route("get")]
        public async Task<string> Get()
        {
            try
            {
                var client = _httpClientFactory.CreateClient("namedType");
                client.BaseAddress = new Uri("https://www.google.com");
                string result = await client.GetStringAsync("/");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
