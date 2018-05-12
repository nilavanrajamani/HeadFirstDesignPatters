using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Bevarage
    {
        protected string description = "Unknown Bevarage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
