namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Wyświetlenie nagłowka - opis aplikacji
            Console.WriteLine("Witaj w aplikacji KALKULATOR!");

            //2. Prośba o podanie 1 liczby
            Console.WriteLine("Podaj proszę 1 liczbę:");

            //3. Pobranie liczby od użytkownika
            var number1 = int.Parse(Console.ReadLine());

            //4. Prośba o podanie działania
            Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: '+', '-', '*', '/'.");

            //5. Pobranie wybranego działania od użytkownika
            var operation = Console.ReadLine();

            //6. Prośba o podanie 2 liczby
            Console.WriteLine("Podaj proszę 2 liczbę:");
            //7. Pobranie liczby od użytkownika
            //8. Wykonanie obliczeń
            //9. Wyświetlenie wyniku użytkownikowi
        }
    }
}
