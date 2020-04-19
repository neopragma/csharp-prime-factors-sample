using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactors
    {
        public static List<int> Of(int value) {
            List<int> primes = new List<int>();
            if (value > 1) {

        // Transformation #5 (statement -> statements)
        // Transformation #6 (unconditional -> if)

        // As long as the input value is evenly divisible by 2,
        // we add 2 to the list of primes, as that will be the
        // smallest possible prime factor.

                if (value % 2 == 0) {
                    primes.Add(2);
                    value /= 2;
                }

        // After we've extracted all the 2's, we add the remaining
        // value to the list, unless it's 1.

                if (value > 1) {
                    primes.Add(value);
                }
            }
            return primes;
        }
    }
}
