using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CactooSharp.Tests
{

    [TestClass]
    public class ScalarTests
    {
        [TestMethod]
        public void ShouldFailForNullArgument()
        {
            ((Action)(() => new NoNulls<object>(scalar: null).Value()))
                .ShouldThrow<ArgumentException>()
                .WithMessage("NULL instead of a valid scalar");
        }

        [TestMethod]
        public void ShouldFailForNullValue()
        {
            Mock<Scalar<object>> mock = new Mock<Scalar<object>>();
            ((Action)(() => new NoNulls<object>(scalar: mock.Object).Value()))
                .ShouldThrow<ArgumentException>()
                .WithMessage("NULL instead of a valid value");
        }

        [TestMethod]
        public void ShouldBeOkForNoNulls()
        {
            object obj = new object();
            Mock<Scalar<object>> mock = new Mock<Scalar<object>>();
            mock.Setup(x => x.Value()).Returns(obj);
            new NoNulls<object>(scalar: mock.Object).Value().Should().BeSameAs(obj);
        }
    }

    //Understands checking a scalar for null
    public class NoNulls<T> : Scalar<T> where T : class
    {
        private readonly Scalar<T> _origin;

        public NoNulls(Scalar<T> scalar) => _origin = scalar;

        public T Value()
        {
            if (_origin == null) throw new ArgumentException("NULL instead of a valid scalar");

            T value = _origin.Value();
            if (value == null) throw new ArgumentException("NULL instead of a valid value");

            return value;
        }
    }

    //Understands getting a value from an object
    public interface Scalar<out T> where T : class
    {
        T Value();
    }
}
