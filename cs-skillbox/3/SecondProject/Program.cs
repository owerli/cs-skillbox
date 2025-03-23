using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many cards do you have? ");
            int cardsCount = int.Parse(Console.ReadLine());

            int totalCardsValue = 0;
            for (int cardNumber = 1; cardNumber <= cardsCount; cardNumber++) {

                Console.Write($"Value of your { cardNumber } is ");
                string cardValue = Console.ReadLine();

                int digitalCardValue = 10;
                switch (cardValue)
                {

                    case "J":
                        digitalCardValue += 1;
                        break;

                    case "Q":
                        digitalCardValue += 2;
                        break;

                    case "K":
                        digitalCardValue += 3;
                        break;

                    case "T":
                        digitalCardValue += 4;
                        break;
                    default:
                        digitalCardValue = int.Parse(cardValue);

                        if (digitalCardValue < 2 || digitalCardValue > 10)
                        {

                            digitalCardValue = 0;
                            Console.WriteLine("You have typed wrong value!");

                        }
                        break;

                }

                totalCardsValue += digitalCardValue;

            }

            Console.WriteLine($"Total cards value is {totalCardsValue}.");

        }

    }
}
