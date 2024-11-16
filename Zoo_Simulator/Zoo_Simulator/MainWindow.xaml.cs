using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zoo_Simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Zookeeper> Zookeeperlist { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Zookeeperlist = new List<Zookeeper>();
            Zookeepers.ItemsSource = Zookeeperlist;

            Food.Items.Add("Seeds");
            Food.Items.Add("Fish");
            Food.Items.Add("Shrimp");
            Food.Items.Add("Vegetables");
            Food.Items.Add("Small Insects");
            Food.Items.Add("Bananas");
            Food.Items.Add("Meat");
            Food.Items.Add("Fruit");
        }

        private void Add_Animal_Click(object sender, RoutedEventArgs e)
        {
            Add_Animal addAnimal = new Add_Animal();

            addAnimal.Show();
        }

        public void AddAnimal()
        {
            Bird_Cage.Items.Add("burd");
        }

        private void Hire_Zookeeper_Click(object sender, RoutedEventArgs e)
        {
            string newZookeeper = Zookeeper_Input.Text;
            if (!string.IsNullOrEmpty(newZookeeper))
            {
                Zookeeperlist.Add(new Zookeeper { Name = newZookeeper });
                Zookeeper_Input.Clear();

                Zookeepers.ItemsSource = null;
                Zookeepers.ItemsSource = Zookeeperlist;
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

                Zookeepers.ItemsSource = null;
                Zookeepers.ItemsSource = Zookeeperlist;
            }
            else
            {
                MessageBox.Show("Please select a zookeeper to fire");
            }
        }

        private void Feed_Animal_Click(object sender, RoutedEventArgs e)
        {
            Zookeeper selectedZookeeper = (Zookeeper)Zookeepers.SelectedItem;

            if (selectedZookeeper != null)
            {
                if (Bird_Cage.SelectedItem != null || Reptile_Cage.SelectedItem != null || Mammal_Cage.SelectedItem != null)
                {
                    if (Food.SelectedIndex > -1)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Please select some food to feed to the animals");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an animal to feed");
                }
            }
            else
            {
                MessageBox.Show("Please select a zookeeper to feed the animals");
            }
        }
    }
}
