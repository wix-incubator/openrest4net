﻿using System;
using System.Runtime.InteropServices;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IChain : IOrganization
    {
        string GetDistributorId();
    }
}