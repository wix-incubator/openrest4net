using System;
using System.Collections.Generic;
using WixRestApi4Net.wix_objects_v2_0;

namespace wixrest.v2_0
{
    public class Section:MenuItem
    {


        /** The item-ids in this category. */
        public IList<string> itemIds = new List<string>();

        public IList<Section> children = new List<Section>();

        /** Order priority. Higher means first in the list. */
        public double? priority = 0.0;

        public Media media;

        public Properties properties;
    }
}
