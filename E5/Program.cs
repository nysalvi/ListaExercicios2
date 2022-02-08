using System;

namespace E5
{
    /*• Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem
    iguais deverá se somar os dois, caso contrário multiplique A por B.
    Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
    variável C e mostrar seu conteúdo na tela.  */
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            string _a, _b;
            while (true)
            {
                Console.WriteLine("Digite um número para A : ");
                _a = Console.ReadLine();
                Console.WriteLine("Digite um número para B : ");
                _b = Console.ReadLine();
                if (float.TryParse(_a, out a) && float.TryParse(_b, out b))
                {
                    (a, b) = (float.Parse(_a), float.Parse(_b));
                    if (a == b)
                    {
                        c = a + b;
                        Console.WriteLine("O valor de C : " + c);
                        break;
                    }
                    c = a * b;
                    Console.WriteLine("O valor de C : " + c);
                    break;
                }
                Console.WriteLine("Characteres invalidos, digite apenas Numeros !!!");
            }
            Console.ReadLine();
        }
    }
}
