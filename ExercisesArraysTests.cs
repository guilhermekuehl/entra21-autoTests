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
        public void should_return_3_numbers_indirect_order()
        {
            var exercisesarrays = new ExercisesArrays();

            var result = exercisesarrays.Exercise2();
            
            var expectedOutput = new int[3]{
                3, 2, 1
            };

            Assert.Equal(expectedOutput, result);
        }
        [Theory]
        [InlineData(new int[3]{1, 2, 3}, 2, true, true)]
        [InlineData(new int[3]{1, 2, 3}, 5, false, false)]
        public void should_return_true_false_true(int numbers, int search, bool found, bool expected)
        {
            var exercise = new Exercises();

            var returnedValues = exercise.Exercise8(numbers, search, found);

            Assert.Equal(expected, found);
        }

        [Theory]
        [InlineData(new double[3]{10, 11, 12}, new double[3]{10, 11, 12}, true)]
        public void should_return_true(double[] a, double[] b, bool expectedOutput)
        {
            var exercisesarrays = new ExercisesArrays();

            var result = exercisesarrays.Exercise4();

            Assert.Equal(expectedOutput, result);
        }
        [Fact]
        public void should_return_()
        {
            var exercisesarrays = new ExercisesArrays();

            var result = exercisesarrays.Exercise4();
            
            var expectedOutput = true;

            Assert.Equal(expectedOutput, result);
        }
    }
}