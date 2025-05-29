using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Recursividad
{
    internal class Program
    {
        static bool EsPrimo (int n, int divisor = 2)
        {
            if (n < 2) 
                return false; // Números menores que 2 no son primos
            if (divisor * divisor > n) 
                return true; // Si el divisor es mayor que la raíz cuadrada de n, n es primo
            if (n % divisor == 0) 
                return false; // Si n es divisible por el divisor, no es primo
            return EsPrimo(n, divisor + 1); // Llamada recursiva con el siguiente divisor
        }

        static void ImprimirPrimos(int n, int m)
        {
            if (n > m)
                return; // Caso base: si n es mayor que m, terminamos la recursión
            if (EsPrimo(n)) // Verificamos si n es primo
            {
                Console.Write(n + " ");
            }
            ImprimirPrimos(n + 1, m); // Llamada recursiva con el siguiente númerogit
        }
        static void Main(string[] args)
        {
            int n = 10, m = 50;
            ImprimirPrimos(n, m);
        }
    }
}
