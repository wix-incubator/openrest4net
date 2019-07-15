//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//
//namespace wixrest.v2_0
//{
//    /**
//     * The Openrest client.
//     * @author DL
//     */
//    public class OpenrestClient
//    {
//        private readonly Uri apiUri;
//        private readonly WixClient protocolClient;
//
//        public OpenrestClient(Uri apiUri)
//        {
//           
//            protocolClient = new WixClient();
//
////            // @see http://stackoverflow.com/questions/566437/http-post-returns-the-error-417-expectation-failed-c
////            System.Net.ServicePointManager.Expect100Continue = false;
//        }
//
//        public async Task <T> Post<T>(string endpoint,object request,string token = null)
//        {
//            return await protocolClient.Post<T>(new Uri(apiUri,endpoint), request,token);
//        }
//
//        public async Task <T> Put<T>(string endpoint,object request,string token = null)
//        {
//            return await protocolClient.Put<T>(new Uri(apiUri,endpoint), request,token);
//        }
//
//        public async Task<T> Get<T>(string endpoint)
//        {
//            return await protocolClient.Get<T>(new Uri(apiUri,endpoint));
//        }
//    }
//}
