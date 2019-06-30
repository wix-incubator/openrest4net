using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;

using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;

namespace com.openrest.v2_0
{
    /**
     * A client for a RESTful web-service that supports JSON representations.
     * @author DL
     */
    class RestJsonClient
    {
        private readonly JsonSerializerSettings settings;

        public RestJsonClient(JsonSerializerSettings settings)
        {
            this.settings = settings;
        }

        public async Task<T> GetAsync<T>(Uri uri)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                return await response.Content.ReadAsAsync<T>();
            }
        }

        public async Task<T> PostAsync<T>(Uri uri, object requestObj)
        {
            using (var client = new HttpClient())
            {
                // client.DefaultRequestHeaders.Add("token", token);
                var response = await client.PostAsJsonAsync(uri, requestObj);
                return await response.Content.ReadAsAsync<T>();
            }   
        }


    }
}
