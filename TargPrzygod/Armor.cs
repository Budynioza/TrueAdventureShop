using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargPrzygod
{
    public class Armor:Item
    {
       public int Defense;
        public Armor(string name, int price, int defense)
        {
            this.Name = name;
            this.Price = price;
            this.Defense = defense;
        }
    }
}
