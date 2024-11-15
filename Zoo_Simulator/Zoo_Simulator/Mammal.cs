using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Simulator
{
    internal class Mammal : Animal
    {
        public Mammal(string name, int hunger) : base(name, hunger)
        {
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
