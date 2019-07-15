
using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
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

            Debug.WriteLine(JsonConvert.SerializeObject
                (menu,Formatting.Indented,RestJsonClient.Settings));
            menu = await _client.SaveRestaurantMenu(menu);
            
        }


        [Fact]
        public async Task TestGetRestData()
        {
            var restaurantData = await _client.GetRestaurantInfo();
            Assert.NotNull(restaurantData);
            Assert.Equal(restaurantData.id, _testRestId);
        }

       
    }
}
