using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToDesignPatterns
{
    public class NoQuack : IQuackableBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Silence!!!");
        }
    }
}
