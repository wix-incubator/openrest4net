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
     */
    public abstract class ChargeV2:MenuBaseObject,IWixTypeObject
    {
        public const string OPERATIONAL_STATE = "operational"; 
        public const string DELETED_STATE = "closed"; 
        public ChargeV2(string typeOf)
        {
            type = typeOf;
            state = OPERATIONAL_STATE;
        }
        public int? price;
        public string state;
        public bool? mandatory;
        [JsonProperty("operator") ]
        public Operator @operator;

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

    public class CloseDiscount : Discount
    {
        public CloseDiscount(ChargeV2 dis)
        {
            id = dis.id;
            title = dis.title;
            description = dis.description;
            state = DELETED_STATE;
            displayCondition = new False();
            condition = new False();
            @operator = new Value(){value = 0};
        }
    }
}
