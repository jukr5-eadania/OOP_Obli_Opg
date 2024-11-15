using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Simulator
{
    public enum Mood
    {
        Angry,
        Starving,
        Hungry,
        Uncomfortable,
        Happy
    }

    abstract class Animal
    {
        protected string name;
        protected int hunger;

        public Animal(string name, int hunger)
        {
            this.name = name;
            this.hunger = hunger;
        }

        public abstract void Eat();

        public virtual void Sleep()
        {

        }
    }
}
