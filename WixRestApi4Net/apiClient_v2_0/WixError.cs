using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace WixRestApi4Net.apiClient_v2_0
{
    public class WixError
    {
        public string type { get; set; }
        public string title { get; set; }
        public HttpStatusCode status { get; set; }
        public string detail { get; set; }
    }

    
    public class WebhookWixErrorObj
    {
        public WebhookWixError error { get; set; }
    }

    public class WebhookWixError
    {
        public string code { get; set; }
        public string description { get; set; }
    }

}
