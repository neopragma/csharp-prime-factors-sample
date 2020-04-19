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

        // We add the fourth example for the Prime Factors kata.
        // We expect this to fail because PrimeFactors.of() returns
        // a list containing just the original input value, so in
        // this case it will return a list containing 4.

                new object[] { 4, new List<int> { 2, 2 } }

            }; 
    }

}
