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
                WorkBase.AddPersonagToDB(new Warrior (NamePerson.Text, SelectPerson.Text , Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text)));
                ListPersonag.ItemsSource = WorkBase.GetList();
            }
        }

        private void SelectPerson_SelectionChanged(object sender, SelectionChangedEventArgs e) //выбор персонажа
        {
            if (SelectPerson.SelectedIndex == 0)  // Warrior
            {
                Strength.Text = Convert.ToString(Warrior.MinStrenght);
                Dexterity.Text = Convert.ToString(Warrior.MinAgility);
                Intelligence.Text = Convert.ToString(Warrior.MinIntelligence);
                Endurance.Text = Convert.ToString(Warrior.MinEndurance);
                Damage.Text = Convert.ToString(Warrior.Damage);
                Protection.Text = Convert.ToString(Warrior.Protection);
                MagicDamage.Text= Convert.ToString(Warrior.MagicDamage);
                MagicProtection.Text= Convert.ToString(Warrior.MagicProtection);
                Life.Text= Convert.ToString(Warrior.Life);
                Magic.Text= Convert.ToString(Warrior.Magic);
            }
            else if(SelectPerson.SelectedIndex == 1)  //Archer
            {
                Strength.Text = Convert.ToString(20);
                Dexterity.Text = Convert.ToString(30);
                Intelligence.Text = Convert.ToString(15);
                Endurance.Text = Convert.ToString(20);
            }
            else if(SelectPerson.SelectedIndex == 2)   //Wizzard
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
                NamePerson.Text = WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Name;
                SelectPerson.Text= WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Class;
                Level.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Level);
                free_glasses.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Points);
                Strength.Text= Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Strenght);
                Dexterity.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Agility);
                Intelligence.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Intelligence);
                Endurance.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Endurance);
            }
        }

        private void ListPersonag_Loaded(object sender, RoutedEventArgs e)  // загрузка листа из БД
        {
            ListPersonag.ItemsSource = WorkBase.GetList();
        }

        private void UpdatePerson_Click(object sender, RoutedEventArgs e)
        {
            if (ListPersonag.SelectedItem == null)
                MessageBox.Show("Check Personag to update");
            else
                WorkBase.ReplasePersonage(ListPersonag.SelectedItem.ToString(), new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text)));
            ListPersonag.ItemsSource = WorkBase.GetList(); 
        }

        private void Delete_Click(object sender, RoutedEventArgs e) //удалить персонаж
        {
            if (NamePerson.Text== "New_Name")
            {
                MessageBox.Show("Selected personag");
            }
            else
            {
                WorkBase.DeletePersonage(NamePerson.Text);
                ListPersonag.ItemsSource = WorkBase.GetList();
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e) //сброс очков
        {
            
            if (NamePerson.Text == "New_Name")
            {
                MessageBox.Show("Selected personag");
            }
            else if (NamePerson.Text == ListPersonag.ItemsSource)
            {
                free_glasses.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Points);
                Strength.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Strenght);
                Dexterity.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Agility);
                Intelligence.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Intelligence);
                Endurance.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Endurance);
            }
            else
            {
                if (SelectPerson.SelectedIndex == 0)  // Warrior
                {
                    free_glasses.Text = "10";
                    Strength.Text = Convert.ToString(Warrior.MinStrenght);
                    Dexterity.Text = Convert.ToString(Warrior.MinAgility);
                    Intelligence.Text = Convert.ToString(Warrior.MinIntelligence);
                    Endurance.Text = Convert.ToString(Warrior.MinEndurance);
                    Damage.Text = Convert.ToString(Warrior.Damage);
                    Protection.Text = Convert.ToString(Warrior.Protection);
                    MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                    MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                    Life.Text = Convert.ToString(Warrior.Life);
                    Magic.Text = Convert.ToString(Warrior.Magic);
                }
                else if (SelectPerson.SelectedIndex == 1)  //Archer
                {
                    Strength.Text = Convert.ToString(20);
                    Dexterity.Text = Convert.ToString(30);
                    Intelligence.Text = Convert.ToString(15);
                    Endurance.Text = Convert.ToString(20);
                }
                else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                {
                    Strength.Text = Convert.ToString(15);
                    Dexterity.Text = Convert.ToString(20);
                    Intelligence.Text = Convert.ToString(35);
                    Endurance.Text = Convert.ToString(20);
                }
            }
        }

        private void increase_strength_Click(object sender, RoutedEventArgs e) //добавление силы
        {
            if (NamePerson.Text == "New_Name")
            {
                MessageBox.Show("Choose or create a character");
            }
            else 
            {
                if (free_glasses.Text != "0")
                {
                    //Strength.Text = Convert.ToString(Convert.ToInt32(Strength.Text) + 1);
                    //free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) - 1);
                    if (SelectPerson.SelectedIndex == 0)  // Warrior
                    {
                        Strength.Text = Convert.ToString(Convert.ToInt32(Strength.Text) + 1);
                        free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) - 1);
                        new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Warrior.Damage);
                        Protection.Text = Convert.ToString(Warrior.Protection);
                        MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                        Life.Text = Convert.ToString(Warrior.Life);
                        Magic.Text = Convert.ToString(Warrior.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 1)  //Archer
                    {
                        Strength.Text = Convert.ToString(20);
                        Dexterity.Text = Convert.ToString(30);
                        Intelligence.Text = Convert.ToString(15);
                        Endurance.Text = Convert.ToString(20);
                    }
                    else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                    {
                        Strength.Text = Convert.ToString(15);
                        Dexterity.Text = Convert.ToString(20);
                        Intelligence.Text = Convert.ToString(35);
                        Endurance.Text = Convert.ToString(20);
                    }
                }
                else
                {
                    MessageBox.Show("Free points are over");
                }
            }
        }

        private void decrease_strength_Click(object sender, RoutedEventArgs e)
        {
            //if (NamePerson.Text == "New_Name")
            //{
            //    MessageBox.Show("Choose or create a character");
            //}
            //else if (NamePerson.Text != "New_Name")
            //{
            //    if (Strength.Text != Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Strength))
            //    {
            //        Strength.Text = Convert.ToString(Convert.ToInt32(Strength.Text) - 1);
            //        free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 1);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Strength restored ");
            //    }
            //}
        }
    }
}
