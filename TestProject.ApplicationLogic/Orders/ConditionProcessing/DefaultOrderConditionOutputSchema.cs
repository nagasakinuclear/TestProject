using System.Collections.ObjectModel;
using TestProject.ApplicationLogic.Orders.ConditionProcessing.Contracts;
using TestProject.ApplicationLogic.Orders.Conditions;
using TestProject.ApplicationLogic.Orders.Conditions.Contracts;
using TestProject.Domain.Orders;

namespace TestProject.ApplicationLogic.Orders.ConditionProcessing
{
    public class DefaultOrderConditionOutputSchema : IOrderConditionOutputSchema
    {
        private readonly ReadOnlyDictionary<IOrderCondition, OrderStatus> _conditonToResutMap = new ReadOnlyDictionary<IOrderCondition, OrderStatus>(
            new Dictionary<IOrderCondition, OrderStatus>()
        {
            { new IsLargeRepairNewCustomersCondition(), OrderStatus.Closed },
            { new IsLargeRushCondition(), OrderStatus.Closed },
            { new IsLargeRepairCondition(), OrderStatus.AuthorisationRequired },
            { new IsRushNewCustomerCondition(), OrderStatus.AuthorisationRequired },
            { new AlwaysPassingCondition(), OrderStatus.Confirmed },
        });

        public IReadOnlyDictionary<IOrderCondition, OrderStatus> ConditonToResultMap => _conditonToResutMap;
    }
}
