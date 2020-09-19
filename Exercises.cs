using System;
using System.Collections.Generic;

namespace entra21_tests
{
    class Exercises
    {
        public int[] Exercise1A()
        {
            var numbers = new int[10];

            for (int counter = 1; counter < 11; counter++)
            {
				numbers[counter - 1] = counter;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
        // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente
        public int[] Exercise1B()
        {
            int[] numbers = new int[10];
            
            for (int counter = 10; counter > 0; counter--)
            {
                numbers[numbers.Length - counter] = counter;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
        // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares
        public int[] Exercise1C()
        {
            var numbers = new int[5];

            for (int counter = 2; counter < 11; counter+=2)
            {
                var index = (counter / 2) - 1;
				numbers[index] = counter;
            }

            return numbers;
        }
        public int Exercise2()
        {
            var sum = 0;

            for (int i = 1; i <= 100; i++)
            {
				sum += i;
            }
            return sum;
        }
        
        public int Exercise3()
        {
            var i = 1;

            for (i = 1; i < 200; i += 2)
            {
                
            }
            return i;
        }

        public double Exercise4(List<int> ages)
        {
            var sum = 0.0;
            var answers = ages.Count;
            foreach (var item in ages)
            {
                sum += item;
            }

            var percent = sum / answers;
            
            return percent;
		}
        
		public int Exercise5(List<int> women)
		{ 
			var womenBetween18And35 = 0;
            
            for (int i = 0; i < 5; i++)
            {
                if (women[i] >= 18 && women[i] <= 35)
                {
                    womenBetween18And35++;
                }
            }
            var percent = (womenBetween18And35 * 100) / 5;
            return percent;
        }

        public double Exercise7(double cigarettes, double price, double years)
        {                           
            var money = (cigarettes * (price / 20)) * 30 * 12 * years;

            return money;
        }

        public bool Exercise8(int x, int y, bool z)
        {                           
            if (x % y == 0)
            {
                z = true;
            }
            else
            {
                z = false;
            }
            return z;
        }

        public bool Exercise9(double number1, double number2, double number3, bool myBool)
		{
            if (number1 > number2 + number3)
            {
                myBool = true;
            }
            else
            {
                myBool = false;
            }
            return myBool;
		}

        public string Exercise10(double a, double b)
        {
            if (a > b)
            {
                return ">";
            }
            else if (b > a)
            {
                return "<";
            }
            else
            {
                return "=";
            }
        }
        public double Exercise11(int firstNumber, int secondNumber)
		{
            if (secondNumber != 0)
            {
                return firstNumber / secondNumber;
            }
            return 0;
		}
    
        public double Exercise13(double biggestNumber, List<double> input)
		{
            for (int i = 0; i < 10; i++)
            {
                if (input[i] > biggestNumber)
                {
                    biggestNumber = input[i];
                }
            }
            return biggestNumber;
		}
    }
}