using System;
using System.Timers;

namespace Zoo_Simulator
{
    public enum Mood
    {
        Angry,
        Hungry,
        Happy
    }

    abstract class Animal
    {
        public string Name { get; set; }
        public int Hunger { get; set; }
        public Mood Mood { get; set; }

        public Animal()
        {
            Hunger = 10;
            Mood = Mood.Happy;
            SetMetabolism();
        }

        public abstract void Eat(Zookeeper zookeeper);

        public void Metabolism(Object source, ElapsedEventArgs e)
        {
            if (Hunger > 0)
            {
                Hunger--;
            }
            if (Hunger > 6)
            {
                Mood = Mood.Happy;
            }
            if (Hunger <= 6)
            {
                Mood = Mood.Hungry;
            }
            if (Hunger <= 3)
            {
                Mood = Mood.Angry;
            }
        }

        public virtual void SetMetabolism()
        {
            System.Timers.Timer timer = new System.Timers.Timer(10000);
            timer.Elapsed += Metabolism;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
    }
}
