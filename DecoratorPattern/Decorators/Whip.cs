using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        private Bevarage _bevarage;

        public Whip(Bevarage bevarage) : base(bevarage)
        {
            _bevarage = bevarage;
        }

        public override double Cost()
        {
            return _bevarage.Cost() + .30;
        }

        public override string GetDescription()
        {
            if (_bevarage is CondimentDecorator)
            {
                return (_bevarage as CondimentDecorator).GetDescription() + " , Whip";
            }
            return ", Whip";
        }
    }
}
