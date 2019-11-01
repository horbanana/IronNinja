using System;
using System.Collections.Generic;
using IronNinja.Consumables;


namespace IronNinja.People
{
    public abstract class Ninja
    {
        public string name;
        protected int calorieIntake = 0;
        protected int calorieLimit;
        public List<IConsumable> stomach;
        public bool isFull {
            get { return calorieIntake >= calorieLimit; }
        }
        public Ninja (string name, int calorieLimit=1500)
        {
            this.name = name;
            this.calorieLimit = 1500;
            this.stomach = new List<IConsumable>();
        }

        public virtual void Consume(IConsumable item)
        {
            Console.WriteLine($"{name} is about to eat a delicious {item.name}");
            if(isFull) 
            {
                throw new NinjaIsFullException($"Ninja is Full! Stop Feeding {name}!");
            }
            this.calorieIntake += item.calories;
            this.stomach.Add(item);
        }
    }

    public class NinjaIsFullException : Exception
    {
        public NinjaIsFullException(string message) : base(message) {}
    }
}