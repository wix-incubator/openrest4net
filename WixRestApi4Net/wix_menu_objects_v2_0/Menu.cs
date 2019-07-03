using System;
using System.Collections.Generic;
using wixrest.v2_0;

namespace wixrest.v2_0
{
    public class Menu
    {
        public long modified;

        public IList<Item> items = new List<Item>();

        public IList<ChargeV2> ChargesV2 = new List<ChargeV2>();

        public IList<Section> sections = new List<Section>();

        public IList<Tag> tags = new List<Tag>();
    }
}
