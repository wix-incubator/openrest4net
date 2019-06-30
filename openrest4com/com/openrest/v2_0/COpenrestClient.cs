using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


namespace com.openrest.v2_0
{
    [ComVisible(true)]
    public class COpenrestClient//: IOpenrestClient
    {
        private OpenrestClient client;

        public void Init(string apiUri)
        {
            client = new OpenrestClient(new Uri(apiUri));
        }

        public async Task<RestaurantFullInfo> GetRestaurantFullInfo(string restaurantId)
        {
            var endpoint = $"organizations/{restaurantId}/full";
            var restaurantFullInfo = await client.Get<RestaurantFullInfo>(endpoint);
            return restaurantFullInfo;
        }

        public async Task<Restaurant> GetRestaurantInfo(string restaurantId)
        {
            var endpoint = $"organizations/{restaurantId}";
            var restaurantInfo = await client.Get<Restaurant>(endpoint);
            return restaurantInfo;
        }
    }
}
