using System;
using System.Collections.Generic;
using wixrest.v2_0;
using WixRestApi4Net.wix_objects_v2_0;

namespace wixrest.v2_0
{
    /**
     * An item that can be ordered, e.g. a main dish ("hamburger"), a side ("fries")
    * or a dish variation ("well done").
    * @author DL
    */
    public class Item:MenuItem
    {

        public Media media;

        public int price;

        public WixText title;


        public Properties properties = new Properties();

    }
}
