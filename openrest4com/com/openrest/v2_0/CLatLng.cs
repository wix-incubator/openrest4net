using System;
using System.Runtime.InteropServices;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    public class CLatLng : ILatLng
    {
        private readonly LatLng latLng;

        public CLatLng(LatLng latLng)
        {
            this.latLng = latLng;
        }

        public double GetLat()
        {
            return latLng.lat.Value;
        }

        public double GetLng()
        {
            return latLng.lng.Value;
        }
    }
}
