using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IHttpClientFactoryExample
{
    public class TypedClientService : ITypedClient
    {
        private HttpClient _httpClient;
        public TypedClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> Get()
        {
            var url= new Uri("https://www.google.com");
            var response= await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
