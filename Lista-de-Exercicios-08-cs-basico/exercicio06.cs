using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios_08_cs_basico
{
    internal class Exercicio06
    {
        static void Main(string[] args)
        {
            int maior = int.MinValue;
            Console.WriteLine("Digite uma sequência de números inteiros (digite 0 para parar):");

            while (true)
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero == 0)
                    break;

                if (numero > maior)
                    maior = numero;
            }

            Console.WriteLine($"O maior número inserido foi: {maior}");
        }
    }
}
