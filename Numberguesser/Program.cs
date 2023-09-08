using System;

namespace Numberguesser
{
    class Program
    {
        static void Main(string[] args)
        {

            bool noError = false;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome in the Numberguesser. Try to guess the random Number between 1 and 100");
            Console.WriteLine("");
            do
            {
                try
                {
                    // Eingabeaufforderung für den Spielmodus anzeigen
                    Console.WriteLine("Singleplayer or Multiplayer?");
                    Console.WriteLine("");
                    Console.ResetColor();
                    string gameMode = Convert.ToString(Console.ReadLine());

                    if (gameMode == "Singleplayer" || gameMode == "singleplayer")
                    {
                        // Wenn der Spielmodus Einzelspieler ist, ein Einzelspiel erstellen und spielen
                        Singleplayer singleplayerGame = new Singleplayer();
                        singleplayerGame.Play();
                    }

                    else if (gameMode == "Multiplayer" || gameMode == "multiplayer")
                    {
                        // Wenn der Spielmodus Mehrspieler ist, ein Mehrspielerspiel erstellen und spielen
                        Multiplayer multiplayerGame = new Multiplayer();
                        multiplayerGame.Play();
                    }

                    else
                    {
                        // Wenn keine gültige Eingabe erfolgt, eine Exception auslösen und die Schleife verlassen
                        noError = true;
                        throw new Exception();
                    }
                }

                catch
                {
                    // Fehlermeldung anzeigen und zur erneuten Eingabe auffordern
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input!!! Try again");
                    Console.ResetColor();
                    Console.WriteLine("");

                }
            }

            while (noError);
        }
    }
}
