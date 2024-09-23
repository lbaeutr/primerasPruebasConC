using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerasPruebasConC
{
    public class Character
    {
        public string Name { get; set; }
        public int MaxHitPoints { get; set; }   
        public int CurrentHitPoints { get; set; }
        public int BaseDamage { get; set; }
        public int BaseArmour { get; set; }
        private List<Item> inventory;

        public Character(string name, int maxHitPoints, int baseDamage, int baseArmour)
        {
            Name = name;
            MaxHitPoints = maxHitPoints;
            BaseDamage = baseDamage;
            BaseArmour = baseArmour;
            inventory = new List<Item>();

        }

        public int Attack()
        {
            int totalDamage = BaseDamage;

            // Recorrer el inventario y sumar el daño de las armas equipadas
            foreach (var item in inventory)
            {
                if (item is Weapon weapon)
                {
                    totalDamage += weapon.Damage;
                }
            }

            Console.WriteLine($"{Name} ataca con {totalDamage} de daño.");
            return totalDamage;
        }

        public int Defense()
        {
            int totalArmor = BaseArmour;

            // Recorrer el inventario y sumar la defensa de los objetos de protección
            foreach (var item in inventory)
            {
                if (item is Protection protection)
                {
                    totalArmor += protection.Armor;
                }
            }

            Console.WriteLine($"{Name} tiene {totalArmor} de defensa.");
            return totalArmor;
        }

        public void Heal(int amount)
        {
            CurrentHitPoints += amount;
            if (CurrentHitPoints > MaxHitPoints)
            {
                CurrentHitPoints = MaxHitPoints; // No sobrepasa la vida max
            }
            Console.WriteLine($"{Name} se cura {amount} puntos. Puntos de vida actuales: {CurrentHitPoints}");
        }

        public void ReceiveDamage(int damage)
        {
            CurrentHitPoints -= damage;
            if (CurrentHitPoints < 0)
            {
                CurrentHitPoints = 0; // Evitar valores negativos de puntos de vida
            }
            Console.WriteLine($"{Name} recibe {damage} puntos de daño. Puntos de vida actuales: {CurrentHitPoints}");
        }

        public void AddItem(Item item)
        {
            inventory.Add(item);
        }

        public void ApplyItem(Item item)
        {
            item.Apply(this);
        }
    }
}
