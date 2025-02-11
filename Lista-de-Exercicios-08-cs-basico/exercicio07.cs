using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios_08_cs_basico
{
    internal class Exercicio07
    {
        static void Main(string[] args)
        {
            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine($"Tabuada do {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
