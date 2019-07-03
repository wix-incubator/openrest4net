using System;
using System.Collections.Generic;
using WixRestApi4Net.wix_objects_v2_0;

namespace wixrest.v2_0
{
    /**
     * An extra charge or a discount associated with an order.
     * Examples: delivery charge, state tax, discount coupon.
     * 
     * @author DL
     */
    public class ChargeV2:MenuItem
    {
        private int price;
        private string state;
        private Operator @operator;
    }
}
