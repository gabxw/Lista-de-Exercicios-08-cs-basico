using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios_08_cs_basico
{
    internal class Exercicio02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("Caractere inválido");
            }
            else
            {
                if (input >= 0)
                {
                    for (int i = 0; i < input; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
    }
}

