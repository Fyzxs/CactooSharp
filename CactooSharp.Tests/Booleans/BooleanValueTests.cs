using CactooSharp.Booleans;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests.Booleans
{
    [TestClass]
    public class BooleanValueTests
    {

        [TestMethod]
        public void ShouldReturnFalseGivenNonTrueString()
        {
            ((bool)new BooleanValue("This isn't True")).Should().BeFalse();
        }

        [TestMethod]
        public void ShouldReturnTrueGivenTrueString()
        {
            ((bool)new BooleanValue("True")).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldReturnFalseGivenFalseString()
        {
            ((bool)new BooleanValue("False")).Should().BeFalse();
        }
    }
}
