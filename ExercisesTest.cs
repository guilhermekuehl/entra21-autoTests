using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace entra21_tests
{
    public class ExercisesTest
    {
        [Fact]
        public void should_return_an_array_from_1_to_10()
        {
            // BDD - Behavior Driven Design
            // Dado, Quando, Deve

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1,
            // então a aplicação deverá retornar todos os número de 1 a 10

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            var result = exercises.Exercise1A();

            // Deve / Asserções
            var expectedOutput = new int[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], result[i]);
            }
        }

        [Fact]
        public void should_return_an_array_from_10_to_1()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
            // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1B();

            // Deve / Asserções
            var expectedOutput = new int[10]
            {
                10,9,8,7,6,5,4,3,2,1
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }
        
        [Fact]
        public void should_return_an_array_from_1_to_10_but_only_even()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1C();

            // Deve / Asserções
            var expectedOutput = new int[5]
            {
                2,4,6,8,10
            };

            Assert.Equal(5, returnedValues.Length);

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }

        [Fact]
        public void should_return_an_int_5050()
        {
            var exercises = new Exercises();

            var result = exercises.Exercise2();

            Assert.Equal(5050, result); 
        }
    
        [Fact]
        public void should_return_odd_numbers_between_1_and_200()
        {
            var exercise = new Exercises();

            var returnedValues = exercise.Exercise3();

            var expectedOutput = new int[]
            {
                1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31,33,35,
                37,39,41,43,45,47,49,51,53,55,57,59,61,63,65,67,
                69,71,73,75,77,79,81,83,85,87,89,91,93,95,97,99,
                101,103,105,107,109,111,113,115,117,119,121,123,
                125,127,129,131,133,135,137,139,141,143,145,147,
                149,151,153,155,157,159,161,163,165,167,169,171,
                173,175,177,179,181,183,185,187,189,191,193,195,
                197,199
            };

            Object.Equals(expectedOutput, returnedValues);
        }
    
        [Fact]
        public void should_return_a_numbers_between_0_to_200()
        {
            var exercise = new Exercises();

            var returnedValues = exercise.Exercise3();

            var expectedOutput = new int[]
            {
                1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31,33,35,
                37,39,41,43,45,47,49,51,53,55,57,59,61,63,65,67,
                69,71,73,75,77,79,81,83,85,87,89,91,93,95,97,99,
                101,103,105,107,109,111,113,115,117,119,121,123,
                125,127,129,131,133,135,137,139,141,143,145,147,
                149,151,153,155,157,159,161,163,165,167,169,171,
                173,175,177,179,181,183,185,187,189,191,193,195,
                197,199
            };

            Object.Equals(expectedOutput, returnedValues);
        }
    
        [Fact]
        public void should_return_a_8_when_passed_7_and_9()
        {
            var exercise = new Exercises();

            var myList = new List<int>(){7, 9};

            var returnedValues = exercise.Exercise4(myList);

            var expectedOutput = 8;

            Object.Equals(expectedOutput, returnedValues);
        }
        
        [Fact]
        public void should_return_a_10_when_passed_8_10_and_12()
        {
            var exercise = new Exercises();

            var myList = new List<int>(){8, 10, 12};

            var returnedValues = exercise.Exercise4(myList);

            var expectedOutput = 10;

            Assert.Equal(expectedOutput, returnedValues);
        }

        [Fact]
        public void should_return_a_10_when_passed_12_14_16_18()
        {
            var exercise = new Exercises();

            var myList = new List<int>(){12, 14, 16, 18};

            var returnedValues = exercise.Exercise4(myList);

            var expectedOutput = 15;

            Assert.Equal(expectedOutput, returnedValues);
        }

         [Fact]
        public void should_return_15_when_passed_12_14_16_18()
        {
            var exercise = new Exercises();

            var myList = new List<int>(){12, 14, 16, 18};

            var returnedValues = exercise.Exercise4(myList);

            var expectedOutput = 15;

            Assert.Equal(expectedOutput, returnedValues);
        }
        
         [Theory]
         [InlineData(new int[5] {19, 12, 12, 56, 41}, 20)]
         [InlineData(new int[5] {18, 19, 40, 56, 41}, 40)]
         [InlineData(new int[5] {16, 22, 21, 23, 41}, 60)]
         [InlineData(new int[5] {28, 27, 26, 25, 40}, 80)]
         [InlineData(new int[5] {28, 27, 26, 25, 24}, 100)]
         [InlineData(new int[5] {78, 45, 44, 56, 41}, 0)]
        public void should_return_20_40_60_80_100_0(int[] women, int expected)
        {
            var exercise = new Exercises();

            var returnedValues = exercise.Exercise5(women.ToList());

            Assert.Equal(expected, returnedValues);
        }

        [Theory]
        [InlineData(10, 5.99, 60, 64692)]
        [InlineData(20, 3.50, 30, 37800)]
        public void should_return_64692_37800(double cigarettes, double price, double years, double expected)
        {
            var exercise = new Exercises();

            var returnedValues = exercise.Exercise7(cigarettes, price, years);

            Assert.Equal(expected, returnedValues);

        }

        [Theory]
        [InlineData(4, 2, true, true)]
        [InlineData(21, 5, false, false)]
        [InlineData(20, 5, true, true)]
        public void should_return_true_false_true(int x, int y, bool z, bool expected)
        {
            var exercise = new Exercises();

            var returnedValues = exercise.Exercise8(x, y, z);

            Assert.Equal(expected, z);
        }
        
        [Theory]
        [InlineData(5, 4, ">")]
        [InlineData(2, 4, "<")]
        [InlineData(-23, -23, "=")]
        public void should_return_greater_lesser_equal(double a, double b, string expected)
        {
            var exercise = new Exercises();

            var returnedValues = exercise.Exercise10(a, b);

            Assert.Equal(expected, returnedValues);

        }

        [Theory]
        [InlineData (2, 2, 1)]
        [InlineData (2, 0, 0)]
        [InlineData (100, 50, 2)]
        public void should_return_1_0(int x, int y,int expected)
        {
            var exercise = new Exercises();

            var returnedValues = exercise.Exercise11(x, y);

            Assert.Equal(expected, returnedValues);
        }
        
        [Theory]
        [InlineData (10, new double[10]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, 10)]
        [InlineData (-1, new double[10]{-10, -9, -8, -7, -6, -5, -4, -3, -2, -1}, -1)]
        [InlineData (7235, new double[10]{02, 215, 45, 634, 34, 55, 235, 7235, 823, 92}, 7235)]
        public void should_return_true(double biggestNumber, double[] input,double expected)
        {
            var exercise = new Exercises();

            var returnedValues = exercise.Exercise13(biggestNumber, input.ToList());

            Assert.Equal(expected, returnedValues);
        }
        [Theory]
        [InlineData (new double[3]{3, 2, 1}, new double[3]{1, 2, 3})]
        [InlineData (new double[3]{-1, -2, -3}, new double[3]{-3, -2, -1})]
        public void should_return_123_321negative_(double[] input, double[] expected)
        {
            var exercise = new Exercises();

            var returnedValues = exercise.Exercise14(input.ToList());

            Assert.Equal(expected, returnedValues);
        }
        
        [Theory]
        [InlineData (1, new int[11]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, new int[11]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10})]
        public void should_return_1_until_10(int input, int[] tabuada, int[] expected)
        {
            var exercise = new Exercises();

            var returnedValues = exercise.Exercise17(tabuada.ToList(), input);

            Assert.Equal(expected, returnedValues);
        }
    }
}