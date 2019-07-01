using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


namespace wixrest.v2_0
{
    [ComVisible(true)]
    public class WixApiFaced//: IOpenrestClient
    {
        private readonly WixClient apiClient;
        private readonly WixClient authClient;
        private const string RESTAURANT_ENDPOINT = "organizations/{0}";
        private const string ACCESS_TOKEN = "com.wix/access_token";
        private const string API_URI =   "https://{0}.wixrestaurants.com/v2/";
           
        private const string RESTAURANT_FULL_ENDPOINT = RESTAURANT_ENDPOINT + "/full";
        private readonly string apiEndpoint;
        private readonly string authEndpoint;
        private readonly string _authInstance;
        private string _accessToken = null;
        private readonly string _restaurantID;

        public WixApiFaced(string restaurantID,string authInstance = null)
        {   
            apiEndpoint = string.Format(API_URI, "api");
            authEndpoint = string.Format(API_URI, "auth");
            apiClient = new WixClient(new Uri(apiEndpoint));
            authClient = new WixClient(new Uri(authEndpoint));
             _authInstance = authInstance;
             _restaurantID = restaurantID;
        }

        private async Task AuthenticateAsync(string instance)
        {
            if (string.IsNullOrEmpty(_accessToken))
            {
                var data = new
                {
                    instance
                };

                var wixAuthData = await authClient
                    .Post<WixToken>(ACCESS_TOKEN, data);
                _accessToken = wixAuthData.AccessToken;
            }
        }

        public async Task<RestaurantFullInfo> GetRestaurantFullInfo()
        {
            var endpoint = string.Format(RESTAURANT_FULL_ENDPOINT,_restaurantID);
            var restaurantFullInfo = await apiClient.Get<RestaurantFullInfo>(endpoint);
            return restaurantFullInfo;
        }

        public async Task<Restaurant> GetRestaurantInfo()
        {
            var endpoint = string.Format(RESTAURANT_ENDPOINT,_restaurantID);
            var restaurantInfo = await apiClient.Get<Restaurant>(endpoint);
            return restaurantInfo;
        }

        public async Task<Restaurant> SaveRestaurantInfo(Restaurant restaurant)
        {
            await AuthenticateAsync(_authInstance);
            var endpoint = string.Format(RESTAURANT_ENDPOINT,_restaurantID);
            var restaurantInfo = await apiClient.Put<Restaurant>(endpoint,restaurant,_accessToken);
            return restaurantInfo;
        }
    }
}
