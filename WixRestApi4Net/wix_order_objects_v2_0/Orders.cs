﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using openrest4net_api.com.openrest.v2_0;
using wixrest.v2_0;
using WixRestApi4Net.wix_objects_v2_0;

namespace openrest4net_api
{
    public class Orders
    {
        public Availability availability;
        public Asap asap;
        public Future future;
        public Properties properties = new Properties();
    }

    public class Future
    {
        public MinMax delayMins;
    }

    public class Asap
    {
        public bool disabled;
        public int preOrderMins;
    }
}