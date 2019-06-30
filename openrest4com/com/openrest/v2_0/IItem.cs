using System;
using System.Runtime.InteropServices;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IItem
    {
        string GetId();
        string GetRestaurantId();
        IStringMap GetTitle();
        IStringMap GetDescription();
        int GetPrice();
        IVariations GetVariations();
        //IAvailability GetAvailability();
        bool GetInactive();
        //Status GetStatus();
        string GetPicture();
        IStringMap GetExternalIds();
    }
}
