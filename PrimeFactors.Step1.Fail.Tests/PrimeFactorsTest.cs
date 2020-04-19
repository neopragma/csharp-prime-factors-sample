using System;
using System.Collections.Generic;
using Xunit;

namespace PrimeFactors.Tests
{
    public class PrimeFactorsTest
    {

    // We know we want a static method to return the prime factors of an integer.
    // We think the name 'Of' will be readable and understandable.
    // We haven't yet decided the best name for this test case.
    // We know the method must return a list of integers.
    // We expect this example to fail because the method returns null.

        [Fact]
        public void PrimeFactors_of_1_are_EmptyList() 
        {
            Assert.Equal(new List<int>(), PrimeFactors.Of(1));
        }
    }
}
