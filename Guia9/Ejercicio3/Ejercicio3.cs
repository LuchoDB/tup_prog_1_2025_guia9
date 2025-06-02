using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Ejercicio3
    {
        static int Factorial(int n) 
        {
            
            
            if (n == 0 || n == 1)
                return 1;
            return n * Factorial(n - 1); //Esto devuelve el factorial de n

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("El factorial no está definido para números negativos.");

            }
            else
            {
                for (int i = 0; i <= numero; i++)
                {
                    Console.WriteLine($"El factorial de {i} es: {Factorial(i)}");
                }
            }
        }
    }
}
