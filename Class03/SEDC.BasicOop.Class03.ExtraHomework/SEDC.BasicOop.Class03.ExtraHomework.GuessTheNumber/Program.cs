using System;

namespace SEDC.BasicOop.Class03.ExtraHomework.GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          If the number that should be guessed is 10 and the user enters 18 it should print out "Your guess is far to high, number entered: 18".
                        If the number that should be guessed is 10 and the user enters 2 it should print out "Your guess is far to low, number entered: 2".
                        If the number that should be guessed is 10 and the user enters 7 it should print out "Your guess is a little bit lower, number entered: 7".
                        If the number that should be guessed is 10 and the user enters 13 it should print out "Your guess is a little bit higher, number entered: 13".
                        If the number that should be guessed is 10 and the user enters 10 it should print out "Nailed it. number entered: 10".
                        You can add your kind of notifications if you like.

                        Based on how fast the user guessed the number it should display a proper title and the number that should be guessed.example If user nails it on the first try it should print out "Lucky guess.".If user did not guess the number it should print out "Try again".

                        Optional: Give the user a chance to restart the game(ex Press 1 to start a new game, press 2 to quit game) without starting the project from scratch.*/
            bool app = true;
            while (app)
            {

                Console.WriteLine("Please enter for easy mode (E), for Normal mode (N),for hard mode (H)");

                string selectedGame = Console.ReadLine();
                switch (selectedGame)
                {
                case "E":
                    Console.WriteLine("You have 9 tries to guess a number between 1-100");
                    var random = new Random();
                    int number = random.Next(100);
                    for (int i = 0; i < 9; i++)
                    {
                        bool isValid = int.TryParse(Console.ReadLine(), out int userInput);
                        int difference = userInput - number;
                        if (isValid)
                        {
                            if (number == userInput)
                            {
                                if (i == 0)
                                {
                                    Console.WriteLine("Lucky guess");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Congratulations you've guessed the correct number");
                                    break;
                                }
                            }
                            else if (difference < 10 && userInput < number)
                            {
                                if (difference < 5)
                                {
                                    Console.WriteLine("Your guess is a bit lower, number entered: " + userInput);
                                }
                                else
                                {
                                    Console.WriteLine("Your guess is far too low, number entered: " + userInput);
                                }
                            }
                            else if (difference < 10 && userInput > number)
                            {
                                if (difference < 5)
                                {
                                    Console.WriteLine("Your guess is a bit higher, number entered: " + userInput);
                                }
                                else
                                {
                                    Console.WriteLine("Your guess is far too high, number entered: " + userInput);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Try again");
                            }
                        }else
                        {
                            Console.WriteLine("Invalid number");
                        }
                    }
                    break;
                case "N":
                    Console.WriteLine("You have 7 tries to guess a number between 1-500");
                    var randomNormal = new Random();
                    int numberNormal = randomNormal.Next(500);
                    
                    for (int i = 0; i < 7; i++)
                    {
                        bool isValid = int.TryParse(Console.ReadLine(), out int userInputNormal);
                        int differenceNormal = numberNormal - userInputNormal;
                        if (isValid)
                        {
                            if (numberNormal == userInputNormal)
                            {
                                if (i == 0)
                                {
                                    Console.WriteLine("Lucky guess");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Congratulations you've guessed the correct number");
                                    break;
                                }
                            }
                            else if (differenceNormal < 50 && userInputNormal < numberNormal)
                            {
                                if(differenceNormal < 25)
                                {
                                    Console.WriteLine("Your guess is a bit lower, number entered: " + userInputNormal);
                                }
                                else
                                {
                                    Console.WriteLine("Your guess is far too low, number entered: " + userInputNormal);
                                }
                            }
                            else if (differenceNormal < 50 && userInputNormal > numberNormal)
                            {
                                if(differenceNormal < 25)
                                {
                                    Console.WriteLine("Your guess is a bit higher, number entered: " + userInputNormal);
                                }
                                else
                                {
                                    Console.WriteLine("Your guess is far too low, number entered: " + userInputNormal);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Try again !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number");
                        }
                    }  
                    break;
                case "H":
                    Console.WriteLine("You have 5 tries to guess a number between 1-1000");
                    var randomHard = new Random();
                    int numberHard = randomHard.Next(1000);

                    for (int i = 0; i < 5; i++)
                    {
                        bool isValid = int.TryParse(Console.ReadLine(), out int userInputHard);
                        int differenceHard = numberHard - userInputHard;
                        if (isValid)
                        {
                            if (numberHard == userInputHard)
                            {
                                if (i == 0)
                                {
                                    Console.WriteLine("Lucky guess");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Congratulations you've guessed the correct number");
                                    break;
                                }
                            }
                            else if (differenceHard < 100 && userInputHard < numberHard)
                            {
                                if (differenceHard < 50)
                                {
                                    Console.WriteLine("Your guess is a bit lower, number entered: " + userInputHard);
                                }
                                else
                                {
                                    Console.WriteLine("Your guess is far too low, number entered: " + userInputHard);
                                }
                            }
                            else if (differenceHard < 100 && userInputHard > numberHard)
                            {
                                if (differenceHard < 50)
                                {
                                    Console.WriteLine("Your guess is a bit higher, number entered: " + userInputHard);
                                }
                                else
                                {
                                    Console.WriteLine("Your guess is far too low, number entered: " + userInputHard);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Try again !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Please select a valid game mode");
                    break;

            }
                Console.WriteLine("Enter 1 to restart, or 2 to exit the game");
                switch(Console.ReadLine())
                {
                    case "2":
                        app = false;
                        break;
                    case "1":
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
