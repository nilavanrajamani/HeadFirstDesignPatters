using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToDesignPatterns
{
    public class Squeak : IQuackableBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("I squeak sharply");
        }
    }
}
