using System;
using System.Collections.Generic;

namespace wixrest.v2_0
{
    public class Availability
    {

        public IList<WeeklyTimeWindow> weekly;

        public IList<DateTimeWindow> exceptions;
    }
}
