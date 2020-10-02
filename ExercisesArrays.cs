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
        public bool Exercise4()
		{
            const int arraysLenght = 3;
            
            var a = new double?[arraysLenght]{
                10, 11, 12
            };
            var b = new double[arraysLenght]{
                10, 11, 12
            };
            var result = new double[arraysLenght];

            var arraysAreEquals = true;

            for (int i = 0; i < arraysLenght; i++)
            {
                b[i] = result[i];

                var hasEquals = false;

                for (int j = 0; j < a.Length; j++)
                {
                    if(a[j] == result[i])
                    {
                        hasEquals = true;
                        a[j] = null;
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
        public void Exercise5()
		{
            const int arraysLength = 15;

            var belowAverage = 0;
            var aboveAverage = 0;
            var onAverage = 0;

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

            foreach (var item in arrayOfNumbers)
            {
                if(item < soma)
                {
                    belowAverage++;
                }
                else if(item > soma)
                {
                    aboveAverage++;
                }
                else
                {
                    onAverage++;
                }
            }           
            
        }
	}    
}