using System;
using System.Runtime.InteropServices;
using com.openrest.v2_0;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    public class COpenrestObject : IOpenrestObject
    {
        private readonly OpenrestObject openrestObject;

        public COpenrestObject(OpenrestObject openrestObject)
        {
            this.openrestObject = openrestObject;
        }
    }
}
