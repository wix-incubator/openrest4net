
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
    public class RestaurantTests
    {
        public const string REST_ID = "rest-id";
        public const string API_URI = "api-uri";
        public const string AUTH_INSTANCE = "auth-instance";

        IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile(
            "./config.json").Build();

        private readonly string _testRestId;
        //private readonly string _apiUri;
        private readonly WixApiFaced _client;


        public RestaurantTests()
        {
            _testRestId = config[REST_ID];
            _client = new WixApiFaced(config[REST_ID],config[AUTH_INSTANCE]);
        }


        [Fact]
        public async Task TestGetFullRestData()
        {
            var restaurantData = await _client.GetRestaurantFullInfo(_testRestId);
            Assert.NotNull(restaurantData);
            Assert.Equal(restaurantData.restaurant.id, _testRestId);
        }


        [Fact]
        public async Task TestGetRestData()
        {
            var restaurantData = await _client.GetRestaurantInfo(_testRestId);
            Assert.NotNull(restaurantData);
            Assert.Equal(restaurantData.id, _testRestId);
        }

        [Fact]
        public async Task TestPostRestData()
        {
            var restaurantData = await _client.GetRestaurantInfo(_testRestId);
            Assert.NotNull(restaurantData);
            Assert.Equal(restaurantData.id, _testRestId);
            var sundayTime = restaurantData.openTimes.weekly[0];
            sundayTime.durationMins++;
            sundayTime.minuteOfWeek++;
            Trace.WriteLine(JsonConvert.SerializeObject(restaurantData));
            var durationMins = sundayTime.durationMins;
            var minuteOfWeek = sundayTime.minuteOfWeek;
            await _client.SaveRestaurantInfo(restaurantData);
            restaurantData = await _client.GetRestaurantInfo(_testRestId);
            Assert.Equal(durationMins, restaurantData.openTimes.weekly[0].durationMins);
            Assert.Equal(minuteOfWeek, restaurantData.openTimes.weekly[0].minuteOfWeek);

            //restore
            sundayTime = restaurantData.openTimes.weekly[0];
            sundayTime.durationMins--;
            sundayTime.minuteOfWeek--;
            await _client.SaveRestaurantInfo(restaurantData);


        }

       
    }
}
