using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Bevarage
    {
        public CondimentDecorator(COFEE_SIZE coffeeSize) : base(coffeeSize)
        {
        }

        public CondimentDecorator(Bevarage bevarage) : base(bevarage)
        {

        }

        public new abstract string GetDescription();
    }
}
