using System;

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
            var soma = 0;

            for (int i = 1; i <= 100; i++)
            {
				soma += i;
            }
            return soma;
        }
        
        public int Exercise3()
        {
            var i = 1;

            for (i = 1; i < 200; i += 2)
            {
                
            }
            return i;
        }

        public double Exercise4()
        {
            var soma = 0;
            var idade = 0;
            var counter = 0;
            var average = 0.0;

            average = soma / counter;
            return average;
		}
        
    }
}