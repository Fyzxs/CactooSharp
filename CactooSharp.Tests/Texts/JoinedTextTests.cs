using CactooSharp.Extensions;
using CactooSharp.Iterable;
using CactooSharp.Texts;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests.Texts
{
    [TestClass]
    public class JoinedTextTests
    {
        [TestMethod]
        public void ShouldReturnSingleWord()
        {
            Text text = new JoinedText("".ToText(), new IterableOf<Text>("Foo".ToText()));
            text.Value().Should().Be("Foo");
        }

        [TestMethod]
        public void ShouldReturnJoinedWords2()
        {
            Text text = new JoinedText(" ".ToText(), new IterableOf<Text>("Foo".ToText(), "Bar".ToText()));
            text.Value().Should().Be("Foo Bar");
        }
        [TestMethod]
        public void ShouldHaveValueFromToString()
        {
            new JoinedText(" ".ToText(), new IterableOf<Text>("string".ToText(), "value".ToText())).ToString().Should().Be("string value");
        }
    }
}
