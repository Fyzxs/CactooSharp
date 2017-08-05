using CactooSharp.Iterable;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CactooSharp.Tests.Iterable
{
    [TestClass]
    public class IterableOfTests
    {
        [TestMethod]
        public void ShouldConvertScalarsToIterable()
        {
            IEnumerable<string> itr = new IterableOf<string>("a", "B");
            using (IEnumerator<string> enumerator = itr.GetEnumerator())
            {
                enumerator.MoveNext();
                enumerator.Current.Should().Be("a");
                enumerator.MoveNext();
                enumerator.Current.Should().Be("B");
                enumerator.MoveNext().Should().BeFalse();
            }
        }
    }
}