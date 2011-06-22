using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniRPG
{
    partial class Program
    {
        static Character Player; //Created in CreateCharacter method

        static void Main(string[] args)
        {
            WL("<<MiniRPG>>");
            WL();

            Player = CreateCharacter();

            Console.Clear();

            while (true) //Infinite game loop
            {
                LeveledUpCheck();
                Menu();
            }
        }

        private static void LeveledUpCheck()
        {
            if (Player.CheckForLevelUp())
            {
                Player.Level++;
                WL("Congratulations! You have leveled up.");
                WL("You are now level " + Player.Level + " !");
                WL();
                WL("Press any key to continue...");
                Console.ReadKey(false);
            }
        }

        private static void Menu()
        {
            Console.Clear();

            WL("----------MENU---------");
            WL(" B - Battle | S - Shop");

            WL("Character:");
            WL("  Name: " + Player.CharName);
            WL("  Money: " + Player.Money);
            WL("  Level: " + Player.Level);
            WL("  XP: " + Player.XP + "/" +
                Player.GetNextLevelXp());
            WL("  Stats:");
            WL("    Strength: " + Player.Strength);
            WL("    Intellect: " + Player.Intellect);
            WL("    Agility: " + Player.Agility);
            WL("    Stamina: " + Player.Stamina);
            WL("    Spirit: " + Player.Spirit);

            ConsoleKeyInfo MenuInput = Console.ReadKey(false);

            if (MenuInput.KeyChar == 'B' ||
                MenuInput.KeyChar == 'b')
            {
                Battle();
            }
            else if (MenuInput.KeyChar == 'S' ||
                MenuInput.KeyChar == 's')
            {
                Shop();
            }
        }
    }
}
