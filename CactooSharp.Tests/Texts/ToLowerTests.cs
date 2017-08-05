using CactooSharp.Texts;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests.Texts
{
    [TestClass]
    public class ToLowerTests
    {
        [TestMethod]
        public void ShouldReturnUpperNullForNull()
        {
            new ToLower((string)null).Value().Should().Be("null");
        }

        [TestMethod]
        public void ShouldReturnAllCapsForString()
        {
            new ToLower("string GOES here").Value().Should().Be("string goes here");
        }

        [TestMethod]
        public void ShouldReturnAllCapsForTextObject()
        {
            new ToLower(new TextOf("Text GOES here")).Value().Should().Be("text goes here");
        }
    }
}
