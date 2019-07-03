using System;
using System.Collections.Generic;
using System.Text;
using wixrest.v2_0;

namespace WixRestApi4Net.wix_objects_v2_0
{
    public class Operator:WixRestObject
    {
        public IList<Operator> operators;
        public IList<OperatorItems> items;
        public int value;

    }

    public class OperatorItems:WixRestObject
    {
        public IList<string> ids;
    }
}
