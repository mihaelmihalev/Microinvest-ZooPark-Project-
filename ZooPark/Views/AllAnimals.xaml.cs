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
    /// Interaction logic for AllAnimals.xaml
    /// </summary>
    public partial class AllAnimals : Window
    {
        public AllAnimals()
        {
            InitializeComponent();
            this.ListAnimals.Items.Add("Делфин");
            this.ListAnimals.Items.Add("Немска овчарка");
            this.ListAnimals.Items.Add("Гущер");
            this.ListAnimals.Items.Add("Змия");
            this.ListAnimals.Items.Add("Жаба");
            this.ListAnimals.Items.Add("Костенурка");
            


        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WelcomeWindow window = new WelcomeWindow();
            window.Show();
            this.Close();
        }

        private void Button_Info(object sender, RoutedEventArgs e)
        {
           
                if (ListAnimals.SelectedItems.Count == 0)
                {
                MessageBox.Show("Избери животно");
                }

                else if (ListAnimals.SelectedItem.Equals("Делфин"))
                {
                MessageBox.Show("Делфините (Delphinidae) са семейство морски бозайници от разред Китоподобни. Думата делфин идва от гръцкото δελφίς, което ще рече с утроба, тоест те не са риби, а бозайници, чието самостоятелно развитие е започнало преди около 10 милиона години, през периода на Миоцена.");
                }
                else if (ListAnimals.SelectedItem.Equals("Немска овчарка"))
                {
                MessageBox.Show("Немската овчарка (Немско овчарско куче) е най-известната порода кучета, синоним на вярност към стопанина и семейството. ");
                }
                else if (ListAnimals.SelectedItem.Equals("Гущер"))
                {
                MessageBox.Show("Гущерите(Lacertilia) са студенокръвни влечуги, близки по много белези до змиите, с които споделят и един разред – Люспести");
                }
                else if (ListAnimals.SelectedItem.Equals("Змия"))
                {
                MessageBox.Show("Змиите са удължени, студенокръвни безкраки влечуги от подразред Serpentes, близки родственици на гущерите");
                }
                else if (ListAnimals.SelectedItem.Equals("Жаба"))
                {
                MessageBox.Show("Безопашатите земноводни (Anura), наричани обикновено жаби, са разред земноводни, включващ около 5000 вида. Размерът им варира от 10 mm до 300mm");
                }
                else if (ListAnimals.SelectedItem.Equals("Костенурка"))
                {
                MessageBox.Show("Костенурките (Testudines) са едни от най-старите животни на планетата, съществуващи още от ерата на динозаврите (преди 200 милиона години).[1] Те са влечуги от разред Testudines (Костенурки), наричан също Chelonia и имат характерна коруба (черупка).");
                }


        }

        }
    }

