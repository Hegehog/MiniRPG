using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniRPG
{
    partial class Program
    {
        static Character CreateCharacter()
        {
            WL("---Create your character---");
            WL();

            WL("What would you like to name your character?");
            Character LocalChar = new Character(Inp()); //Create a new character with the name of the next input line

            WL();
            WL("OK! We are done creating your character.");
            WL();

            W("Press any key to continue...");
            Console.ReadKey(false);

            //EXPAND CHARACTER CREATION IN 0.2

            return LocalChar;
        }
    }
}
