using System;
using System.Collections.Generic;

namespace entra21_tests
{
    class ExercisesArrays
    {
        public double[] Exercise1()
        {
            var a = new double[15]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
            };
            var b = new double[15]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 ,13, 14
            };
            var c = new double[15];

            for (int i = 0; i < 15; i++)
            {
                c[i] = a[i] - b[i];
                
            }
            for (int i = 0; i < 15; i++)
            {
                return c[i];
            }
		}
    }
}