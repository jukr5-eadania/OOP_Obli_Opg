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
        }

        private void Popup_Add_Animal_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button clicked");
        }
    }
}
