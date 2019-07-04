using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WixRestApi4Net.wix_objects_v2_0;

namespace wixrest.v2_0
{
    /**
     * An extra charge or a discount associated with an order.
     * Examples: delivery charge, state tax, discount coupon.
     * 
     * @author DL
     */
    public class ChargeV2:MenuBaseObject
    {
        public int? price;
        public string state;
        [JsonProperty("operator") ]
        public Operator @operator;
    }

    public class Tip : ChargeV2
    {
        public const string TYPE = "tip";
    }
}
