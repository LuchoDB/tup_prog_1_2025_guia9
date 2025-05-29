using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            int primero=0, segundo=1;

            for (int i = 0; i <= 10; i++)
            {
                Console.Write(primero + " ");
                int aux = primero + segundo;
                primero = segundo;
                segundo = aux;
            }
        }
    }
}
