using TestProject.ApplicationLogic.Orders.Conditions.Contracts;
using TestProject.Domain.Orders;

namespace TestProject.ApplicationLogic.Orders.Conditions
{
    internal class AlwaysPassingCondition : IOrderCondition
    {
        public bool Validate(Order order)
        {
            return true;
        }
    }
}
