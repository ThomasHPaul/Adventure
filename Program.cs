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

            Console.WriteLine("\n\n\n\nYour adventure is about to begin!\n\n");
            Console.Clear();
            Act1();
            GameMenu();
        }

        static void TitleScreen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

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
            Continue();
            Console.Clear();
            Console.ResetColor();
        }

        static void Act1()
        {
            Console.WriteLine("     You have been hired as a guard for a small caravan selling its load of furs & meat. The country you travel is mild and peaceful. " +
                "You and Mark, the other guard, have walked at opposite end of the caravan for a week now. You're bored but the job is easy; there have been no confrontations " +
                "of any kind. \n\n     Cresting a hill, you look to the plains below. The caravan is only four days outside of Kerakstad now. To the west, you see the foothills of " +
                "Arkthand, the old mountain.\n At nightfall, Mark takes the first watch while you settle down on a bedroll...\n\n");
            Continue();
            Dialogue($"{characterName} wake up! We're being attacked!\n\nI'll take the kobolds at the meat wagon. You circle the perimeter and check for more...\n\n");
            Continue();

            // Fight

            Dialogue("That was exciting! I'm glad it's over though. I'm a little worried because kobolds usually don't venture too far from Arkthand.\n\nOh well, it's over now. You're " +
                "up for watch, wake me in the morning...\n");

            // LEVEL UP

            Console.WriteLine("At dawn, you wake the camp. After a quick breakfast, you embark for Kerakstad again.");
            Continue();
            Console.WriteLine("The day is uneventful and nightfall approaches. Feeling wary, you settle next to a wagon as you take the first watch of the night.");
            Continue();

            Console.WriteLine("Watching the fire burn low, you begin to hear footsteps. Drawing your sword, you step outside the wagon circle to see 4 goblins.");
            Console.WriteLine("What do you do?:\n1) Shout to awake the caravan \n2) Rush outside the wagons to meet them alone");
            string choice = Console.ReadLine();
            string MarkDialogue;
            if (choice == "1")
            {
                // fight 2
                Console.WriteLine("Fought 2. Mark hurt");
                MarkDialogue = "One of 'em got a lucky hit on me. My shoulders hurtin' pretty bad.";
            }
            else
            {
                // fight 4
                Console.WriteLine("Fought 4");
                MarkDialogue = "I'm surprised you're alright. Fighting 4 goblins alone is no joke.";
                // LEVEL UP
            }

            Continue();

            Dialogue($"That was some fight. {MarkDialogue} In all the commotion, it looks like a couple merchants were killed. Maybe there was another? Well, I'll go ahead " +
                $"and start my watch. You get some sleep.");

            // LEVEL UP

            Console.WriteLine("You wake again the next morning. With only two days left to Kerakstad, everyone is getting nervous. Attacks on the plains are rare. " +
                "With a couple merchants dead, all are nervous for the final night before reaching the city.");
            Continue();

            Console.WriteLine("You bed down for the night as Mark prepares for the first watch. Sore and tired, you fall deeply into a troubled sleep...\n");
            Continue();
            Console.WriteLine("You startle awake amid shouts and fighting. Standing up, you turn to see the meat wagon being ripped apart by a large ogre. " +
                "You see Mark squaring off with a second ogre and a third fighting the merchants. You race to challenge the first...");
            Continue();

            // battle with ogre

            Console.WriteLine("After the fight, the wagon circle is in shambles. You find Mark on the ground in a pool of blood and breathing heavily.");
            Dialogue("That was some fight huh?\n\n...I thought we might have trouble when the caravan leader traded for a strange crystal...You were at " +
                "the tavern when it happened...I dismissed it but....here we are now. You're all that's left...Kerakstad is just under a day from here. " +
                "You should be safe there...\n\nPlease..find whoever did this, and make them pay..for me, huh?...");
            Continue();
                                 

            /*
            (before next tut) 1 - mostly text with one branch
            (before next tut) 2 - single player single monster HUD Battle
            3 - double player single monster HUD Battle
            4 - Level up
            5 - Items & gaining loot
            
            2. Switches to battle HUD for two back to back battles
            DONE 1. Talk to Mark afterwards
            DONE 1. ---> (kobolds never come this far away from Arkthand)
            4. LEVEL UP
            DONE 1. Travel another day staying wary
            DONE 1. Attacked by Goblins (you find them on this watch, you have choice to alert Mark or fight them yourself 
            2. (4 battles, 2 if you wake Mark)
            DONE 1. Talk to Mark again, find 2 dead merchants, Mark wounded by lucky blow
            4. LEVEL UP
            DONE 1. Travel another day, 2 days from city
            DONE 1. Mark takes watch, you sleep to be awaken by Ogres tearing apart meat wagon and killing merchants.
               
            3. both you and Mark fight Ogre - Ogre fight
            DONE 1. Ogre killed, Mark mortally wounded, caravan leader and merchants dead but killed other Ogre
            DONE 1. Talk to Mark
            DONE 1. ---> confesses that the attacks may be result of gem that caravan leader received in trade upon leaving last city
            5. Gain jewel and 
            1. read description
            5. Gain Loot
            4. LEVEL UP
            1. You are alone with just one day left until city
            1. Travel to city with all you can carry
            1. Rest at inn, sell furs and remaining meats
            */
        }

        static void GameMenu()
        {
            /*
             * OFFER menu items (buy/sell, rest, bar, jeweler to ask about crystal eye, arena bet/fight (becomes available after speaking to bar patron), travel (wander/list of discovered places).
             */
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
            Continue();
            Console.Clear();
        }

        static void Dialogue(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Dialogue(string message, ConsoleColor dialogColor)
        {
            Console.ForegroundColor = dialogColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Continue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Battle(/*Creature monster*/)
        {
            string charName = "Player";
            int cHP = 25;
            int cAP = 6;
            int cAC = 3;

            string monName = "Kobold";
            int mHP = 7;
            int mAP = 3;
            int mAC = 2;

            string BattleHud =
            $@"
            {charName}               {monName}
             =========               =========
            |         |             |         |
            | HP: {cHP} |  1. Attack  | HP: {mHP} |
            | AP: {cAP} |  2. Potion  | AP: {mAP} |
            | AC: {cAC} |  3. Flee    | AC: {mAC} |
            |         |             |         |
             =========               =========
            ";
        }
    }

    class Item
    {

    }

    class Creature
    {
        // Name

        // Hit Points

        // Attack Points

        // Armor Class

        // Experience

        // Attack()

        // UsePotion()

        // LevelUp()

        // LootItems()

        // RestAtInn()

        // class Backpack
        // Abstraction for inventory, used for buying, selling, adding items after battle, tracking potion count, tracking gold
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





