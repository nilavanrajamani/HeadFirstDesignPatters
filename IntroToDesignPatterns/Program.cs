using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            ModelDuck modelDuck = new ModelDuck();
            modelDuck.Display();
            modelDuck.SetFlyBehaviour(new FlyRocketPowered());
            modelDuck.PerformFly();
            Console.ReadLine();
        }
    }
}
