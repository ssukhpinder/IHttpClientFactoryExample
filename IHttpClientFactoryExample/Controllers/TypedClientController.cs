using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IHttpClientFactoryExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypedClientController : ControllerBase
    {
        private TypedClientService _typedClientService;
        public TypedClientController(TypedClientService typedClientService)
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
