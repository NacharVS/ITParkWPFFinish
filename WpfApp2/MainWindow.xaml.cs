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

namespace WpfApp2
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

        Archer archer = new Archer("Name", "Archer", 20, 30, 15, 20);
        Mage mage = new Mage("Name", "Mage", 15, 20, 35, 20);
        Warrior warrior = new Warrior("Name", "Warrior", 30, 15, 10, 25);
        private void Name_GotFocus(object sender, RoutedEventArgs e)
        {
            Name.Clear();
        }

        private void professions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (professions.SelectedIndex == 0)
            {
                ChosenProfession.Text = "Archer";
                Strength.Content = archer.CurrentStrength.ToString();
                Agility.Content = archer.CurrentAgility.ToString();
                Intelligence.Content = archer.CurrentIntelligence.ToString();
                Endurance.Content = archer.CurrentEndurance.ToString();
                physicDamage.Content = archer.PhysicDamage.ToString();//int.Parse(Strength.Content.ToString())*3 + int.Parse(Agility.Content.ToString()) * 7 + int.Parse(Intelligence.Content.ToString()) * 0 + int.Parse(Endurance.Content.ToString()) * 0;

            }

            if (professions.SelectedIndex == 1)
            {
                ChosenProfession.Text = "Mage";
                Strength.Content = mage.CurrentStrength.ToString(); ;
                Agility.Content = mage.CurrentAgility.ToString();
                Intelligence.Content = mage.CurrentIntelligence.ToString(); ;
                Endurance.Content = mage.CurrentEndurance.ToString();
            }
            if (professions.SelectedIndex == 2)
            {
                ChosenProfession.Text = "Warrior";
                Strength.Content = warrior.CurrentStrength.ToString(); ;
                Agility.Content = warrior.CurrentAgility.ToString();
                Intelligence.Content = warrior.CurrentIntelligence.ToString(); ;
                Endurance.Content = warrior.CurrentEndurance.ToString();
            }

        }
        public int click = 0;
        private void StrengthPointsPlus_Click(object sender, RoutedEventArgs e)
        {
            click++;

            if (ChosenProfession.Text == "Archer")
            {
                while (click > 0)
                {
                    Strength.Content = int.Parse(archer.CurrentStrength.ToString() + 1);
                }
            }

        }


        private void saveCharacter_Click(object sender, RoutedEventArgs e)
        {
            if (ChosenProfession.Text == "Archer")

            {
                MongoDB.AddToDataBase(new Archer(Name.Text, ChosenProfession.Text, double.Parse(Strength.Content.ToString()), double.Parse(Agility.Content.ToString()), double.Parse(Intelligence.Content.ToString()), double.Parse(Endurance.Content.ToString())));
                // MongoDB.ArcherAddToDB(Name.Text, ChosenProfession.Text, double.Parse(Strength.Content.ToString()), double.Parse(Agility.Content.ToString()), double.Parse(Intelligence.Content.ToString()), double.Parse(Endurance.Content.ToString()));
                savedСharacters.ItemsSource = MongoDB.ArcherGetList();
                MessageBox.Show($"Archer {Name.Text} was saved");
            }


            if (ChosenProfession.Text == "Mage")
            {
                MongoDB.AddToDataBase(new Mage(Name.Text, ChosenProfession.Text, double.Parse(Strength.Content.ToString()), double.Parse(Agility.Content.ToString()), double.Parse(Intelligence.Content.ToString()), double.Parse(Endurance.Content.ToString())));
                //MongoDB.MageAddToDB(Name.Text, ChosenProfession.Text, double.Parse(Strength.Content.ToString()), double.Parse(Agility.Content.ToString()), double.Parse(Intelligence.Content.ToString()), double.Parse(Endurance.Content.ToString()));
                savedСharacters.ItemsSource = MongoDB.MageGetList();
                MessageBox.Show($"Mage {Name.Text} was saved");
            }
            if (ChosenProfession.Text == "Warrior")
            {
                MongoDB.AddToDataBase(new Warrior(Name.Text, ChosenProfession.Text, double.Parse(Strength.Content.ToString()), double.Parse(Agility.Content.ToString()), double.Parse(Intelligence.Content.ToString()), double.Parse(Endurance.Content.ToString())));
                //MongoDB.MageAddToDB(Name.Text, ChosenProfession.Text, double.Parse(Strength.Content.ToString()), double.Parse(Agility.Content.ToString()), double.Parse(Intelligence.Content.ToString()), double.Parse(Endurance.Content.ToString()));
                savedСharacters.ItemsSource = MongoDB.WarriorGetList();
                MessageBox.Show($"Warrior {Name.Text} was saved");
            }

        }

        private void savedСharacters_Loaded(object sender, RoutedEventArgs e)
        {
            savedСharacters.ItemsSource = MongoDB.ArcherGetList();
            savedСharacters.ItemsSource = MongoDB.MageGetList();
            savedСharacters.ItemsSource = MongoDB.WarriorGetList();
        }

        private void savedСharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (savedСharacters.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                Name.Text = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).Name;
                ChosenProfession.Text = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).Proffesion;
                Strength.Content = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).CurrentStrength;
                Agility.Content = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).CurrentAgility;
                Intelligence.Content = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).CurrentIntelligence;
                Endurance.Content = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).CurrentEndurance;

            }
        }
    }
}
    

