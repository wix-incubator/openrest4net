﻿using System;
using System.Runtime.InteropServices;

namespace com.openrest.v1_1
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IItems
    {
        int GetCount();
        IItem Get(int i);
    }
}
