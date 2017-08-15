using CactooSharp.Scalar;
using CactooSharp.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests.Text
{
    [TestClass]
    public class TextOfTests
    {
        [TestMethod]
        public void ValueShouldReturnInputFromScalar()
        {
            Scalar<string> value = new TextOf(new Value<string>("Some Value Here"));
            value.AsValue().Should().Be("Some Value Here");
        }
        [TestMethod]
        public void ValueShouldReturnInputString()
        {
            Scalar<string> value = new TextOf("Some Value Here");
            value.AsValue().Should().Be("Some Value Here");
        }
    }

    public interface Text
    {
        string AsString();
    }

    public class SampleText : Text
    {
        private readonly Scalar<string> _value;
        public SampleText(string value) : this(new NotNull<string>(new Value<string>(value))) { }

        private SampleText(Scalar<string> value) => _value = value;

        public string AsString() => _value.AsValue();
    }
}
