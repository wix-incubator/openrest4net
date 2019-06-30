using System;
using System.Collections.Generic;

namespace com.openrest.v2_0
{
    public class GetOrganizationsRequest : Request
    {
        public const string TYPE = "get_organizations";

        public string distributorId;
        public string chainId;
        public IList<string> restaurantIds;
        public IList<string> organizationTypes;
        public IList<string> fields;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public GetOrganizationsRequest()
            : base(TYPE)
        {
        }

        public GetOrganizationsRequest(string distributorId, string chainId, IList<string> restaurantIds,
            IList<string> organizationTypes, IList<string> fields)
            : base(TYPE)
        {
            this.distributorId = distributorId;
            this.chainId = chainId;
            this.restaurantIds = restaurantIds;
            this.organizationTypes = organizationTypes;
            this.fields = fields;
        }
    }
}
