using System;
using System.Collections.Generic;

namespace com.openrest.v1_1
{
    public class Portal : Organization
    {
        public const string TYPE = "portal";

        /** Empty constructor required for initialization from JSON-encoded string. */
        public Portal() : base(TYPE) { }
    }
}
