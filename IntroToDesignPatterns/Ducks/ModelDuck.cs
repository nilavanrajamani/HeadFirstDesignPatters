using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToDesignPatterns
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackableBehaviour = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("This is look alike Duck!!");
        }
    }
}
