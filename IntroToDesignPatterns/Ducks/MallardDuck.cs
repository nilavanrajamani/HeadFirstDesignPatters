using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToDesignPatterns
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackableBehaviour = new Squeak();
        }
        public override void Display()
        {
            Console.WriteLine("I am Mallard Duck!!");
        }
    }
}
