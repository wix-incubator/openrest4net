﻿using System;
using System.Runtime.InteropServices;

namespace com.openrest.v1_1
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IUser
    {
        string GetId();
        string GetIpAddress();
        string GetFwdIpAddresses();
    }
}
