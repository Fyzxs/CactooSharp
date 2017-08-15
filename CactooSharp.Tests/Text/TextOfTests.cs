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
}
