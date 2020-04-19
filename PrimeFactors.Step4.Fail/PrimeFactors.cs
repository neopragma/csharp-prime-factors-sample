using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactors
    {

    // This will fail on the test for prime factors of 4.

        public static List<int> Of(int value) {
            List<int> primes = new List<int>();
            if (value > 1) {
                primes.Add(value);
            }
            return primes;
        }
    }
}
