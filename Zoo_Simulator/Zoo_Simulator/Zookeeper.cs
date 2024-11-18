
namespace Zoo_Simulator
{
    internal class Zookeeper
    {
        public string Name { get; set; }
        public int Meat { get; set; }
        public int Grass { get; set; }
        public int Fruit { get; set; }

        public Zookeeper()
        {
            Meat = 0;
            Grass = 0;
            Fruit = 0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
