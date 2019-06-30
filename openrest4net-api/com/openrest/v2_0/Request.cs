using System;
using System.Collections.Generic;

namespace com.openrest.v2_0
{
    public class Request
    {
        public string type;

        protected Request(string type)
        {
            this.type = type;
        }
    }
}
