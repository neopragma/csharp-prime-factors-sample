using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactors
    {
        public static List<int> Of(int num) {
            List<int> primes = new List<int>();
            for (int candidate = 2; num > 1; candidate++) {
                for (; num % candidate == 0; num /= candidate) {
                    primes.Add(candidate);
                }
            }
            return primes;
        }
    }
}
