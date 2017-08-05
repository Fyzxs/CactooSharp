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
            Text text = new TextOf("string value");
            text.Value().Should().Be("string value");
        }
    }
}
