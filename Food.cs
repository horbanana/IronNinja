using System;

namespace IronNinja.Consumables
{
    public class Food : IConsumable
    {
        public string name {get;set;}
        public int calories {get;set;}
        public bool isSpicy {get;set;}
        public bool isSweet {get;set;}
        public Food(string name, int cals, bool isSpicy, bool isSweet)
        {
            this.name = name;
            this.calories = cals;
            this.isSpicy = isSpicy;
            this.isSweet = isSweet;
        }
    }
}