
using Microsoft.Web.Administration;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using wixrest.v2_0;
using Microsoft.Extensions.Configuration.Memory;
using Xunit;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace OpenRest4NetTests
{
    public class RestaurantMenuTests:WixRestaurantsTestbase
    {



        [Fact]
        public async Task TestSaveMenuData()
        {
            var menu = await _client.GetRestaurantMenu();
            Assert.NotNull(menu);
            
            menu = await _client.SaveRestaurantMenu(menu);

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
