using System;

namespace IronNinja.People
{
    public class SpiceHound : Ninja
    {
        public SpiceHound(string name) : base(name, 1500)
        {}

        public override void Consume(IConsumable item)
        {
            Console.WriteLine($"{name} is about to eat a delicious {item.name}");
            if(isFull) 
            {
                throw new NinjaIsFullException($"Ninja is Full! Stop Feeding {name}!");
            }
            if(item.isSpicy)
            {
                this.calorieIntake += item.calories - 100;
            }
            else
            {
                this.calorieIntake += item.calories;
            }
            this.stomach.Add(item);
        }
    }
}