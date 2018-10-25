using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab13Bonus
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;
        public int SpellNumber
        {
            get { return spellNumber;  }
            set { spellNumber = value; }
            
        }


        public Wizard(string Name, int Strength, int Intelligence, int MagicalEnergy, int SpellNumber) : base (Name, Strength, Intelligence, MagicalEnergy)
        {
            spellNumber = SpellNumber;
            
        }

        public override void Play( )
        {
            
                Console.WriteLine($"\nName: {Name}");
                Console.WriteLine($"Strength: {Strength}");
                Console.WriteLine($"Intelligence: {Intelligence}");
                Console.WriteLine($"Magical Energy: {MagicalEnergy}");
                Console.WriteLine($"Number of Spells: {SpellNumber}");
            
        }

    }
}
