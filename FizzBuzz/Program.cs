using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using FizzBuzz;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy w grze FizzBuzz. Wprowadź jakąkolwiek liczbę z klawiatury.\nPowiem Tobie czy jest podzielna.\njeśli bez reszty przez 3 to odpowiem Tobie hasłem Fizz.\njeśli bez reszty przez 5 to odpowiedm Tobie hasłem Buzz.\njeśli bez reszty przez 3 i 5 to odpowiem Tobie hasłem FizzBuzz.\na jeśli bez reszty ani przez 3 ani przez 5 to otrzymasz swoją liczbę z powrotem :). ");

            Console.WriteLine("Podaj swoją liczbę:");
            var numberofgame = CheckNum();
            var resultgame = new FizzBuzz();
            var result = resultgame.CheckFizzBuzz(numberofgame);
            Console.WriteLine($"Oto wynik naszej gry: {result}");
        }

        private static int CheckNum()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int num1))
                    {
                    Console.WriteLine("Podałeś nieprawidłową liczbę spróbuj jeszcze raz.");
                    continue;
                    }
                return num1;
            }
            

        }
    }
}
