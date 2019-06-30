using System;
using System.Runtime.InteropServices;

namespace com.openrest.v2_0
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IOpenrestClient
    {
        void Init(string apiUri);

        RestaurantFullInfo GetRestaurantFullInfo(string restaurantId);
        //IOrders QueryOrders(IQueryOrdersRequest request);
        //IOrder SetOrderStatus(ISetOrderStatusRequest request);
    }
}
