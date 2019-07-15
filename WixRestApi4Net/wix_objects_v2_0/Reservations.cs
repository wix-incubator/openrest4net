using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixrest.v2_0;
using WixRestApi4Net.wix_objects_v2_0;

namespace openrest4net_api.com.openrest.v2_0
{
    public class Reservations
    {
        public bool pendingApproval;
        public MinMax partySize;
        public MinMax futureDelayMins;
        public Availability availability;
        public int heldForMins;
        public Properties properties = new Properties();
    }

    public class MinMax
    {
        public int max;
        public int min;

    }
}
