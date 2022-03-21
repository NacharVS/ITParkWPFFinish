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
                WorkBase.AddPersonagToDB(new Warrior (NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text)));
                ListPersonag.ItemsSource = WorkBase.GetList();
            }
            if (SelectPerson.SelectedIndex == 1)
            {
                WorkBase.AddPersonagToDB(new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text)));
                ListPersonag.ItemsSource = WorkBase.GetList();
            }
            if (SelectPerson.SelectedIndex == 2)
            {
                WorkBase.AddPersonagToDB(new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text)));
                ListPersonag.ItemsSource = WorkBase.GetList();
            }
        }

        private void SelectPerson_SelectionChanged(object sender, SelectionChangedEventArgs e) //выбор персонажа
        {
            if (SelectPerson.SelectedIndex == 0)  // Warrior
            {
                new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
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
                new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                Strength.Text = Convert.ToString(Archer.MinStrenght);
                Dexterity.Text = Convert.ToString(Archer.MinAgility);
                Intelligence.Text = Convert.ToString(Archer.MinIntelligence);
                Endurance.Text = Convert.ToString(Archer.MinEndurance);
                Damage.Text = Convert.ToString(Archer.Damage);
                Protection.Text = Convert.ToString(Archer.Protection);
                MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                Life.Text = Convert.ToString(Archer.Life);
                Magic.Text = Convert.ToString(Archer.Magic);
            }
            else if(SelectPerson.SelectedIndex == 2)   //Wizzard
            {
                new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                Strength.Text = Convert.ToString(Wizard.MinStrenght);
                Dexterity.Text = Convert.ToString(Wizard.MinAgility);
                Intelligence.Text = Convert.ToString(Wizard.MinIntelligence);
                Endurance.Text = Convert.ToString(Wizard.MinEndurance);
                Damage.Text = Convert.ToString(Wizard.Damage);
                Protection.Text = Convert.ToString(Wizard.Protection);
                MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                Life.Text = Convert.ToString(Wizard.Life);
                Magic.Text = Convert.ToString(Wizard.Magic);
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
                Exp.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Exp);
            }
        }

        private void ListPersonag_Loaded(object sender, RoutedEventArgs e)  // загрузка листа из БД
        {
            ListPersonag.ItemsSource = WorkBase.GetList();
        }

        private void UpdatePerson_Click(object sender, RoutedEventArgs e)
        {
            if (ListPersonag.SelectedItem == null)
            {
                MessageBox.Show("Check Personag to update");
            }
            else 
            {
                WorkBase.ReplasePersonage(ListPersonag.SelectedItem.ToString(), new Warrior(NamePerson.Text, SelectPerson.Text, 0, Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text)), 
                    new Archer(NamePerson.Text, SelectPerson.Text, 0, Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text)),
                    new Wizard(NamePerson.Text, SelectPerson.Text, 0, Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text)));
                ListPersonag.ItemsSource = WorkBase.GetList();
            }
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
            else if (NamePerson.Text == ListPersonag.SelectedItem.ToString())
            {
                free_glasses.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Points);
                Strength.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Strenght);
                Dexterity.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Agility);
                Intelligence.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Intelligence);
                Endurance.Text = Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Endurance);
                Exp.Text= Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Exp);
                Level.Text= Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Level);
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
                    Exp.Text = "0";
                    Level.Text = "1";
                }
                else if (SelectPerson.SelectedIndex == 1)  //Archer
                {
                    free_glasses.Text = "10";
                    Strength.Text = Convert.ToString(Archer.MinStrenght);
                    Dexterity.Text = Convert.ToString(Archer.MinAgility);
                    Intelligence.Text = Convert.ToString(Archer.MinIntelligence);
                    Endurance.Text = Convert.ToString(Archer.MinEndurance);
                    Damage.Text = Convert.ToString(Archer.Damage);
                    Protection.Text = Convert.ToString(Archer.Protection);
                    MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                    MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                    Life.Text = Convert.ToString(Archer.Life);
                    Magic.Text = Convert.ToString(Archer.Magic);
                    Exp.Text = "0";
                    Level.Text = "1";
                }
                else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                {
                    free_glasses.Text = "10";
                    Strength.Text = Convert.ToString(Wizard.MinStrenght);
                    Dexterity.Text = Convert.ToString(Wizard.MinAgility);
                    Intelligence.Text = Convert.ToString(Wizard.MinIntelligence);
                    Endurance.Text = Convert.ToString(Wizard.MinEndurance);
                    Damage.Text = Convert.ToString(Wizard.Damage);
                    Protection.Text = Convert.ToString(Wizard.Protection);
                    MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                    MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                    Life.Text = Convert.ToString(Wizard.Life);
                    Magic.Text = Convert.ToString(Wizard.Magic);
                    Exp.Text = "0";
                    Level.Text = "1";
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
                    Strength.Text = Convert.ToString(Convert.ToInt32(Strength.Text) + 1);
                    free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) - 1);
                    if (SelectPerson.SelectedIndex == 0)  // Warrior
                    {
                        new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Warrior.Damage);
                        Protection.Text = Convert.ToString(Warrior.Protection);
                        MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                        Life.Text = Convert.ToString(Warrior.Life);
                        Magic.Text = Convert.ToString(Warrior.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 1)  //Archer
                    {
                        new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Archer.Damage);
                        Protection.Text = Convert.ToString(Archer.Protection);
                        MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                        Life.Text = Convert.ToString(Archer.Life);
                        Magic.Text = Convert.ToString(Archer.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                    {
                        new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Wizard.Damage);
                        Protection.Text = Convert.ToString(Wizard.Protection);
                        MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                        Life.Text = Convert.ToString(Wizard.Life);
                        Magic.Text = Convert.ToString(Wizard.Magic);
                    }
                }
                else
                {
                    MessageBox.Show("Free points are over");
                }
            }
        }

        private void decrease_strength_Click(object sender, RoutedEventArgs e) //убавление силы
        {
            if (NamePerson.Text == "New_Name")
            {
                MessageBox.Show("Choose or create a character");
            }
            else if (NamePerson.Text == Convert.ToString(WorkBase.GetList()))
            {
                if (free_glasses.Text != Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Points))
                {
                    Strength.Text = Convert.ToString(Convert.ToInt32(Strength.Text) - 1);
                    free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 1);
                    if (SelectPerson.SelectedIndex == 0)  // Warrior
                    {                     
                        new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Warrior.Damage);
                        Protection.Text = Convert.ToString(Warrior.Protection);
                        MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                        Life.Text = Convert.ToString(Warrior.Life);
                        Magic.Text = Convert.ToString(Warrior.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 1)  //Archer
                    {
                        new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Archer.Damage);
                        Protection.Text = Convert.ToString(Archer.Protection);
                        MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                        Life.Text = Convert.ToString(Archer.Life);
                        Magic.Text = Convert.ToString(Archer.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                    {
                        new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Wizard.Damage);
                        Protection.Text = Convert.ToString(Wizard.Protection);
                        MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                        Life.Text = Convert.ToString(Wizard.Life);
                        Magic.Text = Convert.ToString(Wizard.Magic);
                    }
                }
                else
                {
                    MessageBox.Show("Points distributed");
                }
            }
            else
            {
                if (free_glasses.Text != "10")
                {
                    Strength.Text = Convert.ToString(Convert.ToInt32(Strength.Text) - 1);
                    free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 1);
                    if (SelectPerson.SelectedIndex == 0)  // Warrior
                    {
                        new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Warrior.Damage);
                        Protection.Text = Convert.ToString(Warrior.Protection);
                        MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                        Life.Text = Convert.ToString(Warrior.Life);
                        Magic.Text = Convert.ToString(Warrior.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 1)  //Archer
                    {
                        new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Archer.Damage);
                        Protection.Text = Convert.ToString(Archer.Protection);
                        MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                        Life.Text = Convert.ToString(Archer.Life);
                        Magic.Text = Convert.ToString(Archer.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                    {
                        new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Wizard.Damage);
                        Protection.Text = Convert.ToString(Wizard.Protection);
                        MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                        Life.Text = Convert.ToString(Wizard.Life);
                        Magic.Text = Convert.ToString(Wizard.Magic);
                    }
                }
                else
                {
                    MessageBox.Show("Points distributed");
                }
            }
        }


        private void increase_dexterity_Click(object sender, RoutedEventArgs e)  //увеличение ловксти
        {
            if (NamePerson.Text == "New_Name")
            {
                MessageBox.Show("Choose or create a character");
            }
            else
            {
                if (free_glasses.Text != "0")
                {
                    Dexterity.Text = Convert.ToString(Convert.ToInt32(Dexterity.Text) + 1);
                    free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) - 1);
                    if (SelectPerson.SelectedIndex == 0)  // Warrior
                    {
                        new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Warrior.Damage);
                        Protection.Text = Convert.ToString(Warrior.Protection);
                        MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                        Life.Text = Convert.ToString(Warrior.Life);
                        Magic.Text = Convert.ToString(Warrior.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 1)  //Archer
                    {
                        new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Archer.Damage);
                        Protection.Text = Convert.ToString(Archer.Protection);
                        MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                        Life.Text = Convert.ToString(Archer.Life);
                        Magic.Text = Convert.ToString(Archer.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                    {
                        new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Wizard.Damage);
                        Protection.Text = Convert.ToString(Wizard.Protection);
                        MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                        Life.Text = Convert.ToString(Wizard.Life);
                        Magic.Text = Convert.ToString(Wizard.Magic);
                    }
                }
                else
                {
                    MessageBox.Show("Free points are over");
                }
            }
        }

        private void decrease_dexterity_Click(object sender, RoutedEventArgs e)  //уменьшение ловкости
        {
            if (NamePerson.Text == "New_Name")
            {
                MessageBox.Show("Choose or create a character");
            }
            else if (NamePerson.Text == Convert.ToString(WorkBase.GetList()))
            {
                if (free_glasses.Text != Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Points))
                {
                    Dexterity.Text = Convert.ToString(Convert.ToInt32(Dexterity.Text) - 1);
                    free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 1);
                    if (SelectPerson.SelectedIndex == 0)  // Warrior
                    {
                        new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Warrior.Damage);
                        Protection.Text = Convert.ToString(Warrior.Protection);
                        MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                        Life.Text = Convert.ToString(Warrior.Life);
                        Magic.Text = Convert.ToString(Warrior.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 1)  //Archer
                    {
                        new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Archer.Damage);
                        Protection.Text = Convert.ToString(Archer.Protection);
                        MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                        Life.Text = Convert.ToString(Archer.Life);
                        Magic.Text = Convert.ToString(Archer.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                    {
                        new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Wizard.Damage);
                        Protection.Text = Convert.ToString(Wizard.Protection);
                        MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                        Life.Text = Convert.ToString(Wizard.Life);
                        Magic.Text = Convert.ToString(Wizard.Magic);
                    }
                }
                else
                {
                    MessageBox.Show("Points distributed");
                }
            }
            else
            {
                if (free_glasses.Text != "10")
                {
                    Dexterity.Text = Convert.ToString(Convert.ToInt32(Dexterity.Text) - 1);
                    free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 1);
                    if (SelectPerson.SelectedIndex == 0)  // Warrior
                    {
                        new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Warrior.Damage);
                        Protection.Text = Convert.ToString(Warrior.Protection);
                        MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                        Life.Text = Convert.ToString(Warrior.Life);
                        Magic.Text = Convert.ToString(Warrior.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 1)  //Archer
                    {
                        new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Archer.Damage);
                        Protection.Text = Convert.ToString(Archer.Protection);
                        MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                        Life.Text = Convert.ToString(Archer.Life);
                        Magic.Text = Convert.ToString(Archer.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                    {
                        new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Wizard.Damage);
                        Protection.Text = Convert.ToString(Wizard.Protection);
                        MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                        Life.Text = Convert.ToString(Wizard.Life);
                        Magic.Text = Convert.ToString(Wizard.Magic);
                    }
                }
                else
                {
                    MessageBox.Show("Points distributed");
                }
            }

        }

        private void increase_intelligence_Click(object sender, RoutedEventArgs e)  //увеличение интелекта
        {
            if (NamePerson.Text == "New_Name")
            {
                MessageBox.Show("Choose or create a character");
            }
            else
            {
                if (free_glasses.Text != "0")
                {
                    Intelligence.Text = Convert.ToString(Convert.ToInt32(Intelligence.Text) + 1);
                    free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) - 1);
                    if (SelectPerson.SelectedIndex == 0)  // Warrior
                    {
                        new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Warrior.Damage);
                        Protection.Text = Convert.ToString(Warrior.Protection);
                        MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                        Life.Text = Convert.ToString(Warrior.Life);
                        Magic.Text = Convert.ToString(Warrior.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 1)  //Archer
                    {
                        new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Archer.Damage);
                        Protection.Text = Convert.ToString(Archer.Protection);
                        MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                        Life.Text = Convert.ToString(Archer.Life);
                        Magic.Text = Convert.ToString(Archer.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                    {
                        new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Wizard.Damage);
                        Protection.Text = Convert.ToString(Wizard.Protection);
                        MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                        Life.Text = Convert.ToString(Wizard.Life);
                        Magic.Text = Convert.ToString(Wizard.Magic);
                    }
                }
                else
                {
                    MessageBox.Show("Free points are over");
                }
            }
        }

        private void decrease_intelligence_Click(object sender, RoutedEventArgs e) //уменьшение интелекта
        {
            if (NamePerson.Text == "New_Name")
            {
                MessageBox.Show("Choose or create a character");
            }
            else if (NamePerson.Text == Convert.ToString(WorkBase.GetList()))
            {
                if (free_glasses.Text != Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Points))
                {
                    Intelligence.Text = Convert.ToString(Convert.ToInt32(Intelligence.Text) - 1);
                    free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 1);
                    if (SelectPerson.SelectedIndex == 0)  // Warrior
                    {
                        new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Warrior.Damage);
                        Protection.Text = Convert.ToString(Warrior.Protection);
                        MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                        Life.Text = Convert.ToString(Warrior.Life);
                        Magic.Text = Convert.ToString(Warrior.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 1)  //Archer
                    {
                        new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Archer.Damage);
                        Protection.Text = Convert.ToString(Archer.Protection);
                        MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                        Life.Text = Convert.ToString(Archer.Life);
                        Magic.Text = Convert.ToString(Archer.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                    {
                        new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Wizard.Damage);
                        Protection.Text = Convert.ToString(Wizard.Protection);
                        MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                        Life.Text = Convert.ToString(Wizard.Life);
                        Magic.Text = Convert.ToString(Wizard.Magic);
                    }
                }
                else
                {
                    MessageBox.Show("Points distributed");
                }
            }
            else
            {
                if (free_glasses.Text != "10")
                {
                    Intelligence.Text = Convert.ToString(Convert.ToInt32(Intelligence.Text) - 1);
                    free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 1);
                    if (SelectPerson.SelectedIndex == 0)  // Warrior
                    {
                        new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Warrior.Damage);
                        Protection.Text = Convert.ToString(Warrior.Protection);
                        MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                        Life.Text = Convert.ToString(Warrior.Life);
                        Magic.Text = Convert.ToString(Warrior.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 1)  //Archer
                    {
                        new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Archer.Damage);
                        Protection.Text = Convert.ToString(Archer.Protection);
                        MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                        Life.Text = Convert.ToString(Archer.Life);
                        Magic.Text = Convert.ToString(Archer.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                    {
                        new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Wizard.Damage);
                        Protection.Text = Convert.ToString(Wizard.Protection);
                        MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                        Life.Text = Convert.ToString(Wizard.Life);
                        Magic.Text = Convert.ToString(Wizard.Magic);
                    }
                }
                else
                {
                    MessageBox.Show("Points distributed");
                }
            }

        }

        private void increase_endurance_Click(object sender, RoutedEventArgs e)  //увеличение выносливости
        {
            if (NamePerson.Text == "New_Name")
            {
                MessageBox.Show("Choose or create a character");
            }
            else
            {
                if (free_glasses.Text != "0")
                {
                    Endurance.Text = Convert.ToString(Convert.ToInt32(Endurance.Text) + 1);
                    free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) - 1);
                    if (SelectPerson.SelectedIndex == 0)  // Warrior
                    {
                        new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Warrior.Damage);
                        Protection.Text = Convert.ToString(Warrior.Protection);
                        MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                        Life.Text = Convert.ToString(Warrior.Life);
                        Magic.Text = Convert.ToString(Warrior.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 1)  //Archer
                    {
                        new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Archer.Damage);
                        Protection.Text = Convert.ToString(Archer.Protection);
                        MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                        Life.Text = Convert.ToString(Archer.Life);
                        Magic.Text = Convert.ToString(Archer.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                    {
                        new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Wizard.Damage);
                        Protection.Text = Convert.ToString(Wizard.Protection);
                        MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                        Life.Text = Convert.ToString(Wizard.Life);
                        Magic.Text = Convert.ToString(Wizard.Magic);
                    }
                }
                else
                {
                    MessageBox.Show("Free points are over");
                }
            }
        }

        private void decrease_endurance_Click(object sender, RoutedEventArgs e)  //уменьшение выносливости
        {
            if (NamePerson.Text == "New_Name")
            {
                MessageBox.Show("Choose or create a character");
            }
            else if (NamePerson.Text == Convert.ToString(WorkBase.GetList()))
            {
                if (free_glasses.Text != Convert.ToString(WorkBase.GetPersonag(ListPersonag.SelectedItem.ToString()).Points))
                {
                    Endurance.Text = Convert.ToString(Convert.ToInt32(Endurance.Text) - 1);
                    free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 1);
                    if (SelectPerson.SelectedIndex == 0)  // Warrior
                    {
                        new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Warrior.Damage);
                        Protection.Text = Convert.ToString(Warrior.Protection);
                        MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                        Life.Text = Convert.ToString(Warrior.Life);
                        Magic.Text = Convert.ToString(Warrior.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 1)  //Archer
                    {
                        new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Archer.Damage);
                        Protection.Text = Convert.ToString(Archer.Protection);
                        MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                        Life.Text = Convert.ToString(Archer.Life);
                        Magic.Text = Convert.ToString(Archer.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                    {
                        new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Wizard.Damage);
                        Protection.Text = Convert.ToString(Wizard.Protection);
                        MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                        Life.Text = Convert.ToString(Wizard.Life);
                        Magic.Text = Convert.ToString(Wizard.Magic);
                    }
                }
                else
                {
                    MessageBox.Show("Points distributed");
                }
            }
            else
            {
                if (free_glasses.Text != "10")
                {
                    Endurance.Text = Convert.ToString(Convert.ToInt32(Endurance.Text) - 1);
                    free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 1);
                    if (SelectPerson.SelectedIndex == 0)  // Warrior
                    {
                        new Warrior(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Warrior.Damage);
                        Protection.Text = Convert.ToString(Warrior.Protection);
                        MagicDamage.Text = Convert.ToString(Warrior.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Warrior.MagicProtection);
                        Life.Text = Convert.ToString(Warrior.Life);
                        Magic.Text = Convert.ToString(Warrior.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 1)  //Archer
                    {
                        new Archer(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Archer.Damage);
                        Protection.Text = Convert.ToString(Archer.Protection);
                        MagicDamage.Text = Convert.ToString(Archer.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Archer.MagicProtection);
                        Life.Text = Convert.ToString(Archer.Life);
                        Magic.Text = Convert.ToString(Archer.Magic);
                    }
                    else if (SelectPerson.SelectedIndex == 2)   //Wizzard
                    {
                        new Wizard(NamePerson.Text, SelectPerson.Text, Convert.ToInt32(Exp.Text), Convert.ToInt32(Level.Text), Convert.ToInt32(free_glasses.Text), Convert.ToInt32(Strength.Text), Convert.ToInt32(Dexterity.Text), Convert.ToInt32(Intelligence.Text), Convert.ToInt32(Endurance.Text));
                        Damage.Text = Convert.ToString(Wizard.Damage);
                        Protection.Text = Convert.ToString(Wizard.Protection);
                        MagicDamage.Text = Convert.ToString(Wizard.MagicDamage);
                        MagicProtection.Text = Convert.ToString(Wizard.MagicProtection);
                        Life.Text = Convert.ToString(Wizard.Life);
                        Magic.Text = Convert.ToString(Wizard.Magic);
                    }
                }
                else
                {
                    MessageBox.Show("Points distributed");
                }
            }
        }

        private void Exp1000_Click(object sender, RoutedEventArgs e) //опыт +1000
        {
            int exp1000 = (Convert.ToInt32(Exp.Text)) + 1000;
            if (exp1000 >0 & exp1000<=1000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "2";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 > 1000 & exp1000 < 3000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "3";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 >= 3000 & exp1000 < 6000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "4";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 >= 6000 & exp1000 < 10000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "5";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 >= 10000 & exp1000 < 15000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "6";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 >= 15000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "7";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
        }

        private void Exp3000_Click(object sender, RoutedEventArgs e) //опыт+3000
        {
            int exp1000 = (Convert.ToInt32(Exp.Text)) + 3000;
            if (exp1000 > 0 & exp1000 <= 1000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "2";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 > 1000 & exp1000 < 3000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "3";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 >= 3000 & exp1000 < 6000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "4";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 >= 6000 & exp1000 < 10000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "5";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 >= 10000 & exp1000 < 15000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "6";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 >= 15000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "7";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
        }

        private void Exp5000_Click(object sender, RoutedEventArgs e) //опыт+5000
        {

            int exp1000 = (Convert.ToInt32(Exp.Text)) + 5000;
            if (exp1000 > 0 & exp1000 <= 1000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "2";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 > 1000 & exp1000 < 3000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "3";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 >= 3000 & exp1000 < 6000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "4";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 >= 6000 & exp1000 < 10000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "5";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 >= 10000 & exp1000 < 15000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "6";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
            else if (exp1000 >= 15000)
            {
                Exp.Text = Convert.ToString(exp1000);
                Level.Text = "7";
                free_glasses.Text = Convert.ToString(Convert.ToInt32(free_glasses.Text) + 10);
            }
        }
    }
}
