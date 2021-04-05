using Microsoft.VisualStudio.TestTools.UnitTesting;
using p27_euler;

namespace p27_euler_Tests
{
    [TestClass]
    public class SimplePrimeTests
    {
        SimplePrime sp = new SimplePrime();

        [TestMethod]
        public void ZeroAndOneAreNotPrimeNumbers()
        {
            Assert.IsFalse(sp.isPrime(0));
            Assert.IsFalse(sp.isPrime(1));
        }

        [TestMethod]
        public void NumbersUntil20()
        {
            Assert.IsTrue(sp.isPrime(2));
            Assert.IsTrue(sp.isPrime(3));

            Assert.IsFalse(sp.isPrime(4));

            Assert.IsTrue(sp.isPrime(5));

            Assert.IsFalse(sp.isPrime(6));

            Assert.IsTrue(sp.isPrime(7));

            Assert.IsFalse(sp.isPrime(8));
            Assert.IsFalse(sp.isPrime(9));
            Assert.IsFalse(sp.isPrime(10));

            Assert.IsTrue(sp.isPrime(11));

            Assert.IsFalse(sp.isPrime(12));

            Assert.IsTrue(sp.isPrime(13));

            Assert.IsFalse(sp.isPrime(14));
            Assert.IsFalse(sp.isPrime(15));
            Assert.IsFalse(sp.isPrime(16));

            Assert.IsTrue(sp.isPrime(17));

            Assert.IsFalse(sp.isPrime(18));

            Assert.IsTrue(sp.isPrime(19));

            Assert.IsFalse(sp.isPrime(20));
        }

        [TestMethod]
        public void BigPrimeNumbers()
        {
            Assert.IsTrue(sp.isPrime(7919));
            Assert.IsTrue(sp.isPrime(7333));
            Assert.IsTrue(sp.isPrime(3821));
        }

        [TestMethod]
        public void BigNonPrimeNumbers()
        {
            Assert.IsFalse(sp.isPrime(3020));
            Assert.IsFalse(sp.isPrime(3021));
            Assert.IsFalse(sp.isPrime(7777));
        }

    }
}
