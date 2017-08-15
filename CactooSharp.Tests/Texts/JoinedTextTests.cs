using CactooSharp.Texts;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CactooSharp.Tests.Texts
{
    [TestClass]
    public class JoinedTextTests
    {
        [TestMethod]
        public void ShouldReturnSingleWord()
        {
            Text text = new JoinedText(new TextOf(""), new List<Text> { new TextOf("Foo") });
            text.Value().Should().Be("Foo");
        }

        [TestMethod]
        public void ShouldReturnTwoJoinedWords()
        {
            Text text = new JoinedText(new TextOf(" "), new List<Text> { new TextOf("Foo"), new TextOf("Bar") });
            text.Value().Should().Be("Foo Bar");
        }
        [TestMethod]
        public void ShouldHaveValueFromToString()
        {
            new JoinedText(new TextOf(" "), new List<Text> { new TextOf("string"), new TextOf("value") }).ToString().Should().Be("string value");
        }
    }
}
