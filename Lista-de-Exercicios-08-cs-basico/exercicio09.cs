using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios_08_cs_basico
{
    internal class Exercicio09
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números primos entre 1 e 100:");

            for (int i = 2; i <= 100; i++)
            {
                bool primo = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                    Console.WriteLine(i);
            }
        }
    }
}
