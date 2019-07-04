using System;
using System.Collections.Generic;
using System.Text;
using wixrest.v2_0;

namespace WixRestApi4Net.wix_objects_v2_0
{
    public class Operator:WixRestObject
    {
        public IList<Operator> operators;
        public OperatorItems items;
        public OperatorItems charges;
        public int? value;

    }

    public class Max:Operator
    {
        public const string TYPE = "max";
    }

    public class Min:Operator
    {
        public const string TYPE = "min";
    }

    public class Value:Operator
    {
        public const string TYPE = "value";
    }

    public class Include:OperatorItems
    {
        public const string TYPE = "include";
    }

    public class SumPrices:Operator
    {
        public const string TYPE = "sum_prices";
    }

    public class OperatorItems:WixRestObject
    {
        public IList<string> ids;
    }
}
