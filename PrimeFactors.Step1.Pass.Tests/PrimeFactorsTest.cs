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
    }
}
