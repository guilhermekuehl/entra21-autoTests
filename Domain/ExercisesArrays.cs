using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
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

            return numbers.Reverse().ToArray();
		}
        
        public bool Exercise3(int[] numbers, bool found, int search)
        {
            foreach (var item in numbers)
            {
                if (item == search)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }
        public bool Exercise4(double[] a, double[] b)
		{
            const int arraysLenght = 3;
            
            var result = new double[arraysLenght];

            var arraysAreEquals = true;

            for (int i = 0; i < arraysLenght; i++)
            {
                result[i] = b[i];

                var hasEquals = false;

                for (int j = 0; j < a.Length; j++)
                {
                    if(a[j] == result[i])
                    {
                        hasEquals = true;
                        break;
                    }   
                }

                if (!hasEquals)
                {
                    arraysAreEquals = false;
                }
            }
            return arraysAreEquals;
		}
        public double Exercise5()
		{
            const int arraysLength = 15;

            var soma = 0.0;
            var average = 0.0;

            var arrayOfNumbers = new double[arraysLength]{
                9.0, 8.0, 7.0, 4.5, 8.0, 9.0, 10.0, 9.0, 8.0, 7.0, 4.5, 8.0, 9.0, 10.0, 9.0
            };
            
            for (int i = 0; i < arraysLength; i++)
            {
                soma += arrayOfNumbers[i];
            }
            average = soma / arraysLength;         
            return average;
        }
        public int[] Exercise6()
		{
            const int arraysLength = 12;

            var a = new int[arraysLength]{
                20, 21, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30
            };
            var b = new int[arraysLength]{
                31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42
            };
            var c = new int[arraysLength];

            Array.Sort(a);

            Array.Reverse(b);

            for (int i = 0; i < arraysLength; i++)
            {
                c[i] = a[i] + b[i];
            }
            Array.Sort(c);
            return c.ToArray();
        }
	}    
}