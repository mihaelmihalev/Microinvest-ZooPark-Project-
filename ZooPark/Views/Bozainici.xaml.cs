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
    /// Interaction logic for Animals.xaml
    /// </summary>
    public partial class Bozainici : Window
    {
        public Bozainici()
        {
            InitializeComponent();
            DataContext = new WelcomeVM();
            this.ListBozainici.Items.Add("Делфин");
            this.ListBozainici.Items.Add("Немска овчарка");
            
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WelcomeWindow window = new WelcomeWindow();
            window.Show();
            this.Close();
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            if (ListBozainici.SelectedItems.Count == 0)
            {
                MessageBox.Show("Избери животно");
            }

            else if (ListBozainici.SelectedItem.Equals("Делфин"))
            {
                MessageBox.Show("Делфините (Delphinidae) са семейство морски бозайници от разред Китоподобни. Думата делфин идва от гръцкото δελφίς, което ще рече с утроба, тоест те не са риби, а бозайници, чието самостоятелно развитие е започнало преди около 10 милиона години, през периода на Миоцена.");
            }
            else if (ListBozainici.SelectedItem.Equals("Немска овчарка"))
            {
                MessageBox.Show("Немската овчарка (Немско овчарско куче) е най-известната порода кучета, синоним на вярност към стопанина и семейството. ");
            }
           
        }
    }
}
