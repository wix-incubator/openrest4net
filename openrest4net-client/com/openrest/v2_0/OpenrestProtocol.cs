using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace com.openrest.v2_0
{
    class OpenrestProtocol
    {
        private readonly RestJsonClient restJsonClient;

        public OpenrestProtocol()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.Converters.Add(new OpenrestObjectJsonConvertor());
            settings.Converters.Add(new RequestJsonConvertor());

            restJsonClient = new RestJsonClient(settings);
        }

        public async Task<T> Post<T>(Uri uri, Object obj)
        {
            try {
                return await restJsonClient.PostAsync<T>(uri, obj);
            } catch (RestJsonHttpException e) {
                throw e;
            }
        }

        public async Task<T> Get<T>(Uri uri)
        {
            try {
                return await restJsonClient.GetAsync<T>(uri);
            } catch (RestJsonHttpException e) {
                throw e;
            }
        }

        public RestJsonClient RestJsonClient
        {
            get
            {
                return restJsonClient;
            }
        }

        private static void VerifyResponse<T>(Response<T> response) {
            if (response.error != null) {
    	        throw new OpenrestException(response.error, response.errorMessage);
            }
        }
    }
}
