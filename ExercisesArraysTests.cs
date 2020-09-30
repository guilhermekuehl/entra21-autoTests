using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace entra21_tests
{
    public class ExercisesArraysTests
    {  
        [Fact]
        public void should_return_an_array_with_numbers_2_4_6_8_10_12_14_16_18_20_22_24_26_28_30()
        {
            var exercisesarrays = new ExercisesArrays();

            var result = exercisesarrays.Exercise1();

            const int arraysLength = 15;

            var expectedOutput = new double[arraysLength]{
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
            };

            Assert.Equal(expectedOutput, result);
        }
        [Fact]
        public void should_return_10_values_direct_and_indirect_order()
        {
            
        }
    }
}