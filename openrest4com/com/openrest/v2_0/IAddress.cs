using System;
using System.Runtime.InteropServices;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IAddress
    {
        string GetCountry();
        string GetCity();
        string GetStreet();
        string GetNumber();
        string GetApt();
        string GetFloor();
        string GetEntrance();
        string GetComment();
        ILatLng GetLatLng();
        string GetCountryCode();
        string GetPostalCode();
    }
}
