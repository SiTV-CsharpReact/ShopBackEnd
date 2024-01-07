using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopBackEnd.Entities.OrderAggregate;

namespace ShopBackEnd.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string BuyerId {get; set;}
        public ShippingAddress ShippingAddress{get;set;}
        public DateTime OrderDate {get;set;} = DateTime.Now;
        public List<OrderItem> OrderItems { get; set; }
        public long Subtotal { get; set; }
        public long DeliveryFee { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public long GetTotal(){
            return Subtotal + DeliveryFee;
        }
    }
}