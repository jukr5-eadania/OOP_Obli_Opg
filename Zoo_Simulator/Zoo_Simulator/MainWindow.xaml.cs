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
        private List<Zookeeper> zookeeperlist { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            zookeeperlist = new List<Zookeeper>();
            Zookeepers.ItemsSource = zookeeperlist;
        }

        private void Add_Animal_Click(object sender, RoutedEventArgs e)
        {
            Add_Animal addAnimal = new Add_Animal();

            addAnimal.Show();
        }

        public void AddAnimal()
        {
            Bird_Cage.Items.Add("bruh");
        }

        private void Hire_Zookeeper_Click(object sender, RoutedEventArgs e)
        {
            string newZookeeper = Zookeeper_Input.Text;
            if (!string.IsNullOrEmpty(newZookeeper))
            {
                zookeeperlist.Add(new Zookeeper { Name = newZookeeper });
                Zookeeper_Input.Clear();

                Zookeepers.ItemsSource = null;
                Zookeepers.ItemsSource = zookeeperlist;
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
                zookeeperlist.Remove(selectedZookeeper);

                Zookeepers.ItemsSource = null;
                Zookeepers.ItemsSource = zookeeperlist;
            }
            else
            {
                MessageBox.Show("Please Select a zookeeper to fire");
            }
        }

    }
}
