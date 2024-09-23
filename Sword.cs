using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerasPruebasConC
{
    public class Sword : Weapon
    {
        public Sword() : base("Espada",8) { }
    
        public override void Apply(Character character)
        {
            Console.WriteLine($"{character.Name} empuña una espada que aumenta el daño en {Damage}.");
            character.BaseDamage += Damage;

        }
    }

    
}
