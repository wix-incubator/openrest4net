using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using wixrest.v2_0;

namespace wixrest.v2_0
{
    /**
     * Information regarding a delivery destination: type, area, requirements, etc.
     * @author DL
     */

    
    public abstract class DispatchInfo : OpenrestObject
    {
        protected DispatchInfo(string type) : base(type)
        {
        }

        /** Optional delivery area (for type = Delivery.DELIVERY_TYPE_DELIVERY). */
        public Availability availability;
    
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        /** The minimum allowed order price (in "cents"). */
        public int? minOrderPrice = 0;
    
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        /** The delivery charge (in "cents"). */
        public int? charge = 0;
    
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        /** Delivery time (maximum number of minutes till order arrives). */
        public int? delayMins = 0;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        /** Whether the delivery destination is deactivated (i.e. suspended or disabled). */
        public bool? inactive = false;

        public IDictionary<string, string> properties = new Dictionary<string, string>();
    }
}