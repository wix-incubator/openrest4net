using System;
using System.Collections.Generic;

namespace com.openrest.v2_0
{
    public class Delivery
    {
        /** Guaranteed to happen before the given timestamp. */
        public const string TIME_GUARANTEE_BEFORE = "before";
        /** Guaranteed to happen at about the given timestamp. */
        public const string TIME_GUARANTEE_APPROXIMATE = "about";

        /** Delivery to an address of your choice. */
        public const string DELIVERY_TYPE_DELIVERY = "delivery";
        /** Take-out from the restaurant. */
        public const string DELIVERY_TYPE_TAKEOUT = "takeout";

        /** All delivery methods, in ascending alphabetic order! */
        public static readonly IList<string> ALL_DELIVERY_TYPES =
            new List<string> { DELIVERY_TYPE_DELIVERY, DELIVERY_TYPE_TAKEOUT };

        public Delivery(string type, Address address, long time, string timeGuarantee, int charge)
        {
            this.type = type;
            this.address = address;
            this.time = time;
            this.timeGuarantee = timeGuarantee;
            this.charge = charge;
        }

        /** Empty constructor required for initialization from JSON-encoded string. */
        public Delivery() { }

        /** Delivery type. */
        public string type;

        /** Address to deliver to (valid only if type is DELIVERY_TYPE_DELIVERY) */
        public Address address;

        public long? time;

        public string timeGuarantee = TIME_GUARANTEE_BEFORE;

        /** The delivery charge (in "cents"). */
        public int? charge = 0;
    }
}
