using System;
using IronNinja.Consumables;


namespace IronNinja.People
{
    public class SweetTooth : Ninja
    {
        public SweetTooth(string name) : base(name, 1500)
        {}

        public override void Consume(IConsumable item)
        {
            Console.WriteLine($"{name} is about to eat a delicious {item.name}");
            if(isFull) 
            {
                throw new NinjaIsFullException($"Ninja is Full! Stop Feeding {name}!");
            }
            if(item.isSweet)
            {
                this.calorieIntake += (int)(item.calories*0.8);
            }
            else
            {
                this.calorieIntake += item.calories;
            }
            this.stomach.Add(item);
        }
    }
}