using System;
using System.Runtime.InteropServices;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IVariation
    {
        //string GetTitle();
        string TagId();
        int GetMinNumAllowed();
        int GetMaxNumAllowed();
        int GetPrice(string itemId);
        string[] GetDefaults();
        string GetDisplayType();
    }
}
