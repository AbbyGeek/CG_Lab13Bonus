using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab13Bonus
{ 
    class GameCharacter
    {

        private string name;
        private int strength;
        private int intelligence;

        public string Name { set { name = value; } get { return name; } }
        public int Strength { set { strength = value; } get { return strength; } }
        public int Intelligence { set { intelligence = value; } get { return intelligence; } }

        


        public GameCharacter(string Name, int Strength, int Intelligence)
        {
            name = Name;
            strength = Strength;
            intelligence = Intelligence;
        }

        public virtual void Play()
        {
            
                Console.WriteLine($"\nName: {Name}");
                Console.WriteLine($"Strength: {Strength}");
                Console.WriteLine($"Intelligence: {Intelligence}");
            
        }

    }
}
