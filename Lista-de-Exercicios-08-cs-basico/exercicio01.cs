using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios_08_cs_basico
{
    internal class Exercicio01
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var pares = i % 2 == 0; // Verifica se o número é par
                if (pares)
                {
                    Console.Write(i + " "); // Imprime o número par
                }
            }
        }
    }
}