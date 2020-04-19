using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactors
    {
        public static List<int> Of(int num) {
            List<int> primes = new List<int>();
// Refactoring: Simplification (while -> for)
        for (int candidate = 2; num > 1; candidate++) {
// Refactoring: Simplification (while -> for)
            for (; num % candidate == 0; num /= candidate) {
                primes.Add(candidate);
            }
        }
// Refactoring: Remove unnecessary code.
//        if (num > 1) {
//            primes.Add(num);
//        }
            return primes;
        }
    }
}
