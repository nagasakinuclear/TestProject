using Xunit;
using TestProject.ApplicationLogic.Orders.ConditionProcessing.Contracts;
using TestProject.Domain.Orders;
using TestProject.ApplicationLogic.Orders.ConditionProcessing;

namespace TestProject.UnitTests.ApplicationLogic.Orders.ConditionProcessing
{
    public class OrderConditionProcessorTests
    {
        private readonly IOrderConditionProcessor _orderConditionProcessor;

        public OrderConditionProcessorTests()
        {
            _orderConditionProcessor = new OrderConditionProcessor(new DefaultOrderConditionOutputSchema());
        }

        [Fact]
        public void TestGetOrderStatus_IsLargeRepairNewCustomersCondition()
        {
            // Arrange
            var order = new Order
            {
                IsNewCustomer = true,
                IsLargeOrder = true,
                OrderType = OrderType.Repair
            };

            // Act
            var result = _orderConditionProcessor.GetOrderStatus(order);

            // Assert
            Assert.Equal(OrderStatus.Closed, result);
        }

        [Fact]
        public void TestGetOrderStatus_IsLargeRushCondition()
        {
            // Arrange
            var order = new Order
            {
                IsRushOrder = true,
                IsLargeOrder = true,
            };

            // Act
            var result = _orderConditionProcessor.GetOrderStatus(order);

            // Assert
            Assert.Equal(OrderStatus.Closed, result);
        }

        [Fact]
        public void TestGetOrderStatus_IsLargeRepairCondition()
        {
            // Arrange
            var order = new Order
            {
                IsLargeOrder = true,
                OrderType = OrderType.Repair
            };

            // Act
            var result = _orderConditionProcessor.GetOrderStatus(order);

            // Assert
            Assert.Equal(OrderStatus.AuthorisationRequired, result);
        }

        [Fact]
        public void TestGetOrderStatus_IsRushNewCustomerCondition()
        {
            // Arrange
            var order = new Order
            {
                IsNewCustomer = true,
                IsRushOrder = true
            };

            // Act
            var result = _orderConditionProcessor.GetOrderStatus(order);

            // Assert
            Assert.Equal(OrderStatus.AuthorisationRequired, result);
        }

        [Fact]
        public void TestGetOrderStatus_AlwaysPassingCondition()
        {
            // Arrange
            var order = new Order();

            // Act
            var result = _orderConditionProcessor.GetOrderStatus(order);

            // Assert
            Assert.Equal(OrderStatus.Confirmed, result);
        }
    }
}