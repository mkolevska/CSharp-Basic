using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ExtraHomework.Class05.GuessTheNumber.models
{
    public class GameModes
    {
        public string GameType { get; set; }
        public GameModes(string type)
        {
            GameType = type;
        }

        public void Easy()
        {
            int numOfTries = 9;
            int maxTries = numOfTries;
            int range = 100;
            int randomNum = new Random().Next(0, range);

            Game(GameType, range, randomNum, maxTries, numOfTries);
        }

        public void Normal()
        {
            int numOfTries = 7;
            int maxTries = numOfTries;
            int range = 500;
            int randomNum = new Random().Next(0, range);

            Game(GameType, range, randomNum, maxTries, numOfTries);
        }

        public void Hard()
        {
            int numOfTries = 5;
            int maxTries = numOfTries;
            int range = 1000;
            int randomNum = new Random().Next(0, range);

            Game(GameType, range, randomNum, maxTries, numOfTries);
        }

        private void Game(string mode,int range, int randomNumber,int maxTries, int userTries)
        {
            bool isActive = true;
            Console.WriteLine($"You have chosen {mode} mode. You have {maxTries} tries to guess a number between 0-{range}. Enter a number to start guessing. GOOD LUCK!");

            while (isActive)
            {               
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out int guessNum);

                if (!isValid || guessNum < 0 || guessNum > range)
                {
                    Console.WriteLine("Invalid number. Try again!");
                    continue;
                }
                else
                {

                    if (guessNum == randomNumber && userTries == maxTries)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You guessed on your first try. Congrats");
                        break;
                    }
                    else if (guessNum == randomNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Congrats. You guessed the number, number entered: {guessNum}");
                        break;
                    }
                    else if (userTries == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"You ran out of tries. The number was {randomNumber}");
                        break;
                    }
                    else if (guessNum > randomNumber)
                    {
                        if(guessNum >= randomNumber + 8)
                        {
                            userTries--;
                            Console.WriteLine($"Your guess is far to high, number entered: {guessNum}, remaining tries: {userTries}");
                        }
                        else if(guessNum >= randomNumber + 1)
                        {
                            userTries--;
                            Console.WriteLine($"Your guess is a little bit higher, number entered: {guessNum}, remaining tries: {userTries}");
                        }
                    }
                    else if (guessNum <= randomNumber)
                    {
                        if(guessNum <= randomNumber - 8)
                        {
                            userTries--;
                            Console.WriteLine($"Your guess is far to low, number entered: {guessNum}, remaining tries: {userTries}");
                        }
                        else if(guessNum <= randomNumber - 1)
                        {
                            userTries--;
                            Console.WriteLine($"Your guess is a little bit lower, number entered: {guessNum}, remaining tries: {userTries}");
                        }
                    }
                }
            }            
        }
    }
}
