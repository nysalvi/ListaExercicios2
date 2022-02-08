using System;
using System.Text.RegularExpressions;
namespace ListaExercicios2
{
    internal class Program
    {
        //Exercício 1:
        //• Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
        //@"(\-?\d+\.?\d*){3}" 
        static void Main(string[] args)
        {
            float a, b, c;
            string _a, _b, _c;
            while (true)
            {
                Console.WriteLine("Digite um número para A : ");
                _a = Console.ReadLine();             
                Console.WriteLine("Digite um número para B : ");
                _b = Console.ReadLine();
                Console.WriteLine("Digite um número para C : ");
                _c = Console.ReadLine();
                if (float.TryParse(_a, out a) && float.TryParse(_b, out b) && float.TryParse(_c, out c))                    
                {
                    (a, b, c) = (float.Parse(_a), float.Parse(_b), float.Parse(_c));                    
                    if (a + b <= c)
                    {
                        Console.WriteLine("A soma de A com B é menor ou igual a C");                        
                        break;
                    }
                    Console.WriteLine("A soma de A com B é maior que C");
                    break;
                }               
                Console.WriteLine("Characteres invalidos, digite apenas Numeros !!!" );
            }
            Console.ReadLine();            
        }
    }
}
