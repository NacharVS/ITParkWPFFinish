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
        
        public MainWindow()
        {
            InitializeComponent();
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
            Warrior warrior = new Warrior(name.Text, proffession.Text.ToString(), int.Parse(strength.Content.ToString()), int.Parse(agility.Content.ToString()), int.Parse(intelligence.Content.ToString()), int.Parse(endurance.Content.ToString()));
            MongoDBBase.SetWarrior(warrior);
            listCharacter.ItemsSource = MongoDBBase.GetListWarriors();
            MessageBox.Show($"Character {name.Text} has added.");
        }

        private void proffession_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
                Warrior warrior = MongoDBBase.GetWarrior(listCharacter.SelectedItem.ToString());

                name.Text = warrior.Name;
                proffession.SelectedItem = warrior.Proffession;
                strength.Content = warrior.Strength;
                agility.Content = warrior.Agility;
                intelligence.Content = warrior.Intelligence;
                endurance.Content = warrior.Endurance;
                physicalDamage.Content = warrior.PhysicalDamage;
                physicalProtection.Content = warrior.PhysicalProtection;
                magicalDamage.Content = warrior.MagicalDamage;
                magicalProtection.Content = warrior.MagicalProtection;
                life.Content = warrior.Life;
                magic.Content = warrior.Magic;

            }
        }
    }
}
