using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios_08_cs_basico
{
    internal class Exercicio05
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            bool primo = true;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    primo = false;
                    break;
                }
            }

            if (primo && numero > 1)
                Console.WriteLine($"{numero} é primo.");
            else
                Console.WriteLine($"{numero} não é primo.");
        }
    }
}
