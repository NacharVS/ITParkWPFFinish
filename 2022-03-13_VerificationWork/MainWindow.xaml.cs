using _2022_03_13_VerificationWork.Interfaces;
using _2022_03_13_VerificationWork.MongoDB;
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
            if (professionComboBox.SelectedIndex == 0)
            {
                MongoDataBase.AddWarriorToDB(nameTextBox.Text, professionComboBox.SelectionBoxItem.ToString()
                    , Convert.ToInt32(strAmountLabel.Content), Convert.ToInt32(agltAmountLabel.Content)
                    , Convert.ToInt32(intAmountLabel.Content), Convert.ToInt32(stmnAmountLabel.Content)
                    , Convert.ToInt32(levelAmountLabel.Content), Convert.ToInt32(experienseAmountLabel.Content));
                MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was created!");
            }
            else if (professionComboBox.SelectedIndex == 1)
            {
                MongoDataBase.AddArcherToDB(nameTextBox.Text, professionComboBox.SelectionBoxItem.ToString()
                    , Convert.ToInt32(strAmountLabel.Content), Convert.ToInt32(agltAmountLabel.Content)
                    , Convert.ToInt32(intAmountLabel.Content), Convert.ToInt32(stmnAmountLabel.Content)
                    , Convert.ToInt32(levelAmountLabel.Content), Convert.ToInt32(experienseAmountLabel.Content));
                MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was created!");
            }
            else if (professionComboBox.SelectedIndex == 2)
            {
                MongoDataBase.AddWizardToDB(nameTextBox.Text, professionComboBox.SelectionBoxItem.ToString()
                    , Convert.ToInt32(strAmountLabel.Content), Convert.ToInt32(agltAmountLabel.Content)
                    , Convert.ToInt32(intAmountLabel.Content), Convert.ToInt32(stmnAmountLabel.Content)
                    , Convert.ToInt32(levelAmountLabel.Content), Convert.ToInt32(experienseAmountLabel.Content));
                MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was created!");
            }
        }

        private void strAddBtn_Click(object sender, RoutedEventArgs e)
        {
            int baseStr = Convert.ToInt32(strAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseFreePoint != 0)
            {
                baseStr++;
                baseFreePoint--;
                strAmountLabel.Content = baseStr.ToString();
                freePointAmountLabel.Content = baseFreePoint.ToString();
                AddStatChange();
            }
            else
            {
                MessageBox.Show("Free point is empty!");
            }
        }

        private void intAddBtn_Click(object sender, RoutedEventArgs e)
        {
            int baseInt = Convert.ToInt32(intAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseFreePoint != 0)
            {
                baseInt++;
                baseFreePoint--;
                intAmountLabel.Content = baseInt.ToString();
                freePointAmountLabel.Content = baseFreePoint.ToString();
                AddStatChange();
            }
            else
            {
                MessageBox.Show("Free point is empty!");
            }
        }

        private void stmnAddBtn_Click(object sender, RoutedEventArgs e)
        {
            int baseStmn = Convert.ToInt32(stmnAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseFreePoint != 0)
            {
                baseStmn++;
                baseFreePoint--;
                stmnAmountLabel.Content = baseStmn.ToString();
                freePointAmountLabel.Content = baseFreePoint.ToString();
                AddStatChange();
            }
            else
            {
                MessageBox.Show("Free point is empty!");
            }
        }

        private void agltAddBtn_Click(object sender, RoutedEventArgs e)
        {
            int baseAglt = Convert.ToInt32(agltAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseFreePoint != 0)
            {
                baseAglt++;
                baseFreePoint--;
                agltAmountLabel.Content = baseAglt.ToString();
                freePointAmountLabel.Content = baseFreePoint.ToString();
                AddStatChange();
            }
            else
            {
                MessageBox.Show("Free point is empty!");
            }
        }

        private void strRemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            int baseStr = Convert.ToInt32(strAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseStr > 10)
            {
                baseStr--;
                baseFreePoint++;
                strAmountLabel.Content = baseStr.ToString();
                freePointAmountLabel.Content = baseFreePoint.ToString();
                AddStatChange();
            }
            else
            {
                MessageBox.Show("Strenght don't be low a base (10) value!");
            }
        }

        private void agltRemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            int baseAglt = Convert.ToInt32(agltAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseAglt > 10)
            {
                baseAglt--;
                baseFreePoint++;
                agltAmountLabel.Content = baseAglt.ToString();
                freePointAmountLabel.Content = baseFreePoint.ToString();
                AddStatChange();
            }
            else
            {
                MessageBox.Show("Agility don't be low a base (10) value!");
            }
        }

        private void intRemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            int baseInt = Convert.ToInt32(intAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseInt > 10)
            {
                baseInt--;
                baseFreePoint++;
                intAmountLabel.Content = baseInt.ToString();
                freePointAmountLabel.Content = baseFreePoint.ToString();
                AddStatChange();
            }
            else
            {
                MessageBox.Show("Intelligence don't be low a base (10) value!");
            }
        }

        private void stmnRemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            int baseStmn = Convert.ToInt32(stmnAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseStmn > 10)
            {
                baseStmn--;
                baseFreePoint++;
                stmnAmountLabel.Content = baseStmn.ToString();
                freePointAmountLabel.Content = baseFreePoint.ToString();
                AddStatChange();
            }
            else
            {
                MessageBox.Show("Stamina don't be low a base (10) value!");
            }
        }

        private void nameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (nameTextBox.Text=="Name") nameTextBox.Clear();
            else return;
        }

        private void nameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (nameTextBox.Text == "") nameTextBox.Text = "Name";
            else return;
        }

        public void WarriorAddStatChange()
        {
            physicalDamageAmountLabel.Content = Convert.ToString(
                    7 * Convert.ToInt32(strAmountLabel.Content) +
                    2 * Convert.ToInt32(agltAmountLabel.Content) +
                    0 * Convert.ToInt32(intAmountLabel.Content) +
                    0 * Convert.ToInt32(stmnAmountLabel.Content)
                    );
            physicalDefenseAmountLabel.Content = Convert.ToString(
                2 * Convert.ToInt32(strAmountLabel.Content) +
                3 * Convert.ToInt32(agltAmountLabel.Content) +
                0 * Convert.ToInt32(intAmountLabel.Content) +
                3 * Convert.ToInt32(stmnAmountLabel.Content)
                );
            magicalDamageAmountLabel.Content = Convert.ToString(
                0 * Convert.ToInt32(strAmountLabel.Content) +
                0 * Convert.ToInt32(agltAmountLabel.Content) +
                1 * Convert.ToInt32(intAmountLabel.Content) +
                0 * Convert.ToInt32(stmnAmountLabel.Content)
                );
            magicalDefenseAmountLabel.Content = Convert.ToString(
                1 * Convert.ToInt32(strAmountLabel.Content) +
                0 * Convert.ToInt32(agltAmountLabel.Content) +
                2 * Convert.ToInt32(intAmountLabel.Content) +
                1 * Convert.ToInt32(stmnAmountLabel.Content)
                );
            healthAmountLabel.Content = Convert.ToString(
                5 * Convert.ToInt32(strAmountLabel.Content) +
                0 * Convert.ToInt32(agltAmountLabel.Content) +
                0 * Convert.ToInt32(intAmountLabel.Content) +
                10 * Convert.ToInt32(stmnAmountLabel.Content)
                );
            manaAmountLabel.Content = Convert.ToString(
                0 * Convert.ToInt32(strAmountLabel.Content) +
                0 * Convert.ToInt32(agltAmountLabel.Content) +
                1 * Convert.ToInt32(intAmountLabel.Content) +
                0 * Convert.ToInt32(stmnAmountLabel.Content)
                );
        }
        public void ArcherAddStatChange()
        {
            physicalDamageAmountLabel.Content = Convert.ToString(
                    3 * Convert.ToInt32(strAmountLabel.Content) +
                    7 * Convert.ToInt32(agltAmountLabel.Content) +
                    0 * Convert.ToInt32(intAmountLabel.Content) +
                    0 * Convert.ToInt32(stmnAmountLabel.Content)
                    );
            physicalDefenseAmountLabel.Content = Convert.ToString(
                1 * Convert.ToInt32(strAmountLabel.Content) +
                5 * Convert.ToInt32(agltAmountLabel.Content) +
                0 * Convert.ToInt32(intAmountLabel.Content) +
                2 * Convert.ToInt32(stmnAmountLabel.Content)
                );
            magicalDamageAmountLabel.Content = Convert.ToString(
                0 * Convert.ToInt32(strAmountLabel.Content) +
                0 * Convert.ToInt32(agltAmountLabel.Content) +
                3 * Convert.ToInt32(intAmountLabel.Content) +
                0 * Convert.ToInt32(stmnAmountLabel.Content)
                );
            magicalDefenseAmountLabel.Content = Convert.ToString(
                0 * Convert.ToInt32(strAmountLabel.Content) +
                3 * Convert.ToInt32(agltAmountLabel.Content) +
                3 * Convert.ToInt32(intAmountLabel.Content) +
                1 * Convert.ToInt32(stmnAmountLabel.Content)
                );
            healthAmountLabel.Content = Convert.ToString(
                2 * Convert.ToInt32(strAmountLabel.Content) +
                0 * Convert.ToInt32(agltAmountLabel.Content) +
                0 * Convert.ToInt32(intAmountLabel.Content) +
                5 * Convert.ToInt32(stmnAmountLabel.Content)
                );
            manaAmountLabel.Content = Convert.ToString(
                0 * Convert.ToInt32(strAmountLabel.Content) +
                0 * Convert.ToInt32(agltAmountLabel.Content) +
                1 * Convert.ToInt32(intAmountLabel.Content) +
                0 * Convert.ToInt32(stmnAmountLabel.Content)
                );
        }
        public void WizardAddStatChange()
        {
            physicalDamageAmountLabel.Content = Convert.ToString(
                    1 * Convert.ToInt32(strAmountLabel.Content) +
                    1 * Convert.ToInt32(agltAmountLabel.Content) +
                    0 * Convert.ToInt32(intAmountLabel.Content) +
                    0 * Convert.ToInt32(stmnAmountLabel.Content)
                    );
            physicalDefenseAmountLabel.Content = Convert.ToString(
                1 * Convert.ToInt32(strAmountLabel.Content) +
                1 * Convert.ToInt32(agltAmountLabel.Content) +
                1 * Convert.ToInt32(intAmountLabel.Content) +
                2 * Convert.ToInt32(stmnAmountLabel.Content)
                );
            magicalDamageAmountLabel.Content = Convert.ToString(
                0 * Convert.ToInt32(strAmountLabel.Content) +
                0 * Convert.ToInt32(agltAmountLabel.Content) +
                7 * Convert.ToInt32(intAmountLabel.Content) +
                0 * Convert.ToInt32(stmnAmountLabel.Content)
                );
            magicalDefenseAmountLabel.Content = Convert.ToString(
                0 * Convert.ToInt32(strAmountLabel.Content) +
                0 * Convert.ToInt32(agltAmountLabel.Content) +
                5 * Convert.ToInt32(intAmountLabel.Content) +
                1 * Convert.ToInt32(stmnAmountLabel.Content)
                );
            healthAmountLabel.Content = Convert.ToString(
                1 * Convert.ToInt32(strAmountLabel.Content) +
                0 * Convert.ToInt32(agltAmountLabel.Content) +
                0 * Convert.ToInt32(intAmountLabel.Content) +
                3 * Convert.ToInt32(stmnAmountLabel.Content)
                );
            manaAmountLabel.Content = Convert.ToString(
                0 * Convert.ToInt32(strAmountLabel.Content) +
                0 * Convert.ToInt32(agltAmountLabel.Content) +
                2 * Convert.ToInt32(intAmountLabel.Content) +
                0 * Convert.ToInt32(stmnAmountLabel.Content)
                );
        }
        public void AddStatChange()
        {
            if (professionComboBox.SelectedIndex == 0)
            {
                WarriorAddStatChange();
            }
            else if (professionComboBox.SelectedIndex == 1)
            {
                ArcherAddStatChange();
            }
            else if (professionComboBox.SelectedIndex == 2)
            {
                WizardAddStatChange();
            }
        }
        private void Window_Activated(object sender, EventArgs e)
        {
            AddStatChange();
            
        }

        private void professionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddStatChange();
        }

        private void updateListBtn_Click(object sender, RoutedEventArgs e)
        {
            characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
        }
    }
}
