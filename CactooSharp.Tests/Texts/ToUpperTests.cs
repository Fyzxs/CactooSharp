using CactooSharp.Texts;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests.Texts
{
    [TestClass]
    public class ToUpperTests
    {
        [TestMethod]
        public void ShouldReturnUpperNullForNull()
        {
            new ToUpper((string)null).Value().Should().Be("NULL");
        }

        [TestMethod]
        public void ShouldReturnAllCapsForString()
        {
            new ToUpper("String GOES here").Value().Should().Be("STRING GOES HERE");
        }

        [TestMethod]
        public void ShouldReturnAllCapsForTextObject()
        {
            new ToUpper(new TextOf("Text GOES here")).Value().Should().Be("TEXT GOES HERE");
        }
    }
}
