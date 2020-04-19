using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactors
    {
        public static List<int> Of(int num) {
            List<int> primes = new List<int>();
            if (num > 1) {

    // Transformation #10 (if -> while)
    // This was the only change needed to make the example pass.

                while (num % 2 == 0) {
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
