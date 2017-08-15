using CactooSharp.Texts;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests.Texts
{
    [TestClass]
    public class LowerTextTests
    {
        [TestMethod]
        public void ShouldReturnLowerNullForNull()
        {
            new LowerText((Text)null).Value().Should().Be("null");
        }

        [TestMethod]
        public void ShouldReturnAllLowerForTextObject()
        {
            new LowerText(new TextOf("Text GOES here")).Value().Should().Be("text goes here");
        }

        [TestMethod]
        public void ShouldReturnVLowerForToString()
        {
            new LowerText(new TextOf("Text GOES here")).ToString().Should().Be("text goes here");
        }
    }
}
