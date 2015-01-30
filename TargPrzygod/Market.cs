using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargPrzygod
{
    public class Market
    {
        public Adventurer Customer;
        public int answer
        {
            get;
            set;
        }
        public List<Item> ItemList
        {
            get;
            set;
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to Ribald Barteman's shop!");
            Console.WriteLine("How may I serve you? ");
        }
        public void Choice()
        {

            Console.WriteLine("1. Show me your wares \n2. Show me my gold \n3. Maybe next time");
            string answer = (Console.ReadLine());
            switch (answer)
            {
                case "1":
                    Console.WriteLine("Here is a list of my fabulous wares:\n");
                    foreach (Item LoopedItem in ItemList)
                    {
                        Console.WriteLine(LoopedItem.Name + LoopedItem.Price);
                    }
                    this.Buying();
                    break;
                case "2":
                    Console.WriteLine("You have: " + this.Customer.Gold + " gold pieces");
                    Console.WriteLine("What would you like to do next? ");
                    this.Choice();
                    break;
                case "3":
                    Console.WriteLine("Goodbye! Come again");
                    break;
                default:
                    Console.WriteLine("You didn't answer the question! Answer one more time");
                    this.Choice();
                    break;

            }
        }
        public Market(Adventurer adventurer)
        {
            this.Customer = adventurer;
            this.ItemList = new List<Item>();
            ItemList.Add(new Weapon("Small sword", 100, 3));
            ItemList.Add(new Weapon("Big sword", 300, 8));
            ItemList.Add(new Weapon("Small sword +1", 600, 14));
            ItemList.Add(new Weapon("Big sword +1", 800, 19));
            ItemList.Add(new Armor("Light armor", 200, 10));
            ItemList.Add(new Armor("Medium armor", 400, 20));
            ItemList.Add(new Armor("Heavy armor", 600, 30));
        }

        public void Buying()
        {
            Console.WriteLine("\nWhat do you want to buy?");
            string SelectedItemName = Console.ReadLine();
            var SelectedItem = ItemList.Find(w => w.Name == SelectedItemName);

            if (SelectedItem == null)
            {
                this.Buying();
            }
            else
            {
                bool isBougth = Customer.Buy(SelectedItem);
                if (isBougth == true)
                {
                    ItemList.Remove(SelectedItem);
                    Console.WriteLine("You have bought " + SelectedItem.Name + " and you have " + this.Customer.Gold + " gold pieces. \nHow may I serve you?");
                    this.Choice();
                }
                else
                {
                    this.Choice();
                }

            }
           
        }
    }
}
