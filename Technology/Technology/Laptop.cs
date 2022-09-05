using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Laptop : Computer
    {
        public double Weight { get; set; }

        public Laptop(double ram, double storage, bool hasKeyboard, double weight) : base(ram, storage, hasKeyboard)
        {
            Weight = weight;
        }

        public bool IsClunky()
        {
            if (Weight > 5.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
