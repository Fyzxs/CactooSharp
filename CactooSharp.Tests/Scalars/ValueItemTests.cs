using CactooSharp.Scalars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests.Scalars
{
    [TestClass]
    public class ValueItemTests
    {
        [TestMethod]
        public void ValueShouldReturnSameReference()
        {
            object obj = new object();
            Scalar<object> scalar = new ValueItem<object>(obj);

            scalar.Value().Should().Be(obj);
        }
    }
}
