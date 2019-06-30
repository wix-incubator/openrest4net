
using Microsoft.Web.Administration;
using System;
using System.IO;
using System.Threading.Tasks;
using com.openrest.v2_0;
using Microsoft.Extensions.Configuration.Memory;
using Xunit;
using Microsoft.Extensions.Configuration;

namespace OpenRest4NetTests
{
    public class RestaurantTests
    {
        public const string REST_ID = "rest-id";
        public const string API_URI = "api-uri";
        IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile(
            "./config.json").Build();

        private readonly string _testRestId;
        private readonly string _apiUri;
        private readonly COpenrestClient client;


        public RestaurantTests()
        {
            _testRestId = config[REST_ID];
            _apiUri = config[API_URI];
            client = new COpenrestClient();
            client.Init(_apiUri);
        }
      

        [Fact]
        public async Task TestGetFullRestData()
        {
            var restaurantData = await client.GetRestaurantFullInfo(_testRestId);
            Assert.NotNull(restaurantData);
            Assert.Equal(restaurantData.restaurant.id,_testRestId);
        }

        
        [Fact]
        public async Task TestGetRestData()
        {
            var restaurantData = await client.GetRestaurantInfo(_testRestId);
            Assert.NotNull(restaurantData);
            Assert.Equal(restaurantData.id,_testRestId);
        }


    }
}
