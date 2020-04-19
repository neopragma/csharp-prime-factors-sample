using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactors
    {
        public static List<int> Of(int num) {
            List<int> primes = new List<int>();

    // Move this declaration outside the scope of the first 'if' (now 'while').
    // Transformation #5 (statement -> statements)

        int candidate = 2;

    // Transformation #10 (if -> while)

        while (num > 1) {

            // The lowest prime might not be 2, so we start with 2
            // and then continue using whatever remains after the 2's
            // have been extracted as the next candidate prime.

            // Transformation #4 (constant -> scalar)

            while (num % candidate == 0) {
                primes.Add(candidate);
                num /= candidate;
            }

            // Next candidate to try.
            // Transformation #5 (statement -> statements)

            candidate++;
        }
        if (num > 1) {
            primes.Add(num);
        }
            return primes;
        }
    }
}
