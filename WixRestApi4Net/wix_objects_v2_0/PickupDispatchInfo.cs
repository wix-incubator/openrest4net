using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace wixrest.v2_0
{
    /**
     * Information regarding a delivery destination: type, area, requirements, etc.
     * @author DL
     */
    public class PickupDispatchInfo:DispatchInfo
    {

        /** Optional delivery area (for type = Delivery.DELIVERY_TYPE_DELIVERY). */
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Availability availability;
    
        /** The minimum allowed order price (in "cents"). */
        public int? minOrderPrice = 0;
    
        /** The delivery charge (in "cents"). */
        public int? charge = 0;
    
        /** Delivery time (maximum number of minutes till order arrives). */
        public int? delayMins = 0;

        /** Whether the delivery destination is deactivated (i.e. suspended or disabled). */
        public bool? inactive = false;

        public PickupDispatchInfo() : base(TYPE)
        {
        }

        public const string TYPE = Delivery.DELIVERY_TYPE_TAKEOUT;
    }
}