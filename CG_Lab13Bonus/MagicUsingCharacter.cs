using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab13Bonus
{
    class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;
        public int MagicalEnergy
        {
            set { magicalEnergy = value; }
            get { return magicalEnergy;  }
        }

        public MagicUsingCharacter(string Name, int Strength, int Intelligence, int MagicalEnergy) : base( Name, Strength, Intelligence)
        {
            magicalEnergy = MagicalEnergy;
        }
        

        public override void Play()
        {

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
            
        }
    }
}
