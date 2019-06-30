using System;
using System.Runtime.InteropServices;
using com.openrest.v2_0;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    public class CDistributor : COrganization, IDistributor
    {
        private readonly Distributor distributor;

        public CDistributor(Distributor distributor)
            : base(distributor)
        {
            this.distributor = distributor;
        }
    }
}
