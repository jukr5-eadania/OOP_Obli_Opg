using System.Windows;

namespace Zoo_Simulator
{
    internal class Zebra : Animal
    {
        public Zebra()
        {
            Name = "Zebra";
        }

        public override void Eat(Zookeeper zookeeper)
        {
            if (zookeeper.Grass >= 0)
            {
                if (Hunger < 10)
                {
                    Hunger = 10;
                    zookeeper.Grass--;
                    Mood = Mood.Happy;
                    if (Hunger > 10)
                    {
                        Hunger = 10;
                    }
                }
                else
                {
                    MessageBox.Show("Zebra is not hungry");
                }
            }
            else
            {
                MessageBox.Show($"{zookeeper.Name} has no grass left");
            }
        }
    }
}
