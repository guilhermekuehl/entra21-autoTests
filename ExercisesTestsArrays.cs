using System;
using System.Collections.Generic;
using Xunit;

namespace entra21_tests
{
    public class ExercisesTestArrays
    {
        [Fact]
        public void should_return_15_times_1()
        {
            var exerciseArrays = new ExercisesArrays();
            var expected = new double[15]
            {
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1
            };

            var returnedValues = exerciseArrays.Exercise1();

            for (int i = 0; i < 15; i++)
            {
                Assert.Equal(expected[i], returnedValues[i]);    
            }
        }
    }
}