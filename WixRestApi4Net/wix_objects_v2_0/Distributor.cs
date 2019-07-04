using System;
using System.Collections.Generic;

namespace wixrest.v2_0
{
    public class Distributor : Organization
    {
        public const string TYPE = "distributor";
        /** Empty constructor required for initialization from JSON-encoded string. */
        public Distributor() : base(TYPE) { }
    }
}
