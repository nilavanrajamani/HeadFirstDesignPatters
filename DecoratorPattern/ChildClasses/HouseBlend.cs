using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class HouseBlend : Bevarage
    {
        private COFEE_SIZE _coffeeSize;
        public HouseBlend(COFEE_SIZE coffeeSize) : base(coffeeSize)
        {
            _coffeeSize = coffeeSize;
            description = "House Blend";
        }

        public override double Cost()
        {
            if (_coffeeSize == COFEE_SIZE.GRANDE)
            {
                return 3.09;
            }
            else if (_coffeeSize == COFEE_SIZE.TALL)
            {
                return 34.89;
            }
            return 1.49;
        }
    }
}
