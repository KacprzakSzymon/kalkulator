using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Witaj w aplikacji KALKULATOR!");

                Console.WriteLine("Podaj proszę 1 liczbę:");
                var number1 = GetInput();

                Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: '+', '-', '*', '/'.");
                var operation = Console.ReadLine();

                Console.WriteLine("Podaj proszę 2 liczbę:");
                var number2 = GetInput();

                var result = Calculate(number1, number2, operation);

                Console.WriteLine($"Wynik Twojego działania to: {result}.");
            }
            catch (Exception ex)
            {
                //logowanie do pliku
                Console.WriteLine(ex.Message);
            }

        }

        private static int GetInput()
        {
            return int.Parse(Console.ReadLine());
        }

        private static int Calculate(int number1, int number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    throw new Exception("Wybrałeś złą operację!");
            }
        }
    }
}