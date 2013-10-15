using System;
using System.Collections.Generic;

namespace com.openrest.v1_1
{
    public class QueryOrdersRequest : Request
    {
        private static readonly string TYPE = "query_orders";

        public string accessToken;
        public string distributorId;
        public string chainId;
        public IList<String> restaurantIds;
        public ClientId clientId;
        public string status;
        public string source;
        public string platform;
        public long? since;
        public long? until;
        public string query;
        public string viewMode;
        public string ordering;
	    public IList<string> fields;
        public int? limit;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public QueryOrdersRequest()
            : base(TYPE)
        {
        }

        public QueryOrdersRequest(string accessToken, string distributorId, string chainId, IList<String> restaurantIds, ClientId clientId,
            string status, string source, string platform, long? since, long? until, string query, string viewMode,
            string ordering, IList<string> fields, int? limit)
            : base(TYPE)
        {
            this.accessToken = accessToken;
            this.distributorId = distributorId;
            this.chainId = chainId;
            this.restaurantIds = restaurantIds;
            this.clientId = clientId;
            this.status = status;
            this.source = source;
            this.platform = platform;
            this.since = since;
            this.until = until;
            this.query = query;
            this.viewMode = viewMode;
            this.ordering = ordering;
            this.fields = fields;
            this.limit = limit;
        }
    }
}
