using System;

namespace IronNinja
{
    class Drink : IConsumable
    {
        public string name {get;set;}
        public int calories {get;set;}
        public bool isSpicy {get;set;}
        public bool isSweet {get;set;}

        public Drink(string name, int cals, bool isSpicy, bool isSweet)
        {
            this.name = name;
            this.calories = cals;
            this.isSpicy = isSpicy;
            this.isSweet = isSweet;
        }
    }   
}