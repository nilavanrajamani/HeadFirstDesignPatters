using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        private Bevarage _bevarage;

        public Soy(Bevarage bevarage)
        {
            _bevarage = bevarage;
        }

        public override double Cost()
        {
            return _bevarage.Cost() + .10;
        }

        public override string GetDescription()
        {
            if (_bevarage is CondimentDecorator)
            {
                return (_bevarage as CondimentDecorator).GetDescription() + " , Soy";
            }
            return ", Soy";
        }
    }
}
