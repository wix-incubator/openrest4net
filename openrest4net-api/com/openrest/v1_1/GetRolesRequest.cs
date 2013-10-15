using System;
using System.Collections.Generic;

namespace com.openrest.v1_1
{
    public class GetRolesRequest : Request
    {
        public const string TYPE = "get_roles";

        public string accessToken;
        public string userId;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public GetRolesRequest()
            : base(TYPE)
        {
        }

        public GetRolesRequest(string accessToken, string userId)
            : base(TYPE)
        {
            this.accessToken = accessToken;
            this.userId = userId;
        }
    }
}
