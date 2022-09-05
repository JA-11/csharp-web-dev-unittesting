using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public abstract class AbstractEntity  //abstract class cannot be instantiated, must extend it!
    {
        public int Id { get; set; }
        private static int nextId = 1;

        public AbstractEntity()
        {
            Id = nextId;
            nextId++;
        }
    }
}
