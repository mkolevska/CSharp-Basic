using SEDC.ExtraHomework.Class05.GuessTheNumber.models;
using System;

namespace SEDC.ExtraHomework.Class05.GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===== Guess The Number =====");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choose difficulty:");
                Console.WriteLine("1. Easy \n2. Normal \n3. Hard");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    GameModes easyMode = new GameModes("easy");
                    easyMode.Easy();
                }
                else if (choice == "2")
                {
                    GameModes normalMode = new GameModes("normal");
                    normalMode.Normal();
                }
                else if (choice == "3")
                {
                    GameModes hardMode = new GameModes("hard");
                    hardMode.Hard();
                } else
                {
                    Console.WriteLine("Invalid choice. Try again");
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to play again? Enter '1' to play again or enter any other key to exit the game");
                string playAgain = Console.ReadLine();

                if(playAgain == "1")
                {
                    continue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thanks for playing");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }

            }
        }
    }

}
