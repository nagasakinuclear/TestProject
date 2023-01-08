using TestProject.ApplicationLogic.Orders.ConditionProcessing.Contracts;
using TestProject.Domain.Orders;

namespace TestProject.ApplicationLogic.Orders.ConditionProcessing
{
    public class OrderConditionProcessor : IOrderConditionProcessor
    {
        private readonly IOrderConditionOutputSchema _orderConditionOutputSchema;

        public OrderConditionProcessor(IOrderConditionOutputSchema orderConditionOutputSchema)
        {
            _orderConditionOutputSchema = orderConditionOutputSchema;

            if (orderConditionOutputSchema == null)
            {
                _orderConditionOutputSchema = new DefaultOrderConditionOutputSchema();
            }
        }

        public OrderStatus GetOrderStatus(Order order)
        {
            return _orderConditionOutputSchema
                .ConditonToResultMap
                .First(conditon => conditon.Key.Validate(order)).Value;
        }
    }
}
