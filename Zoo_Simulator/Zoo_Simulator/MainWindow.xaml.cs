using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Zoo_Simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Zookeeper> Zookeeperlist { get; set; }
        private List<Animal> Cage1Animals { get; set; }
        private List<Animal> Cage2Animals { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Zookeeperlist = new List<Zookeeper>();
            Cage1Animals = new List<Animal>();
            Cage2Animals = new List<Animal>();
            Zookeepers.ItemsSource = Zookeeperlist;

            Animals.Items.Add("Lion");
            Animals.Items.Add("Zebra");
            Animals.Items.Add("Elephant");

            Food.Items.Add("Meat");
            Food.Items.Add("Grass");
            Food.Items.Add("Fruit");
        }

        private void UpdateList()
        {
            Cage1.ItemsSource = null;
            Cage1.ItemsSource = Cage1Animals;
            Cage2.ItemsSource = null;
            Cage2.ItemsSource = Cage2Animals;
            Zookeepers.ItemsSource = null;
            Zookeepers.ItemsSource = Zookeeperlist;
        }

        private void Hire_Zookeeper_Click(object sender, RoutedEventArgs e)
        {
            string newZookeeper = Zookeeper_Input.Text;
            if (!string.IsNullOrEmpty(newZookeeper))
            {
                Zookeeperlist.Add(new Zookeeper { Name = newZookeeper });
                Zookeeper_Input.Clear();

                UpdateList();
            }
            else
            {
                MessageBox.Show("Please enter a name for the zookeeper you want to hire");
            }
        }

        private void Fire_Zookeeper_Click(object sender, RoutedEventArgs e)
        {
            Zookeeper selectedZookeeper = (Zookeeper)Zookeepers.SelectedItem;
            if (selectedZookeeper != null)
            {
                Zookeeperlist.Remove(selectedZookeeper);

                UpdateList();
            }
            else
            {
                MessageBox.Show("Please select a zookeeper to fire");
            }
        }

        private void Add_Animal1_Click(object sender, RoutedEventArgs e)
        {
            string selectedanimal = (string)Animals.SelectedItem;
            if (selectedanimal != null)
            {
                switch (selectedanimal)
                {
                    case "Lion":
                        if (Cage1Animals.Any(x => x is Zebra || x is Elephant))
                        {
                            MessageBox.Show("Lions will eat other animals");
                        }
                        else
                        {
                            Cage1Animals.Add(new Lion());

                            UpdateList();
                        }
                        break;

                    case "Zebra":
                        if (Cage1Animals.Any(x => x is Lion))
                        {
                            MessageBox.Show("Zebra will be eaten by Lion");
                        }
                        else
                        {
                            Cage1Animals.Add(new Zebra());

                            UpdateList();
                        }
                        break;

                    case "Elephant":
                        if (Cage1Animals.Any(x => x is Lion))
                        {
                            MessageBox.Show("Elephant will be eaten by Lion");
                        }
                        else
                        {
                            Cage1Animals.Add(new Elephant());

                            UpdateList();
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a animal to add to the cage");
            }
        }

        private void Add_Animal2_Click(object sender, RoutedEventArgs e)
        {
            string selectedanimal = (string)Animals.SelectedItem;
            if (selectedanimal != null)
            {
                switch (selectedanimal)
                {
                    case "Lion":
                        if (Cage2Animals.Any(x => x is Zebra || x is Elephant))
                        {
                            MessageBox.Show("Lions will eat other animals");
                        }
                        else
                        {
                            Cage2Animals.Add(new Lion());

                            UpdateList();
                        }
                        break;

                    case "Zebra":
                        if (Cage2Animals.Any(x => x is Lion))
                        {
                            MessageBox.Show("Zebra will be eaten by Lion");
                        }
                        else
                        {
                            Cage2Animals.Add(new Zebra());

                            UpdateList();
                        }
                        break;

                    case "Elephant":
                        if (Cage2Animals.Any(x => x is Lion))
                        {
                            MessageBox.Show("Elephant will be eaten by Lion");
                        }
                        else
                        {
                            Cage2Animals.Add(new Elephant());

                            UpdateList();
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a animal to add to the cage");
            }
        }

        private void Remove_Animal1_Click(object sender, RoutedEventArgs e)
        {
            Animal selectedAnimal = (Animal)Cage1.SelectedItem;
            if (selectedAnimal != null)
            {
                Cage1Animals.Remove(selectedAnimal);

                UpdateList();
            }
            else
            {
                MessageBox.Show("Please select an Animal to remove");
            }
        }

        private void Remove_Animal2_Click(object sender, RoutedEventArgs e)
        {
            Animal selectedAnimal = (Animal)Cage2.SelectedItem;
            if (selectedAnimal != null)
            {
                Cage2Animals.Remove(selectedAnimal);

                UpdateList();
            }
            else
            {
                MessageBox.Show("Please select an animal to remove");
            }
        }

        private void Pickup_Food_Click(object sender, RoutedEventArgs e)
        {
            Zookeeper selectedZookeeper = (Zookeeper)Zookeepers.SelectedItem;
            if (selectedZookeeper != null)
            {
                switch (Food.SelectedItem)
                {
                    case "Meat":
                        selectedZookeeper.Meat += 3;
                        UpdateList();
                        break;

                    case "Grass":
                        selectedZookeeper.Grass += 3;
                        UpdateList();
                        break;

                    case "Fruit":
                        selectedZookeeper.Fruit += 3;
                        UpdateList();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a zookeeper to pick up food");
            }
        }

        private void Feed_Animal1_Click(object sender, RoutedEventArgs e)
        {
            Zookeeper selectedZookeeper = (Zookeeper)Zookeepers.SelectedItem;
            Animal selectedAnimal = (Animal)Cage1.SelectedItem;
            if (selectedAnimal != null)
            {
                if (selectedZookeeper != null)
                {
                    selectedAnimal.Eat(selectedZookeeper);
                    UpdateList();
                }
                else
                {
                    MessageBox.Show("Please select a zookeeper to feed the animal");
                }
            }
            else
            {
                MessageBox.Show("Please select an animal to feed");
            }
        }

        private void Feed_Animal2_Click(object sender, RoutedEventArgs e)
        {
            Zookeeper selectedZookeeper = (Zookeeper)Zookeepers.SelectedItem;
            Animal selectedAnimal = (Animal)Cage2.SelectedItem;
            if (selectedAnimal != null)
            {
                if (selectedZookeeper != null)
                {
                    selectedAnimal.Eat(selectedZookeeper);
                    UpdateList();
                }
                else
                {
                    MessageBox.Show("Please select a zookeeper to feed the animal");
                }
            }
            else
            {
                MessageBox.Show("Please select an animal to feed");
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            UpdateList();
        }
    }
}
