using System;

namespace Adventure
{
    class Program
    {
        static void Main()
        {
            string characterName = "Stalwart Pal";
            Console.WriteLine("Welcome to Quest!\n\nWhat is your name?");

            string possibleName = Console.ReadLine();
            if (!possibleName.Equals(""))
            {
                characterName = possibleName;
            }

            Console.WriteLine($"\nYour character's name is {characterName}.\n\n");
            
            Console.WriteLine("Your adventure is about to begin!\n\n"
                            + "You have traveled many weeks with a merchant caravan and find yourself in the land of Sinnom. "
                            + "The land is hot and dry, its people seem equally callous and most don't even notice your arrival. "
                            + "Those who look your way do not see you but appear gaze through you. "
                            + "Yoo too begin to feel the weight of the world resting itself on your back. "
                            + "The sight of the inn you are bound for brings no relief.\n"
                            + "Slowly, you walk inside. ");

            Console.ReadKey();
        }
    }
}
