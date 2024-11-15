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
using System.Windows.Shapes;

namespace Zoo_Simulator
{
    /// <summary>
    /// Interaction logic for Add_Animal.xaml
    /// </summary>
    public partial class Add_Animal : Window
    {
        public Add_Animal()
        {
            InitializeComponent();
            CageSelect.Items.Add("Bird Cage");
            CageSelect.Items.Add("Reptile Cage");
            CageSelect.Items.Add("Mammal Cage");

            Select_Animal.Items.Add("Parrot");
            Select_Animal.Items.Add("Pinguin");
            Select_Animal.Items.Add("Flamingo");
            Select_Animal.Items.Add("Turtle");
            Select_Animal.Items.Add("Komodo Dragon");
            Select_Animal.Items.Add("Chameleon");
            Select_Animal.Items.Add("Monkey");
            Select_Animal.Items.Add("Lion");
            Select_Animal.Items.Add("Elephant");
        }

        private void Popup_Add_Animal_Click(object sender, RoutedEventArgs e)
        {
            string animalName = Add_Animal_Input.Text;
            if (!string.IsNullOrEmpty(animalName) && CageSelect.SelectedIndex > -1 && Select_Animal.SelectedIndex > -1)
            {
                switch (CageSelect.Items[CageSelect.SelectedIndex])
                {
                    case "Bird Cage":
                        MessageBox.Show("bird");
                        break;

                    case "Reptile Cage":
                        MessageBox.Show("Reptile Cage");
                        break;

                    case "Mammal Cage":
                        MessageBox.Show("Mammal Cage");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please fill out the items above");
            }
        }

    }
}
