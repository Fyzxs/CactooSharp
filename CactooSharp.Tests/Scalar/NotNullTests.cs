using CactooSharp.Scalar;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CactooSharp.Tests.Scalar
{
    [TestClass]
    public class NotNullTests
    {
        [TestMethod]
        public void ValueShouldThrowExceptionGivenNullValue()
        {
            Scalar<object> scalar = new NotNull<object>(new Value<object>(null));
            Action action = () => scalar.AsValue();
            action.ShouldThrow<Exception>().WithMessage("NULL instead of valid value");
        }

        [TestMethod]
        public void ValueShouldThrowExceptionGivenNullScalar()
        {
            Scalar<object> scalar = new NotNull<object>(null);
            Action action = () => scalar.AsValue();
            action.ShouldThrow<Exception>().WithMessage("NULL instead of valid scalar");
        }

        [TestMethod]
        public void ValueShouldThrowExceptionGivenValidValue()
        {
            object actual = new object();
            Scalar<object> scalar = new NotNull<object>(actual);
            object expected = scalar.AsValue();
            expected.Should().BeSameAs(actual);

        }
    }
}
