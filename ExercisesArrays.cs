using System;
using System.Collections.Generic;
using System.Linq;

namespace entra21_tests
{
    class ExercisesArrays
    {
        public double[] Exercise1()
        {
            const int arraysLength = 15;
            
            var a = new double[arraysLength]{
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
            };
            var b = new double[arraysLength]{
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
            };
            var c = new double[arraysLength];

            for (int i = 0; i < arraysLength; i++)
            {
                c.Select(x => a[i] - b[i]);
            }
            return c;
		}
        public int[] Exercise2()
        {
            const int arraysLength = 3;
            
            var numbers = new int [arraysLength]{
                1, 2, 3
            };
            var disordNumbers = new int[arraysLength];

            numbers.Reverse();
            disordNumbers = numbers;
            
            return disordNumbers;
		}
        
        public int[] Exercise3()
        {
            const int arraysLength = 10;
            
            var numbers = new double [arraysLength]{
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            const double userNumber = 2;

            var foundNumber = 0.0;

            foreach (var userNumber in numbers)
            {
                
            }
            
            return foundNumber;
		}
	}    
}