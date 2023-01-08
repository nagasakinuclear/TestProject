using TestProject.Domain.Orders;

namespace TestProject.ApplicationLogic.Orders.ConditionProcessing.Contracts
{
    public interface IOrderConditionProcessor
    {
        OrderStatus GetOrderStatus(Order order);
    }
}