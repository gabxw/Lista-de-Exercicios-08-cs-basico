using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios_08_cs_basico
{
    internal class Exercicio03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra");
            string palavra = Console.ReadLine();
            for (int i =0; i < palavra.Length; i++){
                Console.WriteLine(palavra[i]);
            }
        }
    }
}
