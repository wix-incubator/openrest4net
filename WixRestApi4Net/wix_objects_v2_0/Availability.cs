using System;
using System.Collections.Generic;

namespace wixrest.v2_0
{
    public class Availability
    {
        public Availability(IList<WeeklyTimeWindow> weekly, IList<DateTimeWindow> exceptions)
        {
            this.weekly = weekly;
            this.exceptions = exceptions;
        }

        public Availability()
        {
        }

        public IList<WeeklyTimeWindow> weekly = new List<WeeklyTimeWindow>();

        public IList<DateTimeWindow> exceptions = new List<DateTimeWindow>();
    }
}
