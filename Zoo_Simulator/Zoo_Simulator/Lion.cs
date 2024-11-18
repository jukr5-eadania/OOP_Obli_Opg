using System.Windows;

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
