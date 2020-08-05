using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IHttpClientFactoryExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UseHttpClientFactoryDirectController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public UseHttpClientFactoryDirectController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        [Route("get")]
        public async Task<string> Get()
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
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
