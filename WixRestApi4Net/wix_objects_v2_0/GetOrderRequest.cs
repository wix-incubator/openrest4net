using System;
using System.Collections.Generic;

namespace wixrest.v2_0
{
    public class GetOrderRequest : Request
    {
        private static readonly string TYPE = "get_order";

        public string accessToken;
        public string orderId;
        public string viewMode;
        public string shareToken;
        public bool? anonymize;
        public IList<string> fields;
        public string locale;
        public Viewport viewport;
        public bool? embed;
        public bool? printConfirmation;
        public bool? printHeader;
        public bool? printCsc;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public GetOrderRequest()
            : base(TYPE)
        {
        }

        public GetOrderRequest(string accessToken, string orderId, string viewMode, string shareToken, bool anonymize,
            IList<string> fields, string locale, Viewport viewport, bool embed, bool printConfirmation, bool printHeader, bool printCsc)
            : base(TYPE)
        {
            this.accessToken = accessToken;
            this.orderId = orderId;
            this.viewMode = viewMode;
            this.shareToken = shareToken;
            this.anonymize = anonymize;
            this.fields = fields;
            this.locale = locale;
            this.viewport = viewport;
            this.embed = embed;
            this.printConfirmation = printConfirmation;
            this.printHeader = printHeader;
            this.printCsc = printCsc;
        }
    }
}
