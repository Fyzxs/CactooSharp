using CactooSharp.Texts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CactooSharp.Tests
{
    [TestClass]
    public class NoNullsScalarTests
    {
        [TestMethod]
        public void ShouldImplementScalar()
        {
            Text textOf = new TextOf("");
            Scalar<Text> value = new NoNullsScalar<Text>(textOf);
        }
    }
}
