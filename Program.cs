using System;
using IronNinja.People;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet b1 = new Buffet();
            Ninja Goemon = new SweetTooth("Goemon");
            while(!Goemon.isFull)
            {
                Goemon.Consume(b1.Serve());
            }
            foreach(var item in Goemon.stomach)
            {
                Console.WriteLine($"{item.name} {item.calories}");
            }
            Ninja Kobayashi = new SpiceHound("Kobayashi");
            while(!Kobayashi.isFull)
            {
                Kobayashi.Consume(b1.Serve());
            }
            foreach(var item in Kobayashi.stomach)
            {
                Console.WriteLine($"{item.name} {item.calories}");
            }
            Console.WriteLine($"Goemon: {Goemon.stomach.Count}, Kobayashi: {Kobayashi.stomach.Count}");
            if(Goemon.stomach.Count > Kobayashi.stomach.Count) {
                Console.WriteLine("Goemon wins!");
            } else if(Goemon.stomach.Count < Kobayashi.stomach.Count) {
                Console.WriteLine("Kobayashi wins!");
            } else {
                Console.WriteLine("Nobody wins!");
            }
        }
    }
}
