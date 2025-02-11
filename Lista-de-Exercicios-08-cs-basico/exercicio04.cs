using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios_08_cs_basico
{
    internal class Exercicio04
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= numero; i++)
            {
                soma += i;
            }

            Console.WriteLine($"A soma dos números de 1 a {numero} é: {soma}");
        }
    }
}
