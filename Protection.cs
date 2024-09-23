using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerasPruebasConC
{
    public abstract class Protection : Item
    {
        public string Name {  get; set; }
        public int Armor {  get; set; }

        public Protection(String name , int armor)
        {
            Name = name;
            Armor = armor;
        }
        public abstract void Apply(Character character);
    }

   
}
