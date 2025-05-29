using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._1
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n; // Caso Base: Fibonacci(0) = 0, Fibonacci(1) = 1
            return Fibonacci(n - 1) + Fibonacci(n - 2); // Esto devuelve la suma de los dos números anteriores
        }
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }
    }
}
