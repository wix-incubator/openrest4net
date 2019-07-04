using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;

using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Threading;
using Newtonsoft.Json.Serialization;

namespace wixrest.v2_0
{
    /**
     * A client for a RESTful web-service that supports JSON representations.
     * @author DL
     */
    public class RestJsonClient
    {

        static RestJsonClient()
        {
            var settings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            Settings = new JsonSerializerSettings()
            {
                Converters = new List<JsonConverter>()
                {
                    new RestaurantObjectJsonConvertor(settings),
                    new RequestJsonConvertor(settings)
                },
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        public static readonly JsonSerializerSettings Settings;
        
        public readonly JsonMediaTypeFormatter Formatter = new JsonMediaTypeFormatter()
        {
            SerializerSettings = Settings
        };

        public async Task<HttpResponseMessage> GetAsync<T>(Uri uri)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                return response;
            }
        }

        public async Task<HttpResponseMessage> PostAsync<T>(Uri uri,string token,object requestObj)
        {
   
            using (var client = new HttpClient())
            {
                if (!string.IsNullOrEmpty(token))
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                }

                var response = await client.PostAsync(uri, requestObj,Formatter);
                return response;
            }   
        }

        public async Task<HttpResponseMessage> PutAsync<T>(Uri uri, string token, object requestObj)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var response = await client.PutAsync(uri, requestObj,Formatter);
                return response;
            }   
        }
    }
}
