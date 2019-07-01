using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixrest.v2_0;
using Newtonsoft.Json;

namespace wixrest.v2_0
{
    public class WixToken
    { 
         [JsonProperty("user")]
         public WixUser User{ get; set; }

         [JsonProperty("accessToken")]
         public string AccessToken{ get; set; }
    }

    public class WixUser
    {
        [JsonProperty("ns")]
        public string NameSpace{ get; set; }

        [JsonProperty("id")]
        public string UserId{ get; set; }
    }
}
