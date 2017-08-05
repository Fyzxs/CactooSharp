using CactooSharp.Extensions;
using CactooSharp.Texts;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests.Texts
{
    [TestClass]
    public class LowerTextTests
    {
        [TestMethod]
        public void ShouldReturnUpperNullForNull()
        {
            new LowerText(null).Value().Should().Be("null");
        }

        [TestMethod]
        public void ShouldReturnAllCapsForTextObject()
        {
            new LowerText(new TextOf("Text GOES here")).Value().Should().Be("text goes here");
        }


        [TestMethod]
        public void ShouldReturnValueForToString()
        {
            new LowerText(new TextOf("Text GOES here")).ToString().Should().Be("text goes here");
        }
        [TestMethod]
        public void ShouldHaveExtensionMethodFromText()
        {
            Text text = new TextOf("Text GOES here");
            text.LowerText().Value().Should().Be("text goes here");
        }

        [TestMethod]
        public void ShouldHaveExtensionMethodFromString()
        {
            "string GOES here".LowerText().Value().Should().Be("string goes here");
        }

    }
}
