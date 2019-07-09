using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Formatters;
using WixRestApi4Net.wix_objects_v2_0;

namespace wixrest.v2_0
{
    public class RestaurantObjectJsonConvertor : JsonConverter
    {
        private JsonSerializerSettings _settings;

        public RestaurantObjectJsonConvertor(JsonSerializerSettings settings)
        {
            _settings = settings;
        }

        private const string TYPE_PROPERTY = "type";

        public override bool CanConvert(Type objectType)
        {
            return typeof(WixRestObject).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType,
                object existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);

            Type targetType = GetType(jObject);
            object target = Activator.CreateInstance(targetType);

            serializer.Populate(jObject.CreateReader(), target);

            return target;
        }

        public override void WriteJson(JsonWriter writer, Object value, JsonSerializer serializer)
        {
            JsonSerializer.Create(_settings).Serialize(writer, value);
        }

        private static Type GetType(JObject jObject)
        {
            string typeStr = (string) jObject.Property(TYPE_PROPERTY);
            if (typeStr == null)
            {
                throw new ApplicationException("Missing type property");
            }

            switch (typeStr)
            {
                case Restaurant.TYPE:
                    return typeof(Restaurant);
                case Chain.TYPE:
                    return typeof(Chain);
                case Portal.TYPE:
                    return typeof(Portal);
                case Distributor.TYPE:
                    return typeof(Distributor);
                case RestaurantFullInfo.TYPE:
                    return typeof(RestaurantFullInfo);
                case DeliveryDispatchInfo.TYPE:
                    return typeof(DeliveryDispatchInfo);
                case PickupDispatchInfo.TYPE:
                    return typeof(PickupDispatchInfo);
                case And.TYPE:
                    return typeof(And);
                case Or.TYPE:
                    return typeof(Or);
                case True.TYPE:
                    return typeof(True);
                case False.TYPE:
                    return typeof(False);
                case OrderDeliveryTimeCondition.TYPE:
                    return typeof(OrderDeliveryTimeCondition);
                case OrderDeliveryTypeCondition.TYPE:
                    return typeof(OrderDeliveryTypeCondition);
                case OrderPlatform.TYPE:
                    return typeof(OrderPlatform);
                case Max.TYPE:
                    return typeof(Max);
                case Min.TYPE:
                    return typeof(Min);
                case SumPrices.TYPE:
                    return typeof(SumPrices);
                case Include.TYPE:
                    return typeof(Include);
                case Value.TYPE:
                    return typeof(Value);
                case Tip.TYPE:
                    return typeof(Tip);
                case OrderItemsPrice.TYPE:
                    return typeof(OrderItemsPrice);
                case Multiply.TYPE:
                    return typeof(Multiply);
                case Exclude.TYPE:
                    return typeof(Exclude);
                case CountItems.TYPE:
                    return typeof(CountItems);

            }

            throw new ApplicationException(String.Format("Unknown object type: {0}", typeStr));
        }
    }
}
