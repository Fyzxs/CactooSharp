using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests
{
    [TestClass]
    public class ScalarTests
    {
        [TestMethod]
        public void ShouldFailForNullArgument()
        {
            ((Action)(() => new NoNulls(scalar: null).Value())).ShouldThrow<ArgumentException>();
        }
    }

    public class NoNulls : Scalar<object> {
        private Scalar<object> _scalar;

        public NoNulls(Scalar<object> scalar) => _scalar = scalar;

        public object Value()
        {
            throw new ArgumentException();
        }
    }

    // ReSharper disable once InconsistentNaming
    public interface Scalar<out T> where T: class
    {
        T Value();
    }
    
}
