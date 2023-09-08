using System;
using System.Threading;

namespace Numberguesser
{
    internal class Multiplayer
    {
        public void Play()
        {
            bool newGame = true;

            while (newGame)
            {
                int counterPlayer1 = 0;
                int counterPlayer2 = 0;

                Random random = new Random();
                int randomNumber1 = random.Next(1, 101);
                int randomNumber2 = random.Next(1, 101);

                bool again = true;
                while (again)
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 1, enter a number!");
                    Console.WriteLine();
                    try
                    {
                        int guessPlayer1 = Convert.ToInt32(Console.ReadLine());
                        counterPlayer1++;

                        // Vergleich der Zahlen
                        if (guessPlayer1 == randomNumber1)
                        {
                            //ChatGPT
                            int frequency = 1000;
                            int duration = 1000;
                            Console.Beep(frequency, duration);
                            Thread.Sleep(duration);
                            //-------------------------------
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Player 1 needed {counterPlayer1} tries");
                            Console.WriteLine("Congratulations, Player 1 guessed the number!");
                            Console.ResetColor();
                            again = false;
                        }
                        else
                        {
                            if (guessPlayer1 < randomNumber1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Player 1: Your number was too small");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Player 1: Your number was too big");
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

                again = true; // Wert zurücksetzen für Spieler 2 

                while (again)
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 2, enter a number!");
                    Console.WriteLine();
                    try
                    {
                        int guessPlayer2 = Convert.ToInt32(Console.ReadLine());
                        counterPlayer2++;

                        // Vergleich der Zahlen
                        if (guessPlayer2 == randomNumber2)
                        {
                            //ChatGPT
                            int frequency = 1000;
                            int duration = 1000;
                            Console.Beep(frequency, duration);
                            Thread.Sleep(duration);
                            //-------------------------------
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Player 2 needed {counterPlayer2} tries");
                            Console.WriteLine("Congratulations, Player 2 guessed the number!");
                            Console.ResetColor();

                            if (counterPlayer1 < counterPlayer2)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("");
                                Console.WriteLine("Player 1 won the game");
                                Console.ResetColor();
                            }
                            else if (counterPlayer2 < counterPlayer1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("");
                                Console.WriteLine("Player 2 won the game");
                                Console.ResetColor();
                            }
                            again = false;
                        }
                        else
                        {
                            if (guessPlayer2 < randomNumber2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Player 2: Your number was too small");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Player 2: Your number was too big");
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