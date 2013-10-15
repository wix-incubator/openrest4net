using System;

namespace com.openrest.v1_1
{
    public class Role
    {
        public string organizationId;
        public string organizationType;
        public string role;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public Role()
        {
        }

        public Role(string organizationId, string organizationType, string role)
        {
            this.organizationId = organizationId;
            this.organizationType = organizationType;
            this.role = role;
        }
    }
}
