using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab13Bonus
{
    class Program
    {
        
        public static List<GameCharacter> gameCharacters = new List<GameCharacter>
        {
        new Wizard( "Gandalf", 4, 13, 14, 12),
        new Warrior("Brutus", 14, 5, "Pointy Stabby Thing"),
        new Wizard("Harold Potter", 3, 9, 13, 10),
        new Warrior("Alexander", 9, 5, "Broadsword"),
        new Wizard("Edward Elrich", 4, 10, 17, 16)
        };

        static void Main(string[] args)
        {
            for( int i = 0; i < gameCharacters.Count; i++)
            {
                gameCharacters[i].Play();
            }
            Console.ReadLine();
        }

    }
}
