using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios_08_cs_basico
{
    internal class Exercicio08
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Divisores de {numero}:");
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
