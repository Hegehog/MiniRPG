using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniRPG
{
    class Character
    {
        //Basic Info
        public string CharName;
        public int Level = 1;
        public int XP = 0;
        
        public int HP;
        public int MaxHP
        {
        	get {
        		return GetMaxHP();
        	}
        	set {
        		return;
        	}
        } //Uses GetMaxHP();

        public int Age = 20; //To Be Implemented
        public Race CharRace; //To Be Implemented

        //Stats
        public int Strength = 5;
        public int Intellect = 5;
        public int Agility = 5;
        public int Stamina = 5;
        public int Spirit = 5;

        //Economy
        public int Money = 20;
        
        public void ResetHP()
        {
        	this.HP = MaxHP;
        }
        public bool CheckForLevelUp()
        {
            if (this.XP >= GetNextLevelXp())
            {
                return true;
            }
            else
            {
                return false;
            }
        } //True if char has leveled up, else False
        public int GetNextLevelXp()
        {
        	return Convert.ToInt32((((Level ^ 2) * 100) + Level * 10));
        } //Formulae: (((Level ^ 2) * 100) + Level * 10)
        public int GetMaxHP()
        {
        	return Convert.ToInt32((Math.Sqrt(Level * 100) + 50) + (Stamina * 1.5));
        } //Formulae: (Math.Sqrt(Level * 100) + 50) + (Stamina * 1.5)
        public int GetMonsterXPGain()
		{
			Random Rand = new Random();
			
			double x = this.GetNextLevelXp() / ((this.Level / 2) + this.Level);
			return Convert.ToInt32(x -
				Rand.Next(this.Level, this.Level * 10) + //Add a random number
				Rand.Next(this.Level, this.Level * 10)); //Subtract a random number
		}
        public Character(string Name)
        {
            this.CharName = Name;
        }
    }
}
