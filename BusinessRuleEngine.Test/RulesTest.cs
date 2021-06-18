using BusinessRuleEngine.Rules;
using Moq;
using Xunit;

namespace BusinessRuleEngine.Test
{
    public class RulesTest
    {
        [Fact]
        public void Book_ProcessRule_ShouldPass()
        {
            // Arrange
            var rule = new Mock<Book>();

            // Act
            rule.Object.ProcessRule();

            // Assert
            rule.Verify();
        }

        [Fact]
        public void PhysicalProduct_ProcessRule_ShouldPass()
        {
            // Arrange
            var rule = new Mock<PhysicalProduct>();

            // Act
            rule.Object.ProcessRule();

            // Assert
            rule.Verify();
        }

        [Fact]
        public void MemberShip_ProcessRule_ShouldPass()
        {
            // Arrange
            var rule = new Mock<MemberShip>();

            // Act
            rule.Object.ProcessRule();

            // Assert
            rule.Verify();
        }

        [Fact]
        public void UpgradeMemberShip_ProcessRule_ShouldPass()
        {
            // Arrange
            var rule = new Mock<UpgradeMemberShip>();

            // Act
            rule.Object.ProcessRule();

            // Assert
            rule.Verify();
        }

        [Fact]
        public void Video_ProcessRule_ShouldPass()
        {
            // Arrange
            var rule = new Mock<Video>("Learning to Ski");

            // Act
            rule.Object.ProcessRule();

            // Assert
            rule.Verify();
        }
    }
}
