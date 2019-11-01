using System;
using System.Collections.Generic;
using IronNinja.Consumables;

namespace IronNinja
{
    public class Buffet
    {
        private List<IConsumable> _Menu;
        public List<IConsumable> Menu {
            get { return _Menu; }
        }

        public Buffet()
        {
            _Menu = new List<IConsumable>() {
                new Food("Ribs", 1000, false, false),
                new Food("Mac&Cheese", 250, false, false),
                new Food("Buffalo Wings", 500, true, false),
                new Food("Chocolate Lava Cake", 780, false, true),
                new Food("Hot and Sweet Chicken", 600, true, true),
                new Drink("Habanero Margarita", 300, true, true),
                new Drink("Water", 0, false, false),
                new Drink("Apple Juice", 100, false, true)
            };
        }

        public IConsumable Serve() 
        {
            Random r = new Random();
            return _Menu[r.Next(_Menu.Count)];
        }
    }
}