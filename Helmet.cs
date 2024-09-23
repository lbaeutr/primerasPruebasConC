using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerasPruebasConC
{
    public class Helmet : Protection
    {
        public Helmet() : base("Helmet", 5) { }

        public override void Apply(Character character)
        {
            Console.WriteLine($"{character.Name} equipa un casco que aumenta la armadura en {Armor}.");
            character.BaseArmour +=Armor;
        }
    }
}
