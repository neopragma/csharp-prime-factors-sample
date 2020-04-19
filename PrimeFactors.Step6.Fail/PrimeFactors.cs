using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactors
    {

    // No changes needed to pass example #5 in the kata.

        public static List<int> Of(int num) {
            List<int> primes = new List<int>();
            if (num > 1) {
                if (num % 2 == 0) {
                    primes.Add(2);
                    num /= 2;
                }
                if (num > 1) {
                    primes.Add(num);
                }
            }
            return primes;
        }
    }
}
