using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Bevarage
    {
        private COFEE_SIZE _coffeeSize;
        protected string description = "Unknown Bevarage";

        public Bevarage(COFEE_SIZE coffeeSize)
        {
            _coffeeSize = coffeeSize;
        }

        public Bevarage(Bevarage bevarage)
        {

        }

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }

    public enum COFEE_SIZE
    {
        TALL,
        GRANDE,
        VENTE
    }
}
