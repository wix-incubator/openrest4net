using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using wixrest.v2_0;

namespace wixrest.v2_0
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Menu
    {
        public long modified;

        public IList<MenuItem> items;

        public IList<ChargeV2> chargesV2;

        public IList<Section> sections;

        public IList<Tag> tags;
    }
}
