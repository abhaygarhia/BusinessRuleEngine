using BusinessRuleEngine.Interfaces;
using BusinessRuleEngine.Rules;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace BusinessRuleEngine.Test
{
    public class OrderProcessorTest
    {
        [Fact]
        public void TestProcessOrder_ShouldPass()
        {
            // Arrange
            var orderProcessor = new Mock<IOrderProcessor>();
            var listOfRules = new List<IRule> { new Book() };

            orderProcessor.Setup(x => x.ProcessOrder(It.IsAny<List<IRule>>())).Callback<List<IRule>>((rulesList) =>
            {
                Assert.Equal(listOfRules, rulesList);
            });
            orderProcessor.Setup(type => type.SendMail(It.IsAny<Type>())).Callback<Type>((type) =>
            {
                Assert.Equal(typeof(Book), listOfRules[0].GetType());
            });

            // Act
            orderProcessor.Object.ProcessOrder(listOfRules);

            // Assert
            orderProcessor.Verify();
        }

        [Theory]
        [InlineData(typeof(PhysicalProduct))]
        [InlineData(typeof(Book))]
        [InlineData(typeof(MemberShip))]
        public void TestSendMail_ShouldFail(Type type)
        {
            // Arrange
            var orderProcessor = new Mock<IOrderProcessor>();
            
            orderProcessor.Setup(x => x.SendMail(type)).Callback<Type>((typ) =>
            {
                Assert.IsNotType<UpgradeMemberShip>(type);
            });

            // Act
            orderProcessor.Object.SendMail(type);

            // Assert
            orderProcessor.Verify();
        }
    }
}
