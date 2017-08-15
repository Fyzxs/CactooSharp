using CactooSharp.Texts;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests.Texts
{
    [TestClass]
    public class UpperTextTests
    {
        [TestMethod]
        public void ShouldReturnUpperNullForNull()
        {
            new UpperText(null).Value().Should().Be("NULL");
        }

        [TestMethod]
        public void ShouldReturnAllCapsForTextObject()
        {
            new UpperText(new TextOf("Text GOES here")).Value().Should().Be("TEXT GOES HERE");
        }
    }
}
