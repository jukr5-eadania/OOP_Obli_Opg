using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Simulator
{
    internal class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
