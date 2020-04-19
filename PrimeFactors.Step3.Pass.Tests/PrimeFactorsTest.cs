using System;
using System.Collections.Generic;
using Xunit;

namespace PrimeFactors.Tests
{
    public class PrimeFactorsTest
    {
    
    // We saw a pattern emerging in the examples and converted the
    // individual test cases into a parameterized test.
    // Refactoring: Extract Method, but not a simple one that the IDE
    // could do automatically.

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
                new object[] { 3, new List<int> { 3 } }
            }; 
    }

}
