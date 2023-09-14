using System;
using System.Threading;

namespace Numberguesser
{
    internal class Singleplayer
    {
        public void Play()
        {
            bool newGame = true;

            while (newGame)
            {
                int counter = 0;
                System.Random random = new System.Random();
                int randomNumber = random.Next(1, 101);

                Console.WriteLine();
                Console.WriteLine("Enter a number!");
                Console.WriteLine();

                bool again = true;
                while (again)
                {
                    try
                    {
                        int guess = Convert.ToInt32(Console.ReadLine());
                        counter++;

                        // Vergleich der Zahlen
                        if (guess == randomNumber)
                        {
                            //ChatGPT
                            int frequency = 1000;
                            int duration = 1000;
                            Console.Beep(frequency, duration) ;
                            Thread.Sleep(duration);
                            //-------------------------------
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You needed " + counter +  " tries");
                            Console.WriteLine("Congratulations, you guessed the number!");
                            Console.WriteLine("You won");
                            Console.ResetColor();
                            again = false;
                        }
                        else
                        {
                            if (guess < randomNumber)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Your number was too small");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Your number was too big");
                            }

                            Console.ResetColor();
                        }
                    }
                    catch (FormatException)
                    {
                        // Fehlermeldung anzeigen und zur erneuten Eingabe auffordern
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input format! Please enter a valid number.");
                        Console.ResetColor();
                        Console.WriteLine("");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to play again (yes/no)?");
                Console.WriteLine();
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    newGame = true; 
                }
                else if (answer == "no") 
                {
                    newGame = false;
                }
                else 
                {
                    throw new Exception();
                }    
            }
        }
    }
}