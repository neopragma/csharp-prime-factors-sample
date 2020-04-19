using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactors
    {

    // When the input value is greater than 1, return a list containing 2.
    // Obviously not a complete solution, but the minimum code necessary
    // to make all the examples pass. To flesh out the solution we must
    // write appropriate examples to drive out the logic step by step.

        public static List<int> Of(int value) {
            List<int> primes = new List<int>();
            if (value > 1) {
                primes.Add(2);
            }
            return primes;
        }
    }
}
