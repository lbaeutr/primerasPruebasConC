using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerasPruebasConC
{
    public  class Shield : Protection
    {
        public Shield() : base("Shield",7) { }

        public override void Apply(Character character)
        {            
            Console.WriteLine($"{character.Name} equipa un escudo que incrementa la armadura en {Armor}.");
            character.BaseArmour += Armor;
        }
        
    }
}
