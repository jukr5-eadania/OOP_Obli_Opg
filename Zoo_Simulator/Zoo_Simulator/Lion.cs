using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace Zoo_Simulator
{
    internal class Lion : Animal
    {
        public Lion()
        {
            Name = "Lion";
        }

        public override void Eat(Zookeeper zookeeper)
        {
            if (zookeeper.Meat >= 0)
            {
                if (Hunger < 10)
                {
                    Hunger = 10;
                    zookeeper.Meat--;
                    Mood = Mood.Happy;
                    if (Hunger > 10)
                    {
                        Hunger = 10;
                    }
                }
                else
                {
                    MessageBox.Show("Lion is not hungry");
                }
            }
            else
            {
                MessageBox.Show($"{zookeeper.Name} has no meat left");
            }
        }
    }
}
