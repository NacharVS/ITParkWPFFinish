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

namespace RPG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SavePerson_Click(object sender, RoutedEventArgs e)   //создание персонажа
        {
            if (SelectPerson.SelectedIndex==0)
            {
                WorkBase.AddWarriorToDB(new Warrior (NamePerson.Text, SelectPerson.Text ,Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text)));
                ListPersonag.ItemsSource = WorkBase.GetList();
            }
        }

        private void SelectPerson_SelectionChanged(object sender, SelectionChangedEventArgs e) //выбор персонажа
        {
            if (SelectPerson.SelectedIndex == 0)
            {
                Strength.Text = Convert.ToString(30);

                Dexterity.Text = Convert.ToString(15);
                Intelligence.Text = Convert.ToString(10);
                Endurance.Text = Convert.ToString(20);
            }
            else if(SelectPerson.SelectedIndex == 1)
            {
                Strength.Text = Convert.ToString(20);
                Dexterity.Text = Convert.ToString(30);
                Intelligence.Text = Convert.ToString(15);
                Endurance.Text = Convert.ToString(20);
            }
            else if(SelectPerson.SelectedIndex == 2)
            {
                Strength.Text = Convert.ToString(15);
                Dexterity.Text = Convert.ToString(20);
                Intelligence.Text = Convert.ToString(35);
                Endurance.Text = Convert.ToString(20);
            }
        }

        private void ListPersonag_SelectionChanged(object sender, SelectionChangedEventArgs e) //способ передачи персонажа из БД
        {
            if (ListPersonag.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                //NamePerson.Text = WorkBase.GetWarrior(ListPersonag.SelectedItem.ToString()).Name;


            }
        }

        private void ListPersonag_Loaded(object sender, RoutedEventArgs e)  // загрузка листа из БД
        {
            ListPersonag.ItemsSource = WorkBase.GetList();
        }
    }
}
