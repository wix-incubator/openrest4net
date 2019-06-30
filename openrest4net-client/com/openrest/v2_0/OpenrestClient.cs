using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace com.openrest.v2_0
{
    /**
     * The Openrest client.
     * @author DL
     */
    public class OpenrestClient
    {
        private readonly Uri apiUri;
        private readonly OpenrestProtocol protocol;

        public OpenrestClient(Uri apiUri)
        {
            this.apiUri = apiUri;
            protocol = new OpenrestProtocol();

//            // @see http://stackoverflow.com/questions/566437/http-post-returns-the-error-417-expectation-failed-c
//            System.Net.ServicePointManager.Expect100Continue = false;
        }

        public async Task <T> Post<T>(Request request)
        {
            return await protocol.Post<T>(apiUri, request);
        }

        public async Task<T> Get<T>(string endpoint)
        {
            return await protocol.Get<T>(new Uri(apiUri,endpoint));
        }
    }
}
