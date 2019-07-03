
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
    public class RestaurantInfoTests:WixRestaurantsTestbase
    {
        
        [Fact]
        public async Task TestAuthentication()
        {
            await _client.AuthenticateAsync(config[AUTH_INSTANCE]);
            Assert.True(_client.HasToken());
        }

        [Fact]
        public async Task TestGetFullRestData()
        {
            var restaurantData = await _client.GetRestaurantFullInfo();
            Assert.NotNull(restaurantData);
            Assert.Equal(restaurantData.restaurant.id, _testRestId);
        }

        [Fact]
        public async Task TestGetRestData()
        {
            var restaurantData = await _client.GetRestaurantInfo();
            Assert.NotNull(restaurantData);
            Assert.Equal(restaurantData.id, _testRestId);
        }

        [Fact]
        public async Task TestPostRestData()
        {
            var restaurantData = await _client.GetRestaurantInfo();
            Assert.NotNull(restaurantData);
            Assert.Equal(restaurantData.id, _testRestId);
            var sundayTime = restaurantData.openTimes.weekly[0];
            sundayTime.durationMins++;
            sundayTime.minuteOfWeek++;
            Trace.WriteLine(JsonConvert.SerializeObject(restaurantData));
            var durationMins = sundayTime.durationMins;
            var minuteOfWeek = sundayTime.minuteOfWeek;
            await _client.SaveRestaurantInfo(restaurantData);
            restaurantData = await _client.GetRestaurantInfo();
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
