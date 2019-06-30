using System.Collections.Generic;
namespace com.openrest.v1_1
{
    public class GetAppMappedObjectRequest : Request
    {
        public const string TYPE = "get_app_mapped_object";

        public AppId appId;
        public bool? full;
        public IList<string> fields;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public GetAppMappedObjectRequest()
            : base(TYPE)
        {
        }

        public GetAppMappedObjectRequest(AppId appId, bool full, IList<string> fields)
            : base(TYPE)
        {
            this.appId = appId;
            this.full = full;
            this.fields = fields;
        }
    }
}
