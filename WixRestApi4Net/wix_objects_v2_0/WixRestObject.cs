using System;
using System.Collections.Generic;

namespace wixrest.v2_0
{
    public class WixRestObject
    {
        public string type;
        public WixRestObject(){}
        
        protected WixRestObject(string type)
        {
            this.type = type;
        }
    }
}
