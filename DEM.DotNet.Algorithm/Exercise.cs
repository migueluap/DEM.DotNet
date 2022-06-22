using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM.DotNet.Algorithm
{
    public class Exercise
    {
        //EJERCICIO 1:
        //Determinar si un número generado aleatoriamente de 6 cifras es adecuado para un experimento, donde se requiere que contenga 3 dígitos impares en cualquier posición,
        //al cumplir esta condición se debe mostrar el mensaje es correcto. El número aleatorio se debe generar en un único proceso.
        public string ValidateRandomNumber(int randomNumber)
        {
            string stringRandomNumber = randomNumber.ToString();
            int qtyDigits = stringRandomNumber.Length;
            const string ANSWER_OK = "Correct";
            const string ANSWER_ERROR = "InCorrect";

            if (!qtyDigits.Equals(6))
                return ANSWER_ERROR;

            int qtyOddDigits = 0;
            char[] array = stringRandomNumber.ToCharArray();

            int nro = 0;
            for (int i = 0; i < array.Length; i++)
            {
                nro = Convert.ToInt32(array[i].ToString());
                if (nro % 2 != 0)
                {
                    qtyOddDigits++;
                }
            } 

            if (qtyOddDigits >= 3)
                return ANSWER_OK;

            return ANSWER_ERROR;
        }


        //EJERCICIO 2:
        //2.Convertir un número binario a base diez.
        public int BinaryToDecimal(string binaryInput)
        {
            char[] array = binaryInput.ToCharArray();

            // Invertido pues los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición
                    sum += (int)Math.Pow(2, i);
                }
            }
            return sum;
        }


        //EJERCICIO 3:
        //Convertir un numero de base 16 a binario.
        public string HexadecimalToBinary(string hexadecimalNumber)
        {
            return "";
        }


        //EJERCICIO 4: FACTORIAL :
        public int Factorial(int number) 
        {

            int factorial = 0;

            if (number > 1)
            {
                factorial = number * Factorial(number - 1);
            }
                
            if (number == 1)
                factorial = 1;

            return factorial;
        }

        //EJERCICIO 4: FACTORIAL :
        public int Fibonacci(int position)
        {

            int fibonacciNumber = 0;

            if (position > 1)
            {
                fibonacciNumber = Fibonacci(position - 1) + Fibonacci(position - 2);
            }

            if (position <= 1)
                fibonacciNumber = 1;

            return fibonacciNumber;
        }



    }
}
