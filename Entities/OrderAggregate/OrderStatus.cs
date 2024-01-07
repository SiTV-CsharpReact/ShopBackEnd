using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBackEnd.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        Pending,
        PaymentReceived,
        PayMentFailed
    }
}