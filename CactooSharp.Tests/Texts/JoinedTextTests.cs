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
            Text text = new JoinedText("", "Foo");
            text.Value().Should().Be("Foo");
        }

        [TestMethod]
        public void ShouldReturnJoinedWords()
        {
            Text text = new JoinedText(" ", "Foo", "Bar");
            text.Value().Should().Be("Foo Bar");
        }
    }

    public class JoinedText : Text
    {
        private readonly string _delimiter;
        private readonly string[] _values;


        public JoinedText(string delimiter, params string[] values)
        {
            _delimiter = delimiter;
            _values = values;
        }

        public string Value()
        {
            return string.Join(_delimiter, _values);
        }
    }
}
