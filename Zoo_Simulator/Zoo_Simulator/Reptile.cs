using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Simulator
{
    internal class Reptile : Animal
    {
        public Reptile(string name, int hunger) : base(name, hunger)
        {
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
