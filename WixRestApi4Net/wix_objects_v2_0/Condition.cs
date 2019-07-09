using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace wixrest.v2_0
{
    public class Condition:WixRestObject
    {
        public IList<Condition> conditions;
        public Availability availability;

        public Condition(string typeOf)
        {
            type = typeOf;
        }
    }

    public class And:Condition
    {
        public And():base(TYPE){}
        public const string TYPE = "and";
    }

    public class Or:Condition
    {
        public Or():base(TYPE){}
        public const string TYPE = "or";
    }

    public class True:Condition
    {
        public True():base(TYPE){}
        public const string TYPE = "true";
    }

    public class False:Condition
    {
        public False():base(TYPE){}
        public const string TYPE = "false";
    }

    public class OrderDeliveryTimeCondition:Condition
    {
        public OrderDeliveryTimeCondition():base(TYPE){}
        public const string TYPE = "order_delivery_time";
    }

    public class OrderPlatform:Condition
    {
        public OrderPlatform():base(TYPE){}
        public const string TYPE = "order_platform";
        public string platform;
    }

    public class OrderItemsPrice:Condition
    {
        public OrderItemsPrice():base(TYPE){}
        public const string TYPE = "order_items_price";
        public int? min;
    }

    public class OrderDeliveryTypeCondition:Condition
    {
        public OrderDeliveryTypeCondition():base(TYPE){}
        public const string TYPE = "order_delivery_type";
        public string deliveryType;
    }
}