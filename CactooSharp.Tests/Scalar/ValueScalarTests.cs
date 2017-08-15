using CactooSharp.Scalar;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests.Scalar
{
    [TestClass]
    public class ValueScalarTests
    {
        [TestMethod]
        public void ValueShouldReturnSameReference()
        {
            object obj = new object();
            Scalar<object> scalar = new Value<object>(obj);

            scalar.AsValue().Should().Be(obj);
        }
    }
}
