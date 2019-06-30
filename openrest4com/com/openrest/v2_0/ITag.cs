using System;
using System.Runtime.InteropServices;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ITag
    {
        string GetId();
        string GetRestaurantId();
        //string GetTitle();
        string[] GetItemIds();
    }
}
