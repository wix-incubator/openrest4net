using System;
using System.Collections.Generic;

namespace wixrest.v2_0
{
    public class Order
    {
        /**
         * The order has been submitted by the user, and awaits her final approval.
         * The restaurant is not made of the order.
         */
        public const string ORDER_STATUS_SUBMITTED = "submitted";
        /**
         * The restaurant required further confirmation before the order is submitted
         * (e.g. validating the user's phone number by SMS).
         */
        public const string ORDER_STATUS_PENDING = "pending";
        /** The order has been approved by the user, and awaits processing by the restaurant. */
        public const string ORDER_STATUS_NEW = "new";
        /** The order has been processed and accepted by the restaurant. */
        public const string ORDER_STATUS_ACCEPTED = "accepted";
        /** The order has been canceled. */
        public const string ORDER_STATUS_CANCELLED = "canceled";

        /** View the order as the restaurant. */
        public const string ORDER_VIEW_MODE_RESTAURANT = "restaurant";
        /** View the order as the customer. */
        public const string ORDER_VIEW_MODE_CUSTOMER = "customer";
        /** View the order as privately shared on social networks. */
        public const string ORDER_VIEW_MODE_SHARE = "share";
        /** View the order as third-party source, e.g. portal. */
        public const string ORDER_VIEW_MODE_SOURCE = "source";

        public Order(string id, IDictionary<string, string> externalIds, string restaurantId, string locale,
            IList<OrderItem> orderItems, string comment, int price, Delivery delivery, Contact contact, IList<Payment> payments,
            int takeoutPacks, IList<Charge> charges, long created, long received, long modified, long submitAt,
            User user, ClubMember clubMember, string status, string shareToken, string affiliate,
            string source, string platform, bool legacyHierarchy, IDictionary<string, string> properties, IList<LogEntry> log)
        {
            this.id = id;
            this.externalIds = externalIds;
            this.restaurantId = restaurantId;
            this.locale = locale;
            this.orderItems = orderItems;
            this.comment = comment;
            this.price = price;
            this.delivery = delivery;
            this.contact = contact;
            this.payments = payments;
            this.takeoutPacks = takeoutPacks;
            this.charges = charges;
            this.created = created;
            this.received = received;
            this.modified = modified;
            this.submitAt = submitAt;
            this.user = user;
            this.clubMember = clubMember;
            this.status = status;
            this.shareToken = shareToken;
            this.affiliate = affiliate;
            this.source = source;
            this.platform = platform;
            this.legacyHierarchy = legacyHierarchy;
            this.properties = properties;
            this.log = log;
        }

        /** Empty constructor required for initialization from JSON-encoded string. */
        public Order() { }

        /** The order's unique id. */
        public string id;

        public IDictionary<string, string> externalIds = new Dictionary<string, string>();

        /** The restaurant's unique id. */
        public string restaurantId;

        /** The order's locale. */
        public string locale;

        /** The ordered items. */
        public IList<OrderItem> orderItems = new List<OrderItem>();

        /** Comment to the restaurant (as opposed to the delivery person!). */
        public string comment;

        /** Total price of the order. */
        public int? price = 0;

        /* Delivery method. */
        public Delivery delivery;

        /* Contact details. */
        public Contact contact;

        /* Payments. */
        public IList<Payment> payments = new List<Payment>();

        /**
         * Number of "takeout packs" (e.g. cutlery and condiments) to deliver with the order.
         * For environmental reasons, clients should be encouraged to set this to 0.
         */
        public int? takeoutPacks;

        /**
	     * Extra charges or discounts associated with the order, ordered by priority
	     * in descending order.
	     */
        public IList<Charge> charges = new List<Charge>();

        /** The order's creation timestamp. */
        public long? created;

        public long? received;

        /** The order's last modification timestamp. */
        public long? modified;

        public long? submitAt;

        /** The ordering user. */
        public User user;

        /** The ordering club member. */
        public ClubMember clubMember;

        /** The order's status. */
        public string status;

        /** The order's share-token. */
        public String shareToken;

        /** Affiliate-id, for orders that came through affiliate marketing. */
        public string affiliate;

        public string source;

        public string platform;

        /**
         * Whether or not the order was submitted and should be displayed with a
         * legacy "2-level hierarchy".
         */
        public bool? legacyHierarchy = false;
    
        /** Change log for this order. */
        public IList<LogEntry> log = new List<LogEntry>();

        public IDictionary<string, string> properties = new Dictionary<string, string>();
    
        /** The order in HTML format. */
        public String html;
    }
}
