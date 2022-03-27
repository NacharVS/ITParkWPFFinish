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

namespace WPF_HOME_WORK
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {

            if (ListName.SelectedIndex == 0)
            {
                if (Enter_a_profession.Items.Contains(Enter_a_name.Text))
                {
                    MessageBox.Show($"Character {Enter_a_name.Text} already exist!");
                }
                else
                {
                    User.AddToDB(new Warrior(Enter_a_name.Text, Convert.ToInt32(lbl_power.Content)
                      , Convert.ToInt32(lbl_power.Content), Convert.ToInt32(lbl_power.Content)
                      , Convert.ToInt32(lbl_agility.Content), Convert.ToInt32(lbl_agility.Content)
                      , Convert.ToInt64(lbl_intellect.Content), Convert.ToInt32(lbl_intellect.Content)));
                    MessageBox.Show($"Character \"{Enter_a_name.Text} ({Enter_a_profession.SelectionBoxItem})\" was created!");
                    ListName.ItemsSource = User.ListName();
                }
            }
            else if (Enter_a_profession.SelectedIndex == 2)
            {
                if (ListName.Items.Contains(Enter_a_name.Text))
                {
                    MessageBox.Show($"Character {Enter_a_name.Text} already exist!");
                }
                else
                {
                    User.AddToDB(new Archer(Enter_a_name.Text, Convert.ToInt32(lbl_power.Content)
                       , Convert.ToInt32(lbl_power.Content), Convert.ToInt32(lbl_power.Content)
                       , Convert.ToInt32(lbl_agility.Content), Convert.ToInt32(lbl_agility.Content)
                       , Convert.ToInt64(lbl_intellect.Content), Convert.ToInt32(lbl_intellect.Content)));
                    MessageBox.Show($"Character \"{Enter_a_name.Text} ({Enter_a_profession.SelectionBoxItem})\" was created!");
                    ListName.ItemsSource = User.ListName();
                }
            }
            else if (Enter_a_profession.SelectedIndex == 1)
            {
                if (ListName.Items.Contains(Enter_a_name.Text))
                {
                    MessageBox.Show($"Character {Enter_a_name.Text} already exist!");
                }
                else
                {
                    User.AddToDB(new Mage(Enter_a_name.Text, Convert.ToInt32(lbl_power.Content)
                       , Convert.ToInt32(lbl_power.Content), Convert.ToInt32(lbl_power.Content)
                      , Convert.ToInt32(lbl_agility.Content), Convert.ToInt32(lbl_agility.Content)
                      , Convert.ToInt64(lbl_intellect.Content), Convert.ToInt32(lbl_intellect.Content)));
                    MessageBox.Show($"Character \"{Enter_a_name.Text} ({Enter_a_profession.SelectionBoxItem})\" was created!");
                    ListName.ItemsSource = User.ListName();
                }

                
            }
            else MessageBox.Show("Chose the profession of your character!");
        }

       

        
    }

}
