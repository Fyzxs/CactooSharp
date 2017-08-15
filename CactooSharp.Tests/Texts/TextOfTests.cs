using CactooSharp.Texts;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests.Texts
{
    [TestClass]
    public class TextOfTests
    {
        [TestMethod]
        public void ShouldHaveTextOfString()
        {
            new TextOf("string value").Value().Should().Be("string value");
        }

        [TestMethod]
        public void ShouldHaveValueFromToString()
        {
            new TextOf("string value").ToString().Should().Be("string value");
        }
    }
}
