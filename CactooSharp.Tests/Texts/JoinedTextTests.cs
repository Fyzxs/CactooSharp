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
            Text text = new JoinedText("", new IterableOf<string>("Foo"));
            text.Value().Should().Be("Foo");
        }
        [TestMethod]
        public void ShouldReturnJoinedWords2()
        {
            Text text = new JoinedText(" ", new IterableOf<string>("Foo", "Bar"));
            text.Value().Should().Be("Foo Bar");
        }
    }

    public class JoinedText : Text
    {
        private readonly string _delimiter;
        private readonly IterableOf<string> _values;

        public JoinedText(string delimiter, IterableOf<string> values)
        {
            _delimiter = delimiter;
            _values = values;
        }

        public string Value() => string.Join(_delimiter, _values);
    }
}
