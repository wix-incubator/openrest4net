using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IStringMap
    {
        string[] GetKeys();
        string Get(string key);
    }
}
