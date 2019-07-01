using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixrest.v2_0;

namespace openrest4net_api.com.openrest.v2_0
{
    public class Reservations
    {
        public bool pendingApproval;
        public MinMax partySize;
        public MinMax futureDelayMins;
        public Availability availability;
        public int heldForMins;
        public IDictionary<string, string> properties = new Dictionary<string, string>();
    }

    public class MinMax
    {
        public int max;
        public int min;

    }
}
