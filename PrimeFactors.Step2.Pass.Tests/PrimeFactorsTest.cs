using System;
using System.Collections.Generic;
using Xunit;

namespace PrimeFactors.Tests
{
    public class PrimeFactorsTest
    {
        [Fact]
        public void PrimeFactors_of_1_are_EmptyList() 
        {
            Assert.Equal(new List<int>(), PrimeFactors.Of(1));
        }

    // We added the second example for the Prime Factors Kata.
    // We did not change this example between 'fail' and 'pass'.
    // We expect all examples to pass after changing class PrimeFactors.

        [Fact]
        public void PrimeFactors_of_2_are_2() 
        {
            Assert.Equal(new List<int>() { 2 }, PrimeFactors.Of(2));
        }

    }
}
