using Microsoft.VisualStudio.TestTools.UnitTesting;
using p27_euler;

namespace p27_euler_Tests
{
    [TestClass]
    public class QuadraticPrimeCounterTests
    {
        QuadraticPrimeCounter qpc = new QuadraticPrimeCounter();

        [TestMethod]
        public void a_1_b_41_gives_40_primes()
        {
            Assert.AreEqual(40, qpc.countConsecutivePrimes(1, 41));
        }

        [TestMethod]
        public void a_m79_b_1601_gives_80_primes()
        {
            Assert.AreEqual(80, qpc.countConsecutivePrimes(-79, 1601));
        }


    }
}
