using System;
using System.Collections.Generic;
using Xunit;

namespace PrimeFactors.Tests
{
    public class PrimeFactorsTest
    {
        [Theory]
        [MemberData(nameof(PrimeFactorsTestData))]
        public void it_returns_the_prime_factors_of_an_integer(
            int value, List<int> expected) 
        {
            Assert.Equal(expected, PrimeFactors.Of(value));
        }

        public static IEnumerable<object[]> PrimeFactorsTestData =>
            new List<object[]>
            {
                new object[] { 1, new List<int>() },
                new object[] { 2, new List<int> { 2 } },
                new object[] { 3, new List<int> { 3 } },
                new object[] { 4, new List<int> { 2, 2 } },

        // We add the 5th example for the Prime Factors kata.
        // We expect it to pass because the prime factors of 6
        // follow the same pattern as those of 4.

        // As TDD practitioners, we are not comfortable with an
        // example that passes on the first try. So, we alter the
        // expected value in order to see that the example can fail
        // for the right reason.
                new object[] { 6, new List<int> { 2, 4 } } // <- should be (2, 3)
            }; 
    }

}
