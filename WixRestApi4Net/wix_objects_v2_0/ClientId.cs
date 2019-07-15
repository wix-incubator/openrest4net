using System;

namespace wixrest.v2_0
{
    public class ClientId
    {
        public const string NS_PHONE = "tel";
        public const string NS_OPENREST = "com.openrest";
        public const string NS_FACEBOOK = "com.facebook";

        public string ns;
        public string id;
        public bool? inferred = false;

        public ClientId(string ns, string id, bool inferred)
        {
            this.ns = ns;
            this.id = id;
            this.inferred = inferred;
        }

        /** Empty constructor required for initialization from JSON-encoded string. */
        public ClientId() { }
    }
}
