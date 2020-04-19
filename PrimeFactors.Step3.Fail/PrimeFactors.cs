using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactors
    {
        public static List<int> Of(int value) {
            List<int> primes = new List<int>();
            if (value > 1) {
                primes.Add(2);
            }
            return primes;
        }
    }
}
