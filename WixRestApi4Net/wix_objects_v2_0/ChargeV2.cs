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
        public ChargeV2(string type)
        {
            type = base.type;
        }
        public int? price;
        public string state;
        public bool? mandatory;
        [JsonProperty("operator") ]
        public Operator @operator;

        public static string TAX_TYPE;
    }

    public class Tip : ChargeV2
    {
        public Tip():base(TYPE){}
        public const string TYPE = "tip";
    }

    public class Tax : ChargeV2
    {
        public Tax():base(TYPE){}
        public const string TYPE = "tax";
    }

    public class Discount : ChargeV2
    {
        public Discount():base(TYPE){}
        public const string TYPE = "discount";
    }
}
