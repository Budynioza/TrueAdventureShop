using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargPrzygod
{
    public class Adventurer
    {
        public int Gold=1000;
        public bool Buy(Item item)
        {
            if (this.Gold >= item.Price)
            {
                this.Gold = this.Gold - item.Price;
                return true;
            }
            else
            {
                Console.WriteLine("Stop kiding! You don't have enough money!");
                Console.WriteLine("What would you like to do next? ");
                return false;
            }
        }
        public Adventurer(int gold)
        {
            this.Gold = gold;
        }
    }
}
