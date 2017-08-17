using CactooSharp.Texts;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace CactooSharp.Tests.Texts
{
    [TestClass]
    public class TextOfTests
    {
        [TestMethod]
        public void ShouldReturnInputFromScalar()
        {
            Text value = new TextOf("Some ValueItem Here");
            value.AsString().Should().Be("Some ValueItem Here");
        }

        [TestMethod]
        public void ShouldReturnInputFromString()
        {
            Text value = new TextOf("Some ValueItem Here");
            value.AsString().Should().Be("Some ValueItem Here");
        }

        [TestMethod]
        public void ShouldReturnInputFromText()
        {
            Text value = new TextOf(new DelayedText(() => "Some ValueItem Here"));
            value.AsString().Should().Be("Some ValueItem Here");
        }

        [TestMethod]
        public void ShouldReturnStringOfBytes()
        {
            Text value = new TextOf(Encoding.ASCII.GetBytes("Some ValueItem Here"));
            value.AsString().Should().Be("Some ValueItem Here");
        }


    }
}
