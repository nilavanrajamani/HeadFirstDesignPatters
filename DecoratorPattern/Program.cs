using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bevarage bevarage = new Espresso();
            //Console.WriteLine(bevarage.GetDescription() + " $" + bevarage.Cost());

            bevarage = new Mocha(bevarage);
            bevarage = new Soy(bevarage);
            bevarage = new Whip(bevarage);

            Console.WriteLine((bevarage as CondimentDecorator).GetDescription());
            Console.WriteLine("Cost" + bevarage.Cost());
            Console.ReadLine();
        }
    }
}
