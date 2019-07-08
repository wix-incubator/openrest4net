using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WixRestApi4Net.wix_objects_v2_0
{

    /*
     this object is used to save the different text names by culture key. e.g:
     {
        en_US: "name of item",
        he_IL: "שם המנה"
         ....
     }
    */
    public class WixText:Dictionary<string,string>
    {
        public override string ToString()
        {
            return Values.FirstOrDefault() ?? "Empty";
        }
    }

 
}
