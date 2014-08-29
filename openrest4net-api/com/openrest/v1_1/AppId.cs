using System;
using Newtonsoft.Json;

namespace com.openrest.v1_1
{

    public class AppId
    {
        public AppId(string platform, string id, string version)
        {
            this.platform = platform;
            this.id = id;
            this.version = version;
        }

        /** Empty constructor required for initialization from JSON-encoded string. */
        public AppId() { }

        public string platform;
        public string id;
        public string version;
    }
}
