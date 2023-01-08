using TestProject.ApplicationLogic.Orders.Conditions.Contracts;
using TestProject.Domain.Orders;

namespace TestProject.ApplicationLogic.Orders.ConditionProcessing.Contracts
{
    public interface IOrderConditionOutputSchema
    {
        IReadOnlyDictionary<IOrderCondition, OrderStatus> ConditonToResultMap { get; }
    }
}
