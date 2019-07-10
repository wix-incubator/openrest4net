using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace wixrest.v2_0
{
    public class Condition:WixRestObject
    {
        public IList<Condition> conditions;
        public Availability availability = new Availability();

        public Condition(string type):base(type){}
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
        /** Web (desktop browser). */
        public const string web = "web";

        /** Mobile-web (mobile browser). */
        public const string mobileWeb = "mobileweb";

        /** Android app. */
        public const string android = "android";

        /** iOS app. */
        public const string ios = "ios";

        /** Facebook tab. */
        public const string facebook = "facebook";

        /** Call center. */
        public const string callcenter = "callcenter";

        /** Android kiosk. */
        public const string androidKiosk = "kiosk.android";

        /** iOS kiosk. */
        public const string iosKiosk = "kiosk.ios";

        /** Facebook Messenger bot. */
        public const string facebookMessenger = "com.messenger";

        /** Telegram bot. */
        public const string telegram = "org.telegram";

        /** Slack bot. */
        public const string slack = "com.slack";
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