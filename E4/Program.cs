using System;

namespace E4
{
    /*• Faça um algoritmo para receber um número qualquer e informar na tela se
    é par ou ímpar. */
    internal class Program
    {
        static void Main(string[] args)
        {
            float num;
            string _num;
            while (true)
            {
                Console.WriteLine("Digite um número : ");
                _num = Console.ReadLine();
                if (float.TryParse(_num, out num))
                {
                    num = float.Parse(_num);                    
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("O número é par");
                        break;
                    }
                    Console.WriteLine("O número é impar");
                    break;
                }
                Console.WriteLine("Characteres invalidos, digite apenas Numeros !!!");
            }
            Console.ReadLine();
        }
    }    
}
