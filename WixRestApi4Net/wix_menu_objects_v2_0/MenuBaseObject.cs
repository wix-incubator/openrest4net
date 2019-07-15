using WixRestApi4Net.wix_objects_v2_0;

namespace wixrest.v2_0
{
    public class MenuBaseObject
    {
        public string id;
        public string type;
        public WixText title;
        public WixText description;
        public Condition displayCondition;
        public Condition condition;

    }
}