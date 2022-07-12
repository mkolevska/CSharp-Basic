using SEDC.ExtraHomework.Class05.Hogwarts.Models;
using System;


namespace SEDC.ExtraHomework.Class05.Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizards HarryPotter = new Wizards("Harry Potter", 85, 42, new DateTime(1991, 09, 01), true, 1);
            Wizards Hermione = new Wizards("Hermione Granger", 55, 41, new DateTime(1991, 09, 01), true, 2);
            Wizards RonWeasly = new Wizards("Ronald Weasly", 45, 42, new DateTime(1991, 09, 01), true, 3);
            Wizards Draco = new Wizards("Draco Malfoy", 70, 42, new DateTime(1991, 09, 01), true, 4);
            Wizards Ginny = new Wizards("Ginny Weasly", 20, 25, new DateTime(2021, 09, 05), false, 5);

            Wizards[] wizzardArray = { HarryPotter, Hermione, RonWeasly, Draco, Kristijan };

            Creatures Owl = new Creatures("Owl", 8, 10, false, 1);
            Creatures Giant = new Creatures("Giant", 150, 90, false, 2);
            Creatures Troll = new Creatures("Troll", 20, 65, false, 3);
            Creatures Phoenix = new Creatures("Phoenix", 250, 95, false, 4);
            Creatures HouseElf = new Creatures("Dobby", 35, 5, false, 5);

            Creatures[] creaturesArray = { Owl, Giant, Troll, Phoenix, HouseElf };

            bool isActive = true;

            Console.WriteLine("Welcome to the game. Choose one of the wizards and one of the available creatures to see if that wizard can tame the creature.");

            while (isActive)
            {
                Options(wizzardArray, creaturesArray);
                Console.WriteLine(string.Empty);

                while (true)
                {
                    Console.WriteLine("Pick wizzard by the number");
                    string wizzardInput = Console.ReadLine();
                    bool isValid = int.TryParse(wizzardInput, out int wizChoice);

                    if (!isValid || wizChoice > wizzardArray.Length || wizChoice < 1)
                    {
                        Console.WriteLine("Choose valid wizard with their number");
                        continue;
                    }
                    else
                    {
                        foreach (Wizards wizzard in wizzardArray)
                        {
                            if (wizzard.ID == wizChoice)
                            {
                                Console.WriteLine($"Picked wizzard: {wizzard.Name}");
                                Console.WriteLine("Pick creature by the number");
                                string creatureInput = Console.ReadLine();
                                bool isValidCr = int.TryParse(creatureInput, out int creChoice);


                                if (!isValidCr || creChoice > creaturesArray.Length || creChoice < 1)
                                {
                                    Console.WriteLine("Invalid creature choice");
                                    continue;
                                }
                                else
                                {

                                    foreach (Creatures creature in creaturesArray)
                                    {
                                        if (creature.ID == creChoice && creature.IsTamed == true)
                                        {
                                            Console.WriteLine($"No such creature available");
                                            continue;
                                        }
                                        else if (creature.ID == creChoice && wizzard.PowerLevel > creature.PowerLevel)
                                        {
                                            Console.WriteLine($"Picked creature: {creature.Name}");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine($"{wizzard.Name} tamed {creature.Name}");
                                            creature.IsTamed = true;
                                            break;
                                        }
                                        else if (creature.ID == creChoice && wizzard.PowerLevel < creature.PowerLevel)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine($"{wizzard.Name} cant tame {creature.Name}");
                                            continue;
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                    }
                    break;
                }

                Console.WriteLine("Do you want to continue playing? Enter 1 for yes. Enter any other key to exit the app.");
                string play = Console.ReadLine();

                if (play == "1")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Thanks for playing.");
                    isActive = !isActive;
                }

            }


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("========EXTRA TASK==========");

            foreach (Creatures creature in creaturesArray)
            {
                creature.IsTamed = false;
            }

            foreach (Wizards wizzard in wizzardArray)
            {
                foreach (Creatures creature in creaturesArray)
                {
                    if (wizzard.PowerLevel > creature.PowerLevel)
                    {
                        creature.IsTamed = true;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Creatures that cannot be tamed by any wizzard:");

            foreach (Creatures creature in creaturesArray)
            {
                if (creature.IsTamed == false)
                {
                    Console.WriteLine(creature.Name);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Options(Wizards[] wizzardArray, Creatures[] creaturesArray)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Empty);
            Console.WriteLine("Wizards: ");

            foreach (Wizards wizard in wizzardArray)
            {
                Console.WriteLine($"{wizard.ID}. {wizard.Name} ");
            }

            Console.WriteLine(string.Empty);

            Console.WriteLine("Available Creatures:");
            foreach (Creatures creature in creaturesArray)
            {
                if (creature.IsTamed == false)
                {
                    Console.WriteLine($"{creature.ID}. {creature.Name}");
                }
            }           
        }
    }
}
