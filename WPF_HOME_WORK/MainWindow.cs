using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_HOME_WORK
{
    public partial class MainWindow : Window
    {
        string buffName = "Name";

        public object MongoDBBase { get; private set; }

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
            MongoDBBase.SetCharacter(Enter_a_name.Text, int.Parse(strength.Content.ToString()), int.Parse(agility.Content.ToString()), int.Parse(intelligence.Content.ToString()), int.Parse(endurance.Content.ToString())); ;
            ListName.ItemsSource = MongoDBBase.GetListCharacters();
            MessageBox.Show($"Character {name.Text} has added.");
        }
    }
}
