using TestProject.Domain.Orders;

namespace TestProject.ApplicationLogic.Orders.Conditions.Contracts
{
    public interface IOrderCondition
    {
        bool Validate(Order order);
    }
}
