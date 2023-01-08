
using TestProject.ApplicationLogic.Orders.Conditions.Contracts;
using TestProject.Domain.Orders;

namespace TestProject.ApplicationLogic.Orders.Conditions
{
    public class IsLargeRepairNewCustomersCondition : IOrderCondition
    {
        public bool Validate(Order order)
        {
            return order.IsLargeOrder && order.OrderType == OrderType.Repair && order.IsNewCustomer;
        }
    }
}
