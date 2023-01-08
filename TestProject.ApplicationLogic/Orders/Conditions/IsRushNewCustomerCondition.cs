
using TestProject.ApplicationLogic.Orders.Conditions.Contracts;
using TestProject.Domain.Orders;

namespace TestProject.ApplicationLogic.Orders.Conditions
{
    public class IsRushNewCustomerCondition : IOrderCondition
    {
        public bool Validate(Order order)
        {
            return order.IsRushOrder && order.IsNewCustomer;
        }
    }
}
