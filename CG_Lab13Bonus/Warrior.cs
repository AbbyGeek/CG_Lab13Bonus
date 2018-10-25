using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab13Bonus
{
    class Warrior : GameCharacter
    {
        private string weaponType;
        public string WeaponType
        {
            set { weaponType = value; }
            get { return weaponType; }
        }

        public Warrior(string Name, int Strength, int Intelligence, string WeaponType) : base(Name, Strength, Intelligence)
        {
            weaponType = WeaponType;
        }


        public override void Play()
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Weapon Type: {WeaponType}");
        }
    }
}
