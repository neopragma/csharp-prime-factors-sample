using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactors
    {

    // Refactoring: Rename
    // We are manipulating the input value to extract the prime factors,
    // so we changed the name of the argument from value to num, as
    // the name inputValue is not descriptive of the method's behavior.

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
