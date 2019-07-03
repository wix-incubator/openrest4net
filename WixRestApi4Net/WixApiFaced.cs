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
        private const string MENU_ENDPOINT =   RESTAURANT_ENDPOINT + "/menu";
        private const string RESTAURANT_FULL_ENDPOINT = RESTAURANT_ENDPOINT + "/full";

        private readonly string apiEndpoint;
        private readonly string authEndpoint;
        private string _accessToken = null;
        private readonly string _restaurantID;

        public WixApiFaced(string restaurantID, string accessToken = null)
        {
            apiEndpoint = string.Format(API_URI, "api");
            authEndpoint = string.Format(API_URI, "auth");
            apiClient = new WixClient(new Uri(apiEndpoint));
            authClient = new WixClient(new Uri(authEndpoint));
            _accessToken = accessToken;
            _restaurantID = restaurantID;
        }

        public bool IsAuthenticated()
        {
            return !string.IsNullOrEmpty(_accessToken);
        }

        public async Task<string> AuthenticateAsync(string instance)
        {
                var data = new
                {
                    instance
                };

                var wixAuthData = await authClient
                    .Post<WixToken>(ACCESS_TOKEN, data);
                _accessToken = wixAuthData.AccessToken;
                return _accessToken;
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
            var endpoint = string.Format(RESTAURANT_ENDPOINT,_restaurantID);
            var restaurantInfo = await apiClient.Put<Restaurant>(endpoint,restaurant,_accessToken);
            return restaurantInfo;
        }

        public async Task<Menu> GetRestaurantMenu()
        {
            var endpoint = string.Format(MENU_ENDPOINT,_restaurantID);
            var menu = await apiClient.Get<Menu>(endpoint);
            return menu;
        }

        public async Task<Menu> SaveRestaurantMenu(Menu menu)
        {
            var endpoint = string.Format(MENU_ENDPOINT,_restaurantID);
            menu.modified = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            menu = await apiClient.Put<Menu>(endpoint,menu,_accessToken);
            return menu;
        }
    }
}
