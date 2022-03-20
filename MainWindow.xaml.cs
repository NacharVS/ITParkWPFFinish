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

        Сharacter character;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Indicators()
        {
            //switch (character.Proffession)
            //{
            //    case "Warrior":
            //        proffession.SelectedIndex = 1;
            //        break;

            //    case "Archer":
            //        proffession.SelectedIndex = 2;
            //        break;

            //    case "Wizard":
            //        proffession.SelectedIndex = 3;
            //        break;
            //    default:
            //        break;
            //}

            name.Text = character.Name;
            strength.Content = character.Strength;
            agility.Content = character.Agility;
            intelligence.Content = character.Intelligence;
            endurance.Content = character.Endurance;
            freePoints.Content = character.FreePoints;

            physicalDamage.Content = character.PhysicalDamage;
            physicalProtection.Content = character.PhysicalProtection;
            magicalDamage.Content = character.MagicalDamage;
            magicalProtection.Content = character.MagicalProtection;
            life.Content = character.Life;
            magic.Content = character.Magic;

            if (character.Strength == character.StrengthMin) removeStrength.IsEnabled = false;
            else removeStrength.IsEnabled = true;

            if (character.Strength == character.StrengthMax) addStrength.IsEnabled = false;
            else addStrength.IsEnabled = true;

            if (character.Agility == character.AgilityMin) removeAgility.IsEnabled = false;
            else removeAgility.IsEnabled = true;

            if (character.Agility == character.AgilityMax) addAgility.IsEnabled = false;
            else addAgility.IsEnabled = true;

            if (character.Intelligence == character.IntelligenceMin) removeIntelligence.IsEnabled = false;
            else removeIntelligence.IsEnabled = true;

            if (character.Intelligence == character.IntelligenceMax) addIntelligence.IsEnabled = false;
            else addIntelligence.IsEnabled = true;

            if (character.Endurance == character.EnduranceMin) removeEndurance.IsEnabled = false;
            else removeEndurance.IsEnabled = true;

            if (character.Endurance == character.EnduranceMax) addEndurance.IsEnabled = false;
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
            if (proffession.SelectedIndex == 1) character = new Warrior(name.Text, proffession.Text.ToString(), int.Parse(strength.Content.ToString()), int.Parse(agility.Content.ToString()), int.Parse(intelligence.Content.ToString()), int.Parse(endurance.Content.ToString()), int.Parse(freePoints.Content.ToString()));
            
            if (proffession.SelectedIndex == 2) character = new Archer(name.Text, proffession.Text.ToString(), int.Parse(strength.Content.ToString()), int.Parse(agility.Content.ToString()), int.Parse(intelligence.Content.ToString()), int.Parse(endurance.Content.ToString()), int.Parse(freePoints.Content.ToString()));
            
            if (proffession.SelectedIndex == 3) character = new Wizard(name.Text, proffession.Text.ToString(), int.Parse(strength.Content.ToString()), int.Parse(agility.Content.ToString()), int.Parse(intelligence.Content.ToString()), int.Parse(endurance.Content.ToString()), int.Parse(freePoints.Content.ToString()));

            MongoDBBase.SetWarrior(character);
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
                character = new Warrior(name.Text, proffession.Text.ToString(), 10);
                
                Indicators();

            }
            if (proffession.SelectedIndex == 2)
            {
                character = new Archer(name.Text, proffession.Text.ToString(), 10);

                Indicators();
            }
            if (proffession.SelectedIndex == 3)
            {
                character = new Wizard(name.Text, proffession.Text.ToString(), 10);

                Indicators();
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
                character = MongoDBBase.GetWarrior(listCharacter.SelectedItem.ToString());
                Indicators();
            }
        }

        private void removeStrength_Click(object sender, RoutedEventArgs e)
        {
            if (proffession.SelectedIndex != 0)
            {
                character.Strength -= 1;
                Indicators();
            }
            
        }

        private void addStrength_Click(object sender, RoutedEventArgs e)
        {
            if (proffession.SelectedIndex != 0)
            {
                character.Strength += 1;
                Indicators();
            }
            
        }

        private void removeAgility_Click(object sender, RoutedEventArgs e)
        {
            if (proffession.SelectedIndex != 0)
            {
                character.Agility -= 1;
                Indicators();
            }
            
        }

        private void addAgility_Click(object sender, RoutedEventArgs e)
        {
            if (proffession.SelectedIndex != 0)
            {
                character.Agility += 1;
                Indicators();
            }
            
        }

        private void removeIntelligence_Click(object sender, RoutedEventArgs e)
        {
            if (proffession.SelectedIndex != 0)
            {
                character.Intelligence -= 1;
                Indicators();
            }
            
        }

        private void addIntelligence_Click(object sender, RoutedEventArgs e)
        {
            if (proffession.SelectedIndex != 0)
            {
                character.Intelligence += 1;
                Indicators();
            }
            
        }

        private void removeEndurance_Click(object sender, RoutedEventArgs e)
        {
            if (proffession.SelectedIndex != 0)
            {
                character.Endurance -= 1;
                Indicators();
            }
            
        }

        private void addEndurance_Click(object sender, RoutedEventArgs e)
        {
            if (proffession.SelectedIndex != 0)
            {
                character.Endurance += 1;
                Indicators();
            }
            
        }

        private void weapon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
