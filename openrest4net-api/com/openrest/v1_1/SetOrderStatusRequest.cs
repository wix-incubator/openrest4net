using System;
using System.Collections.Generic;

namespace com.openrest.v1_1
{
    public class SetOrderStatusRequest : Request
    {
        private static readonly string TYPE = "set_order_status";

        public string accessToken;
        public string confirmationToken;
        public string orderId;
        public string status;
        public string comment;
        public IDictionary<string, string> externalIds = new Dictionary<string, string>();

        /** Empty constructor required for initialization from JSON-encoded string. */
        public SetOrderStatusRequest() : base(TYPE)
        {
        }

        public SetOrderStatusRequest(string accessToken, string confirmationToken,
            string orderId, string status, string comment, IDictionary<string, string> externalIds) : base(TYPE)
        {
            this.accessToken = accessToken;
            this.confirmationToken = confirmationToken;
            this.orderId = orderId;
            this.status = status;
            this.comment = comment;
            this.externalIds = externalIds;
        }
    }
}
