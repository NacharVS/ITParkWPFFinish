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

namespace _2022_03_13_VerificationWork
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

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            Player.AddPlayerToDB(nameTextBox.Text, professionComboBox.SelectedItem.ToString()
                ,Convert.ToInt32(strAmountLabel.Content), Convert.ToInt32(dexAmountLabel.Content)
                ,Convert.ToInt32(intAmountLabel.Content), Convert.ToInt32(physicalDamageAmountLabel.Content)
                , Convert.ToInt32(physicalDefenseAmountLabel.Content), Convert.ToInt32(magicalDamageAmountLabel.Content)
                , Convert.ToInt32(magicalDefenseAmountLabel.Content), Convert.ToInt32(healthAmountLabel.Content)
                , Convert.ToInt32(manaAmountLabel.Content),Convert.ToInt32(levelAmountLabel.Content)
                , Convert.ToInt32(experienseAmountLabel.Content));
            MessageBox.Show($"Player \"{nameTextBox.Text}({professionComboBox.SelectionBoxItem})\" has added!");
        }

        private void strAddBtn_Click(object sender, RoutedEventArgs e)
        {
            int initialStr = Convert.ToInt32(strAmountLabel.Content);
            int initialFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (initialFreePoint != 0)
            {
                initialStr++;
                initialFreePoint--;
                strAmountLabel.Content = initialStr.ToString();
                freePointAmountLabel.Content = initialFreePoint.ToString();
            }
            else
            {
                MessageBox.Show("Free point is empty!");
            }
        }

        private void dexAddBtn_Click(object sender, RoutedEventArgs e)
        {
            int initialDex = Convert.ToInt32(dexAmountLabel.Content);
            int initialFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (initialFreePoint != 0)
            {
                initialDex++;
                initialFreePoint--;
                dexAmountLabel.Content = initialDex.ToString();
                freePointAmountLabel.Content = initialFreePoint.ToString();
            }
            else
            {
                MessageBox.Show("Free point is empty!");
            }
        }

        private void intAddBtn_Click(object sender, RoutedEventArgs e)
        {
            int initialInt = Convert.ToInt32(intAmountLabel.Content);
            int initialFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (initialFreePoint != 0)
            {
                initialInt++;
                initialFreePoint--;
                intAmountLabel.Content = initialInt.ToString();
                freePointAmountLabel.Content = initialFreePoint.ToString();
            }
            else
            {
                MessageBox.Show("Free point is empty!");
            }
        }

        private void endAddBtn_Click(object sender, RoutedEventArgs e)
        {
            int initialEnd = Convert.ToInt32(endAmountLabel.Content);
            int initialFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (initialFreePoint != 0)
            {
                initialEnd++;
                initialFreePoint--;
                endAmountLabel.Content = initialEnd.ToString();
                freePointAmountLabel.Content = initialFreePoint.ToString();
            }
            else
            {
                MessageBox.Show("Free point is empty!");
            }
        }
    }
}
