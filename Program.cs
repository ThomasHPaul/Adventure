/*
 * Created by: Thomas Paul
 * 
 * Date: 5/20/2020
 * 
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */

using System;

namespace Adventure
{
    class Game
    {
        static string characterName = "Stalwart Pal";

        public static void StartGame()
        {
            TitleScreen();
            NameCharacter();

            Console.WriteLine("Your adventure is about to begin!\n\n"
                + "You have traveled many weeks with a merchant caravan and find yourself in the land of Sinnom. "
                + "The land is hot and dry, its people seem equally callous and most don't even notice your arrival. "
                + "Those who look your way do not see you but appear gaze through you. "
                + "Yoo too begin to feel the weight of the world resting itself on your back. "
                + "The sight of the inn you are bound for brings no relief.\n"
                + "Slowly, you walk inside.");

            Console.WriteLine("You sit down at the bar as a man walks toward you. Clearing his throat, he asks");
            Dialog("Have you see my footpad? That little sneak is around here somewhere. He's half your height and wears tattered leather armor...");
            Console.Write("How do you answer?\n 1) Yes\n 2) No\n 3) Repeat the question\n 4) Stay silent\n");
        }

        static void TitleScreen()
        {
            //TO DO: set title background & foreground color

            string TITLE =
            @"
             _______           _______  _______ _________
            (  ___  )|\     /|(  ____ \(  ____ \\__   __/
            | (   ) || )   ( || (    \/| (    \/   ) (   
            | |   | || |   | || (__    | (_____    | |   
            | |   | || |   | ||  __)   (_____  )   | |   
            | | /\| || |   | || (            ) |   | |   
            | (_\ \ || (___) || (____/\/\____) |   | |   
            (____\/_)(_______)(_______/\_______)   )_(                                             
            ";

            Console.WriteLine(TITLE);
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        static void NameCharacter()
        {
            Console.WriteLine("Welcome to Quest!\n\nWhat is your name?");

            string possibleName = Console.ReadLine();
            if (!possibleName.Equals(""))
            {
                characterName = possibleName;
            }

            Console.WriteLine($"\nYour character's name is {characterName}.\n\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Dialog(string message, ConsoleColor dialogColor)
        {
            Console.ForegroundColor = dialogColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }

    class Item
    {

    }

    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
        }
    }
}





