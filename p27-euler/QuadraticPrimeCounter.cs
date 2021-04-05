using System;
using System.Collections.Generic;
using System.Text;

namespace p27_euler
{
    public class QuadraticPrimeCounter
    {
        private SimplePrime sp = new SimplePrime();

        public long countConsecutivePrimes(int a, int b)
        {
            long n = 0;

            while(sp.isPrime(n * n + a * n + b))
            {
                n++;
            }

            return n;
        }
    }
}
