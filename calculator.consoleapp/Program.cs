namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Witaj w aplikacji KALKULATOR!");

        
            Console.WriteLine("Podaj proszę 1 liczbę:");

            
            var number1 = int.Parse(Console.ReadLine());

           
            Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: '+', '-', '*', '/'.");

            var operation = Console.ReadLine();

      
            Console.WriteLine("Podaj proszę 2 liczbę:");

          
            var number2 = int.Parse(Console.ReadLine());

            var result = 0;

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    throw new Exception("Wybrałeś złą operację!");
            }
            
           
            Console.WriteLine($"Wynik Twojego działania to: {result}.");
        }
        catch (Exception ex)
            {
               
                Console.WriteLine(ex.Message);
            }
}
}
