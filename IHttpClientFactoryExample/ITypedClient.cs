using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHttpClientFactoryExample
{
    public interface ITypedClient
    {
        Task<string> Get();
    }
}
