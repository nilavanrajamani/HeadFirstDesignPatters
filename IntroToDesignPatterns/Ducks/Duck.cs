using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToDesignPatterns
{
    public abstract class Duck
    {
        protected IFlyBehaviour flyBehaviour;
        protected IQuackableBehaviour quackableBehaviour;
        public abstract void Display();

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            quackableBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All Ducks swim!!!!");
        }

        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            this.flyBehaviour = flyBehaviour;
        }

        public void SetQuackBehaviour(IQuackableBehaviour quackableBehaviour)
        {
            this.quackableBehaviour = quackableBehaviour;
        }
    }
}
