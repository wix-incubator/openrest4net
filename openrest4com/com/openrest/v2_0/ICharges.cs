using System;
using System.Runtime.InteropServices;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ICharges
    {
        int GetCount();
        ICharge Get(int i);
    }
}
