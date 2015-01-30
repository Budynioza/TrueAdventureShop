using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargPrzygod
{
    public class Weapon:Item
    {
       public int Damage;
        public Weapon(string name, int price, int damage)
        {
            this.Name = name;
            this.Price = price;
            this.Damage = damage;
        }
    }
}
