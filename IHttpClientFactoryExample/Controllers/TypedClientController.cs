using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IHttpClientFactoryExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TypedClientController : ControllerBase
    {
        private ITypedClient _typedClientService;
        public TypedClientController(ITypedClient typedClientService)
        {
            _typedClientService = typedClientService;
        }

        [HttpGet]
        [Route("get")]
        public async Task<string> Get()
        {
            try
            {
                return await _typedClientService.Get();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
