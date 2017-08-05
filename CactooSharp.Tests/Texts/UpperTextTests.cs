using CactooSharp.Extensions;
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

        [TestMethod]
        public void ShouldHaveExtensionMethodFromText()
        {
            Text text = new TextOf("Text GOES here");
            text.UpperText().Value().Should().Be("TEXT GOES HERE");
        }

        [TestMethod]
        public void ShouldHaveExtensionMethodFromString()
        {
            "string GOES here".UpperText().Value().Should().Be("STRING GOES HERE");
        }
    }
}
