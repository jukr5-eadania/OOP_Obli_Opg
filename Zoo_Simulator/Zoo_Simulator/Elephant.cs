using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Zoo_Simulator
{
    internal class Elephant : Animal
    {
        public Elephant()
        {
            Name = "Elephant";
        }

        public override void Eat(Zookeeper zookeeper)
        {
            if (zookeeper.Fruit >= 0)
            {
                if (Hunger < 10)
                {
                    Hunger = 10;
                    zookeeper.Fruit--;
                    Mood = Mood.Happy;
                    if (Hunger > 10)
                    {
                        Hunger = 10;
                    }
                }
                else
                {
                    MessageBox.Show("Elephant is not hungry");
                }
            }
            else
            {
                MessageBox.Show($"{zookeeper.Name} has no fruit left");
            }
        }
    }
}
