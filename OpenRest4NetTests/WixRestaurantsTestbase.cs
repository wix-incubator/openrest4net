
using Microsoft.Web.Administration;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using wixrest.v2_0;
using Microsoft.Extensions.Configuration.Memory;
using Xunit;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace OpenRest4NetTests
{
    public class WixRestaurantsTestbase
    {
        public const string REST_ID = "rest-id";
        public const string API_URI = "api-uri";
        public const string AUTH_INSTANCE = "auth-instance";
        public const string ACCESS_TOKEN = "access-token";

        protected IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile(
            "./config.json").Build();

        protected readonly string _testRestId;
        //private readonly string _apiUri;
        protected readonly WixApiFaced _client;

        public WixRestaurantsTestbase()
        {
            _testRestId = config[REST_ID];
            _client = new WixApiFaced(config[REST_ID],config[ACCESS_TOKEN]);
        }


       
       
    }
}
