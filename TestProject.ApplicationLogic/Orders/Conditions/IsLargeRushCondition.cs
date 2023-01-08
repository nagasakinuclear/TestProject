
using TestProject.ApplicationLogic.Orders.Conditions.Contracts;
using TestProject.Domain.Orders;

namespace TestProject.ApplicationLogic.Orders.Conditions
{
    public class IsLargeRushCondition : IOrderCondition
    {
        public bool Validate(Order order)
        {
            return order.IsLargeOrder && order.IsRushOrder;
        }
    }
}
