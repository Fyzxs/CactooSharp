using CactooSharp.Booleans;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CactooSharp.Tests.Booleans
{
    [TestClass]
    public class IsNullTests
    {
        [TestMethod]
        public void ShouldReturnTrueForNullArgument()
        {
            ((bool)new IsNull<object>(null)).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldReturnTrueForNullValue()
        {
            ((bool)new IsNull<object>(new Mock<Scalar<object>>().Object)).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldReturnFalseForValue()
        {
            Mock<Scalar<object>> mock = new Mock<Scalar<object>>();
            mock.Setup(x => x.Value()).Returns(new object());
            ((bool)new IsNull<object>(mock.Object)).Should().BeFalse();
        }
    }
}
