using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

           
            Console.WriteLine("Calculadora\r");

            Console.WriteLine("Escreve o primeiro numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva o segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual destas opções deseja:");
            Console.WriteLine("\ta - Adição");
            Console.WriteLine("\ts - Subtractação");
            Console.WriteLine("\td - Divisão");
            Console.WriteLine("\tm - Multiplicação");
            Console.Write("Qual deseja?");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
               
            }
        }
    }
}
