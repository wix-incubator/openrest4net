using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    public class CTags : ITags
    {
        public CTags(IList<Tag> tags)
        {
            cTags = new CTag[tags.Count];
            int i = 0;
            foreach (Tag tag in tags)
            {
                cTags[i++] = new CTag(tag);
            }
        }

        public int GetCount()
        {
            return cTags.Length;
        }

        public ITag Get(int i)
        {
            return cTags[i];
        }

        private CTag[] cTags;
    }
}
