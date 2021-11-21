using System;
using System.Linq.Expressions;
using Core.Entities.OrderAggregate;

namespace Core.Specifications
{
    public class OrdersWithAndOrderingSpecification : BaseSpecification<Order>
    {
        public OrdersWithAndOrderingSpecification(string email) : base(o => o.BuyerEmail ==
        email)
        {
            AddInclude(o => o.OrderItems);
            AddInclude(o => o.DeliveryMethod);
            AddOrderByDescending(o => o.OrderItems);
        }

        public OrdersWithAndOrderingSpecification(int id, string email) 
            : base(o => o.Id == id && o.BuyerEmail == email)

        {
            AddInclude(o => o.OrderItems);
            AddInclude(o => o.DeliveryMethod);
        }
    }
}