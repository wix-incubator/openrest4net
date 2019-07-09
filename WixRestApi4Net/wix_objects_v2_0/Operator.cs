using System;
using System.Collections.Generic;
using System.Text;
using wixrest.v2_0;

namespace WixRestApi4Net.wix_objects_v2_0
{
    public class Operator:WixRestObject
    {
        public Operator(string type_of)
        {
            type = type_of;
        }
        public IList<Operator> operators;
        public OperatorItems items;
        public OperatorItems charges;

        public int? value;

    }

    public class Max:Operator
    {
        public Max():base(TYPE){}
        public const string TYPE = "max";
    }

    public class Min:Operator
    {
        public Min():base(TYPE){}
        public const string TYPE = "min";
    }

    public class Multiply:Operator
    {
        public Multiply():base(TYPE){}
        public const string TYPE = "multiply";
        public IList<Operator> numerators;
        public IList<Operator> denominators;
    }

    public class Value:Operator
    {
        public Value():base(TYPE){}
        public const string TYPE = "value";
    }
    
    public class SumPrices:Operator
    {
        public SumPrices():base(TYPE){}
        public const string TYPE = "sum_prices";
    }

    public class CountItems:Operator
    {
        public CountItems():base(TYPE){}
        public const string TYPE = "count_items";
    }

    public class Include:OperatorItems
    {
        public Include():base(TYPE){}
        public const string TYPE = "include";
    }

    public class Exclude:OperatorItems
    {
        public Exclude():base(TYPE){}
        public const string TYPE = "exclude";
    }

    public class OperatorItems:WixRestObject
    {
        public OperatorItems(string type):base(type){}
        public IList<string> ids;
    }


}
