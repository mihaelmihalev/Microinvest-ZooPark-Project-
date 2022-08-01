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

namespace ZooPark.Views
{
    /// <summary>
    /// Interaction logic for Vlechugi.xaml
    /// </summary>
    public partial class Vlechugi : Window
    {
        public Vlechugi()
        {
            InitializeComponent();
            this.ListVlechugi.Items.Add("Гущер");
            this.ListVlechugi.Items.Add("Змия");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WelcomeWindow window = new WelcomeWindow();
            window.Show();
            this.Close();
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            if (ListVlechugi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Избери животно");
            }

         
            else if (ListVlechugi.SelectedItem.Equals("Гущер"))
            {
                MessageBox.Show("Гущерите(Lacertilia) са студенокръвни влечуги, близки по много белези до змиите, с които споделят и един разред – Люспести");
            }
            else if (ListVlechugi.SelectedItem.Equals("Змия"))
            {
                MessageBox.Show("Змиите са удължени, студенокръвни безкраки влечуги от подразред Serpentes, близки родственици на гущерите");
            }
            
        }
    }
}
