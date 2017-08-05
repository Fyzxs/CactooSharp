using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;

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
            new Mock<Scalar>
                    ((Action)(() => new NoNulls<object>(scalar: ).Value()))
                .ShouldThrow<ArgumentException>();
        }

        public class NoNulls<T> : Scalar<T> where T : class
        {
            private Scalar<T> _origin;

            public NoNulls(Scalar<T> scalar) => _origin = scalar;

            public T Value()
            {
                throw new ArgumentException("NULL instead of a valid scalar");
            }
        }

        // ReSharper disable once InconsistentNaming
        public interface Scalar<out T> where T : class
        {
            T Value();
        }
    }
}
