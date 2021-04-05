using System;
using System.Collections.Generic;
using System.Text;


namespace p27_euler
{
    public class SimplePrime
    {
        public bool isPrime(ulong number)
        {
            if (number < 2) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0) return false;

            for(ulong i = 3; i <= Convert.ToUInt64(Math.Sqrt(number)); i+=2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
