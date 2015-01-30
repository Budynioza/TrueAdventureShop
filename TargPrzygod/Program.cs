using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargPrzygod
{
    class Program
    {
        static void Main(string[] args)
        {
            Adventurer Minsc = new Adventurer(1000);
            Market Ribald = new Market(Minsc);
            Ribald.Welcome();
            Ribald.Choice();
            Console.ReadLine();
        }
    }
}
