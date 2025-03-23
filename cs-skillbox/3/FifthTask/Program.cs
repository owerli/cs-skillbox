using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input the limit for sequency: ");
            int limit = int.Parse(Console.ReadLine());

            var rand = new Random();
            int guessedNumber = rand.Next(limit);

            while (true) {

                Console.Write("Your guess: ");
                string guess = Console.ReadLine();

                if (guess == "") {

                    Console.WriteLine($"You didn't guess the number! { guessedNumber } was guessed.");
                    break;

                }

                int guessNumber = int.Parse(guess);
                if (guessedNumber == guessNumber) {

                    Console.WriteLine($"You guess is correct, congratulations!");
                    break;

                }

                if (guessedNumber < guessNumber) Console.WriteLine($"The guessed number is less than { guessNumber }.");
                else Console.WriteLine($"The guessed number is greater than {guessNumber}.");

            }

            Console.ReadKey();

        }

    }
}
