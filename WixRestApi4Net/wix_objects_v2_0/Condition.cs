using System.Collections;
using System.Collections.Generic;

namespace wixrest.v2_0
{
    public class Condition:WixRestObject
    {
        public IList<Condition> conditions;
        public Availability availability;
    }
}