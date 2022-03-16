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
using WpfCharacterEditor.Class;

namespace WpfCharacterEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string buffName = "Name";
        int[] сharacteristics = new int[4] { 10, 10, 10, 10 };
        ICharacter warrior;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Indicators()
        {
            name.Text = warrior.Name;
            //proffession.ItemsSource = warrior.Proffession;
            strength.Content = warrior.Strength;
            agility.Content = warrior.Agility;
            intelligence.Content = warrior.Intelligence;
            endurance.Content = warrior.Endurance;
            freePoints.Content = warrior.FreePoints;

            physicalDamage.Content = warrior.PhysicalDamage;
            physicalProtection.Content = warrior.PhysicalProtection;
            magicalDamage.Content = warrior.MagicalDamage;
            magicalProtection.Content = warrior.MagicalProtection;
            life.Content = warrior.Life;
            magic.Content = warrior.Magic;

            if (warrior.Strength == warrior.StrengthMin) removeStrength.IsEnabled = false;
            else removeStrength.IsEnabled = true;

            if (warrior.Strength == warrior.StrengthMax) addStrength.IsEnabled = false;
            else addStrength.IsEnabled = true;

            if (warrior.Agility == warrior.AgilityMin) removeAgility.IsEnabled = false;
            else removeAgility.IsEnabled = true;

            if (warrior.Agility == warrior.AgilityMax) addAgility.IsEnabled = false;
            else addAgility.IsEnabled = true;

            if (warrior.Intelligence == warrior.IntelligenceMin) removeIntelligence.IsEnabled = false;
            else removeIntelligence.IsEnabled = true;

            if (warrior.Intelligence == warrior.IntelligenceMax) addIntelligence.IsEnabled = false;
            else addIntelligence.IsEnabled = true;

            if (warrior.Endurance == warrior.EnduranceMin) removeEndurance.IsEnabled = false;
            else removeEndurance.IsEnabled = true;

            if (warrior.Endurance == warrior.EnduranceMax) addEndurance.IsEnabled = false;
            else addEndurance.IsEnabled = true;
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            buffName = name.Text;
        }

        private void name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (buffName != "Name")
            {
                return;
            }
            else
                name.Clear();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            //Warrior warrior = new Warrior(name.Text, proffession.Text.ToString(), int.Parse(strength.Content.ToString()), int.Parse(agility.Content.ToString()), int.Parse(intelligence.Content.ToString()), int.Parse(endurance.Content.ToString()));
            MongoDBBase.SetWarrior(warrior);
            listCharacter.ItemsSource = MongoDBBase.GetListWarriors();
            MessageBox.Show($"Character {name.Text} has added.");
        }

        private void proffession_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (proffession.SelectedIndex == 0)
            {
                return;
            }
            if (proffession.SelectedIndex == 1)
            {
                warrior = new Warrior(name.Text, proffession.Text.ToString(), 30, 15, 10, 25, 10);
                
                сharacteristics[0] = warrior.Strength;
                сharacteristics[1] = warrior.Agility;
                сharacteristics[2] = warrior.Intelligence;
                сharacteristics[3] = warrior.Endurance;

                strength.Content = сharacteristics[0];
                agility.Content = сharacteristics[1];
                intelligence.Content = сharacteristics[2];
                endurance.Content = сharacteristics[3];

                Indicators();

            }
            if (proffession.SelectedIndex == 2)
            {

            }
            if (proffession.SelectedIndex == 3)
            {

            }
        }

        private void listCharacter_Loaded(object sender, RoutedEventArgs e)
        {
            listCharacter.ItemsSource = MongoDBBase.GetListWarriors();
        }

        private void listCharacter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listCharacter.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                warrior = MongoDBBase.GetWarrior(listCharacter.SelectedItem.ToString());
                Indicators();
                //name.Text = warrior.Name;
                //proffession.ItemsSource = warrior.Proffession;
                //strength.Content = warrior.Strength;
                //agility.Content = warrior.Agility;
                //intelligence.Content = warrior.Intelligence;
                //endurance.Content = warrior.Endurance;
                //physicalDamage.Content = warrior.PhysicalDamage;
                //physicalProtection.Content = warrior.PhysicalProtection;
                //magicalDamage.Content = warrior.MagicalDamage;
                //magicalProtection.Content = warrior.MagicalProtection;
                //life.Content = warrior.Life;
                //magic.Content = warrior.Magic;

            }
        }

        private void removeStrength_Click(object sender, RoutedEventArgs e)
        {
            warrior.Strength -= 1;
            Indicators();
        }

        private void addStrength_Click(object sender, RoutedEventArgs e)
        {
            warrior.Strength += 1;
            Indicators();
        }

        private void removeAgility_Click(object sender, RoutedEventArgs e)
        {
            warrior.Agility -= 1;
            Indicators();
        }

        private void addAgility_Click(object sender, RoutedEventArgs e)
        {
            warrior.Agility += 1;
            Indicators();
        }

        private void removeIntelligence_Click(object sender, RoutedEventArgs e)
        {
            warrior.Intelligence -= 1;
            Indicators();
        }

        private void addIntelligence_Click(object sender, RoutedEventArgs e)
        {
            warrior.Intelligence += 1;
            Indicators();
        }

        private void removeEndurance_Click(object sender, RoutedEventArgs e)
        {
            warrior.Endurance -= 1;
            Indicators();
        }

        private void addEndurance_Click(object sender, RoutedEventArgs e)
        {
            warrior.Endurance += 1;
            Indicators();
        }
    }
}
