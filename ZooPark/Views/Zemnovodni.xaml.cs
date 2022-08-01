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
    /// Interaction logic for Zemnovodni.xaml
    /// </summary>
    public partial class Zemnovodni : Window
    {
        public Zemnovodni()
        {
            InitializeComponent();
            this.ListZemnovodni.Items.Add("Жаба");
            this.ListZemnovodni.Items.Add("Костенурка");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WelcomeWindow window = new WelcomeWindow();
            window.Show();
            this.Close();
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            if (ListZemnovodni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Избери животно");
            }
            else if (ListZemnovodni.SelectedItem.Equals("Жаба"))
            {
                MessageBox.Show("Безопашатите земноводни (Anura), наричани обикновено жаби, са разред земноводни, включващ около 5000 вида. Размерът им варира от 10 mm до 300mm");
            }
            else if (ListZemnovodni.SelectedItem.Equals("Костенурка"))
            {
                MessageBox.Show("Костенурките (Testudines) са едни от най-старите животни на планетата, съществуващи още от ерата на динозаврите (преди 200 милиона години).[1] Те са влечуги от разред Testudines (Костенурки), наричан също Chelonia и имат характерна коруба (черупка).");
            }
        }
    }
}
