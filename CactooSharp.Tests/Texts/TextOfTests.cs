﻿using CactooSharp.Extensions;
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

        [TestMethod]
        public void ShouldHaveExtensionMethodFromString()
        {
            "string GOES here".ToText().Value().Should().Be("string GOES here");
        }

        [TestMethod]
        public void ShouldHaveTextOfReturnTextOfObject()
        {
            Text text = "string GOES here".ToText().TextOf();
            text.Should().BeOfType<TextOf>();
        }
        [TestMethod]
        public void ShouldHaveTextOfBeOfProvidedValue()
        {
            "string GOES here".ToText().TextOf().Value().Should().Be("string GOES here");
        }
    }
}
