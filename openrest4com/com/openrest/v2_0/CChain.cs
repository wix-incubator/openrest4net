using System;
using System.Runtime.InteropServices;
using com.openrest.v2_0;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    public class CChain : COrganization, IChain
    {
        private readonly Chain chain;

        public CChain(Chain chain) : base(chain)
        {
            this.chain = chain;
        }

        public string GetDistributorId()
        {
            return chain.distributorId;
        }
    }
}
