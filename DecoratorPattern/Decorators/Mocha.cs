using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        private Bevarage _bevarage;

        public Mocha(Bevarage bevarage) : base(bevarage)
        {
            _bevarage = bevarage;
        }

        public override double Cost()
        {
            return _bevarage.Cost() + .20;
        }

        public override string GetDescription()
        {
            if (_bevarage is CondimentDecorator)
            {
                return (_bevarage as CondimentDecorator).GetDescription() + " , Mocha";
            }
            return ", Mocha";
        }
    }
}
