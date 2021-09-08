using System;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {

            float num1 = 0; float num2 = 0;

            Console.WriteLine("Lommeregner!\r");
            Console.WriteLine("------------\n");

            Console.WriteLine("Skriv et nummer her");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv et andet nummer her");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vælg en mulighed af de følgende:");
            Console.WriteLine("\tp - Plus");
            Console.WriteLine("\tm - Minus");
            Console.WriteLine("\tg - Gange");
            Console.WriteLine("\td - Dividere");
            Console.Write("Hvad vælger du? ");

            switch (Console.ReadLine())
            {
                case "p":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "g":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.Write("Tryk på hvilken som helst knap for at lukke applikationen...");
            Console.ReadKey();
        }
    }
}
