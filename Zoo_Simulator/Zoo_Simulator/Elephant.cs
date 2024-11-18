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

        public override void SetMetabolism()
        {
            System.Timers.Timer timer = new System.Timers.Timer(5000);
            timer.Elapsed += Metabolism;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
    }
}