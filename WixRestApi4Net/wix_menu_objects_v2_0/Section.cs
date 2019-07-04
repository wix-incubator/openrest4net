using System;
using System.Collections.Generic;
using WixRestApi4Net.wix_objects_v2_0;

namespace wixrest.v2_0
{
    public class Section:MenuBaseObject
    {


        /** The item-ids in this category. */
        public IList<string> itemIds;

        public IList<Section> children;

        /** Order priority. Higher means first in the list. */
        public double? priority;

        public Media media;

        public Properties properties;
    }
}
