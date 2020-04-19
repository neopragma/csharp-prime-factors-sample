using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactors
    {

    // So far, all examples call for a list containing the input value.
    // Transformation #4: (constant -> scalar)

        public static List<int> Of(int value) {
            List<int> primes = new List<int>();
            if (value > 1) {
                primes.Add(value);
            }
            return primes;
        }
    }
}
