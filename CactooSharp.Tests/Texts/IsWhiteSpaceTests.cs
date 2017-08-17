using CactooSharp.Texts;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests.Texts
{
    [TestClass]
    public class IsWhiteSpaceTests
    {
        [TestMethod]
        public void ShouldBeFalseGivenNonBlank()
        {
            Scalar<bool> isBlank = new IsWhiteSpace(new TextOf("a"));
            isBlank.Value().Should().BeFalse();
        }

        [TestMethod]
        public void ShouldBeTrueGivenEmptyString()
        {
            Scalar<bool> isBlank = new IsWhiteSpace(new TextOf(""));
            isBlank.Value().Should().BeTrue();
        }

        [TestMethod]
        public void ShouldBeTrueGivenWhiteSpace()
        {
            Scalar<bool> isBlank = new IsWhiteSpace(new TextOf(" \t\r\n"));
            isBlank.Value().Should().BeTrue();
        }
    }
}
