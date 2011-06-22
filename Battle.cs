using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniRPG
{
    partial class Program
    {
        private static void Battle()
        {
        	while (true) //Infinite loop while monster of player is still alive
        	{
        		Monster Enemy = GetMonster();
        	}
        }
        
        private static Monster GetMonster()
        {
        	switch (Player.Level)
        	{
        		case 1:
        			
        	}
        }
    }
}
