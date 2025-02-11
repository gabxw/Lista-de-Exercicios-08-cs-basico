using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios_08_cs_basico
{
    internal class Exercicio10
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    soma += i;
            }

            Console.WriteLine($"A soma dos números pares entre 1 e 100 é: {soma}");
        }
    }
}
