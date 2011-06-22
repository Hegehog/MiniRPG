using System;
using System.IO;
using System.Collections.ObjectModel;

namespace MiniRPG.Data.Monsters
{
	/// <summary>
	/// Description of MonsterDataReader.
	/// </summary>
	public class MonsterDataReader
	{
		public void Read()
		{
            Collection<Monster> Monsters =
                new Collection<Monster>();

			StreamReader rdr = new StreamReader("Monsters.dat");

            while (!rdr.EndOfStream)
            {
                Monster CurrMonster = new Monster();

                string line = rdr.ReadLine();
                line.Trim();

                if (line[0] == '@') //Skip comments
                {
                    foreach (char c in line)
                    {
                        if (c == '@')
                            continue;

                        if (c != ';')
                        {
                            CurrMonster.MonsterName += c;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
		}
	}
}
