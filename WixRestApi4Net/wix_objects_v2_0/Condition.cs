using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace wixrest.v2_0
{
    public class Condition:WixRestObject
    {
        public IList<Condition> conditions;
        public Availability availability;
    }

    public class And:Condition
    {
        public const string TYPE = "and";
    }

    public class Or:Condition
    {
        public const string TYPE = "or";
    }

    public class True:Condition
    {
        public const string TYPE = "true";
    }

    public class False:Condition
    {
        public const string TYPE = "false";
    }

    public class OrderDeliveryCondition:Condition
    {
        public const string TYPE = "order_delivery_time";
    }
}