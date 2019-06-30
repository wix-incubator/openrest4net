using System;
using System.Collections.Generic;

namespace com.openrest.v2_0
{
    public class Organizations
    {
        public IList<Organization> organizations = new List<Organization>();

        /** Empty constructor required for initialization from JSON-encoded string. */
        public Organizations()
        {
        }

        public Organizations(IList<Organization> organizations)
        {
            this.organizations = organizations;
        }
    }
}
