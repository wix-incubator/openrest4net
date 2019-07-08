using System;
using System.Collections.Generic;

namespace wixrest.v2_0
{
    /**
     * Information regarding a delivery destination: type, area, requirements, etc.
     * @author DL
     */
    public class DeliveryDispatchInfo : DispatchInfo
    {
        public Area area;

        public const string TYPE = Delivery.DELIVERY_TYPE_DELIVERY;

        public DeliveryDispatchInfo() : base(TYPE)
        {
        }

     
    }
}