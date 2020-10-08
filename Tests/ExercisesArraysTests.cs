using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Xunit;

namespace Tests
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
        [InlineData(new int[3]{1, 2, 3}, true, 2, true)]
        [InlineData(new int[3]{1, 2, 3}, false, 2, false)]
        public void should_return_true_false_true(int[] numbers, bool found, int search, bool expected)
        {
            var exercisesarrays = new ExercisesArrays();

            var returnedValues = exercisesarrays.Exercise3(numbers, found, search);

            Assert.Equal(expected, found);
        }

        [Theory]
        [InlineData(new double[3]{10, 11, 12}, new double[3]{10, 11, 12}, true)]
        public void should_return_true(double[] a, double[] b, bool expectedOutput)
        {
            var exercisesarrays = new ExercisesArrays();

            var result = exercisesarrays.Exercise4(a, b);

            Assert.Equal(expectedOutput, result);
        }
        [Fact]
        public void should_return_8()
        {
            var exercisesarrays = new ExercisesArrays();

            var result = exercisesarrays.Exercise5();
            
            var expectedOutput = 8;

            Assert.Equal(expectedOutput, result);
        }
        [Fact]
        public void should_return_an_array_with_numbers_until_index_9_61_and_until_index_11_62()
        {
            var exercisesarrays = new ExercisesArrays();

            var result = exercisesarrays.Exercise6();

            Assert.Collection(
                result,
                item => { Assert.Equal(61, item); },
                item => { Assert.Equal(61, item); },
                item => { Assert.Equal(61, item); },
                item => { Assert.Equal(61, item); },
                item => { Assert.Equal(61, item); },
                item => { Assert.Equal(61, item); },
                item => { Assert.Equal(61, item); },
                item => { Assert.Equal(61, item); },
                item => { Assert.Equal(61, item); },
                item => { Assert.Equal(61, item); },
                item => { Assert.Equal(62, item); },
                item => { Assert.Equal(62, item); }
            );
        }
    }
}