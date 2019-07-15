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

      

        public PickupDispatchInfo() : base(TYPE)
        {
        }

        public const string TYPE = Delivery.DELIVERY_TYPE_TAKEOUT;
    }
}