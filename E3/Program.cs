﻿using System;

namespace E3
{
    /*• O IMC – Índice de Massa Corporal é um critério da Organização Mundial
    de Saúde para dar uma indicação sobre a condição de peso de uma pessoa
adulta
    • A fórmula é IMC = peso / (altura) ²
    • Elabore um algoritmo que leia o peso e a altura de um adulto e mostre
    sua condição de acordo com a tabela abaixo.
    IMC em adultos Condição
    Abaixo de 18,5 Abaixo do peso
    Entre 18,5 e 25 Peso normal
    Entre 25 e 30 Acima do peso
    Acima de 30 obeso*/

    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;
            string _peso, _altura;
            while (true)
            {
                Console.WriteLine("Digite um número para o peso : ");
                _peso = Console.ReadLine();
                Console.WriteLine("Digite um número para a altura : ");
                _altura = Console.ReadLine();
                if (float.TryParse(_peso, out peso) && float.TryParse(_altura, out altura))
                {
                    (peso, altura) = (float.Parse(_peso), float.Parse(_altura));
                    imc = peso / (float)Math.Sqrt(altura);
                    if (imc < 18.5f)
                        Console.WriteLine("Você está abaixo do peso!!");
                    else if (imc < 25)
                        Console.WriteLine("Você está Ok !!!");
                    else if (imc < 30)
                        Console.WriteLine("Você está acima do peso !!!");
                    else
                        Console.WriteLine("Você está obeso !!!");
                    break;
                }
                Console.WriteLine("Characteres invalidos, digite apenas Numeros !!!");
            }
            Console.ReadLine();
        }
    }
}
