using System;

namespace E2
{
    //• Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] abc = new int[3];
            string _a, _b, _c;
            while (true)
            {
                Console.WriteLine("Digite um número para A : ");
                _a = Console.ReadLine();
                Console.WriteLine("Digite um número para B : ");
                _b = Console.ReadLine();
                Console.WriteLine("Digite um número para C : ");
                _c = Console.ReadLine();
                if (int.TryParse(_a, out abc[0]) && int.TryParse(_b, out abc[1]) && int.TryParse(_c, out abc[2]))
                {
                    (abc[0], abc[1], abc[2]) = (int.Parse(_a), int.Parse(_b), int.Parse(_c));
                    Array.Sort(abc);
                    Console.WriteLine(abc[0] + " | " + abc[1] + " | " + abc[2]);
                    break;
                }
                Console.WriteLine("Characteres invalidos, digite apenas Numeros !!!");
            }
            Console.ReadLine();
        }
    }
}
