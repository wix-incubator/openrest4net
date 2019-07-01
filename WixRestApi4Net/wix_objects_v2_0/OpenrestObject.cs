using System;
using System.Collections.Generic;

namespace wixrest.v2_0
{
    public class OpenrestObject
    {
        public string type;

        protected OpenrestObject(string type)
        {
            this.type = type;
        }
    }
}
