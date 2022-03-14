using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using WpfCharacterEditor.Class;

namespace WpfCharacterEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string buffName = "Name";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void name_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

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
            MongoDBBase.SetCharacter(name.Text, int.Parse(strength.Content.ToString()), int.Parse(agility.Content.ToString()), int.Parse(intelligence.Content.ToString()), int.Parse(endurance.Content.ToString())); ;
            listCharacter.ItemsSource = MongoDBBase.GetListCharacters();
            MessageBox.Show($"Character {name.Text} has added.");
        }

        
    }
}
