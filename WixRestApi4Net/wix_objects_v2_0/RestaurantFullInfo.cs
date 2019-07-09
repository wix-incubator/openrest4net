using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace wixrest.v2_0
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class RestaurantFullInfo : WixRestObject
    {
        public const string TYPE = "restaurant_full";

        /** The restaurant. */
        public Restaurant restaurant;
    
        /** The menu. */
        public Menu menu;

        /** The distributor. */
        public Distributor distributor;
    
        /** The chain. */
        public Chain chain;
    
        /** The restaurant's Facebook admins. */
        public IList<String> fbAdmins = new List<string>();

        /** Empty constructor required for initialization from JSON-encoded string. */

        public RestaurantFullInfo() : base(TYPE)
        {
        }
    }
}
