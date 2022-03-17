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
                if (nameTextBox.Text==MongoDataBase.FindDuplicate("Test"))
                {
                    MessageBox.Show($"Character {nameTextBox.Text} already exist!");
                }
                else 
                {
                    MongoDataBase.AddWarriorToDB(nameTextBox.Text, professionComboBox.SelectionBoxItem.ToString()
                        , Convert.ToInt32(strAmountLabel.Content), Convert.ToInt32(agltAmountLabel.Content)
                        , Convert.ToInt32(intAmountLabel.Content), Convert.ToInt32(stmnAmountLabel.Content)
                        , Convert.ToInt32(levelAmountLabel.Content), Convert.ToInt64(experienseAmountLabel.Content)
                        , Convert.ToInt32(freePointAmountLabel.Content));
                    MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was created!");
                    characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
                }
            }
            else if (professionComboBox.SelectedIndex == 1)
            {
                if (nameTextBox.Text == MongoDataBase.FindDuplicate(nameTextBox.Text))
                {
                    MessageBox.Show($"Character {nameTextBox.Text} already exist!");
                }
                else
                {
                    MongoDataBase.AddArcherToDB(nameTextBox.Text, professionComboBox.SelectionBoxItem.ToString()
                    , Convert.ToInt32(strAmountLabel.Content), Convert.ToInt32(agltAmountLabel.Content)
                    , Convert.ToInt32(intAmountLabel.Content), Convert.ToInt32(stmnAmountLabel.Content)
                    , Convert.ToInt32(levelAmountLabel.Content), Convert.ToInt64(experienseAmountLabel.Content)
                    , Convert.ToInt32(freePointAmountLabel.Content));
                    MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was created!");
                    characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
                }
            }
            else if (professionComboBox.SelectedIndex == 2)
            {
                if (nameTextBox.Text == MongoDataBase.FindDuplicate(nameTextBox.Text))
                {
                    MessageBox.Show($"Character {nameTextBox.Text} already exist!");
                }
                else
                {
                    MongoDataBase.AddWizardToDB(nameTextBox.Text, professionComboBox.SelectionBoxItem.ToString()
                    , Convert.ToInt32(strAmountLabel.Content), Convert.ToInt32(agltAmountLabel.Content)
                    , Convert.ToInt32(intAmountLabel.Content), Convert.ToInt32(stmnAmountLabel.Content)
                    , Convert.ToInt32(levelAmountLabel.Content), Convert.ToInt64(experienseAmountLabel.Content)
                    , Convert.ToInt32(freePointAmountLabel.Content));
                    MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was created!");
                    characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
                }
            }
            else MessageBox.Show("Chose the profession of your character!");
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
            if (baseFreePoint < 10)
            {
                baseStr--;
                baseFreePoint++;
                strAmountLabel.Content = baseStr.ToString();
                freePointAmountLabel.Content = baseFreePoint.ToString();
                AddStatChange();
            }
            else
            {
                MessageBox.Show("Max free point!");
            }
        }

        private void agltRemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            int baseAglt = Convert.ToInt32(agltAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseFreePoint < 10)
            {
                baseAglt--;
                baseFreePoint++;
                agltAmountLabel.Content = baseAglt.ToString();
                freePointAmountLabel.Content = baseFreePoint.ToString();
                AddStatChange();
            }
            else
            {
                MessageBox.Show("Max free point!");
            }
        }

        private void intRemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            int baseInt = Convert.ToInt32(intAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseFreePoint < 10)
            {
                baseInt--;
                baseFreePoint++;
                intAmountLabel.Content = baseInt.ToString();
                freePointAmountLabel.Content = baseFreePoint.ToString();
                AddStatChange();
            }
            else
            {
                MessageBox.Show("Max free point!");
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

        public void WarriorStatChange()
        {
            strAmountLabel.Content = "30";
            agltAmountLabel.Content = "15";
            intAmountLabel.Content = "10";
            stmnAmountLabel.Content = "25";
        }
        public void ArcherStatChange()
        {
            strAmountLabel.Content = "20";
            agltAmountLabel.Content = "30";
            intAmountLabel.Content = "15";
            stmnAmountLabel.Content = "20";
        }
        public void WizardStatChange()
        {
            strAmountLabel.Content = "15";
            agltAmountLabel.Content = "20";
            intAmountLabel.Content = "35";
            stmnAmountLabel.Content = "20";
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
        public void StatChange()
        {
            if (professionComboBox.SelectedIndex == 0)
            {
                WarriorStatChange();
            }
            else if (professionComboBox.SelectedIndex == 1)
            {
                ArcherStatChange();
            }
            else if (professionComboBox.SelectedIndex == 2)
            {
                WizardStatChange();
            }
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
        private void BtnInActivate()
        {
            strRemoveBtn.IsEnabled = false;
            agltRemoveBtn.IsEnabled = false;
            intRemoveBtn.IsEnabled = false;
            stmnRemoveBtn.IsEnabled = false;
            strAddBtn.IsEnabled = false;
            agltAddBtn.IsEnabled = false;
            intAddBtn.IsEnabled = false;
            stmnAddBtn.IsEnabled = false;
            _1kExpBtn.IsEnabled = false;
            _3kExpBtn.IsEnabled = false;
            _5kExpBtn.IsEnabled = false;
        }
        private void BtnActivate()
        {
            strRemoveBtn.IsEnabled =    true;
            agltRemoveBtn.IsEnabled =   true;
            intRemoveBtn.IsEnabled =    true;
            stmnRemoveBtn.IsEnabled =   true;
            strAddBtn.IsEnabled =       true;
            agltAddBtn.IsEnabled =      true;
            intAddBtn.IsEnabled =       true;
            stmnAddBtn.IsEnabled =      true;
            _1kExpBtn.IsEnabled = true;
            _3kExpBtn.IsEnabled = true;
            _5kExpBtn.IsEnabled = true;
        }

        private void professionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StatChange();
            AddStatChange();
            BtnActivate();
        }

        private void updateListBtn_Click(object sender, RoutedEventArgs e)
        {
            MongoDataBase.DeleteAllCharacter();
            characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            AddStatChange();
            characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
            BtnInActivate();
        }
        public void LvlChange()
        {
            long currentExp = Convert.ToInt64(experienseAmountLabel.Content);
            int currentLvl = Convert.ToInt32(levelAmountLabel.Content);
            int currentFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            
            
            if (currentExp >= 1000 & currentExp < 3000)
            {
                currentLvl=2;
                currentFreePoint=15;
            }
            else if (currentExp >= 3000 & currentExp < 6000)
            {
                currentLvl=3;
                currentFreePoint= 20;
            }
            else if (currentExp >= 6000 & currentExp < 10000)
            {
                currentLvl=4;
                currentFreePoint= 25;
            }
            else if (currentExp >= 10000 & currentExp < 15000)
            {
                currentLvl=5;
                currentFreePoint = 30;
            }
            else if (currentExp >= 15000)
            {
                currentLvl=6;
                currentFreePoint= 35;
            }
            levelAmountLabel.Content=Convert.ToString(currentLvl);
            freePointAmountLabel.Content = Convert.ToString(currentFreePoint);
        }
        private void _1kExpBtn_Click(object sender, RoutedEventArgs e)
        {
            long baseValue = Convert.ToInt64(experienseAmountLabel.Content);
            long changedValue = 0;
            changedValue = 1000 + baseValue;
            experienseAmountLabel.Content=Convert.ToString(changedValue);
            LvlChange();
        }

        private void _3kExpBtn_Click(object sender, RoutedEventArgs e)
        {
            long baseValue = Convert.ToInt64(experienseAmountLabel.Content);
            long changedValue = 0;
            changedValue = 3000 + baseValue;
            experienseAmountLabel.Content = Convert.ToString(changedValue);
            LvlChange();
        }

        private void _5kExpBtn_Click(object sender, RoutedEventArgs e)
        {
            long baseValue = Convert.ToInt64(experienseAmountLabel.Content);
            long changedValue = 0;
            changedValue = 5000 + baseValue;
            experienseAmountLabel.Content = Convert.ToString(changedValue);
            LvlChange();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (professionComboBox.SelectedIndex == 0)
            {
                MongoDataBase.ReplaceWarrior (characterList.SelectedItem.ToString(), new Warrior(nameTextBox.Text, professionComboBox.SelectionBoxItem.ToString()
                    , Convert.ToInt32(strAmountLabel.Content), Convert.ToInt32(agltAmountLabel.Content)
                    , Convert.ToInt32(intAmountLabel.Content), Convert.ToInt32(stmnAmountLabel.Content)
                    , Convert.ToInt32(levelAmountLabel.Content), Convert.ToInt64(experienseAmountLabel.Content)
                    , Convert.ToInt32(freePointAmountLabel.Content)));
                MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was updated!");
                characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
            }
            else if (professionComboBox.SelectedIndex == 1)
            {
                MongoDataBase.ReplaceArcher(characterList.SelectedItem.ToString(), new Archer(nameTextBox.Text, professionComboBox.SelectionBoxItem.ToString()
                    , Convert.ToInt32(strAmountLabel.Content), Convert.ToInt32(agltAmountLabel.Content)
                    , Convert.ToInt32(intAmountLabel.Content), Convert.ToInt32(stmnAmountLabel.Content)
                    , Convert.ToInt32(levelAmountLabel.Content), Convert.ToInt64(experienseAmountLabel.Content)
                    , Convert.ToInt32(freePointAmountLabel.Content)));
                MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was updated!");
                characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
            }
            else if (professionComboBox.SelectedIndex == 2)
            {
                MongoDataBase.ReplaceWizard(characterList.SelectedItem.ToString(), new Wizard(nameTextBox.Text, professionComboBox.SelectionBoxItem.ToString()
                    , Convert.ToInt32(strAmountLabel.Content), Convert.ToInt32(agltAmountLabel.Content)
                    , Convert.ToInt32(intAmountLabel.Content), Convert.ToInt32(stmnAmountLabel.Content)
                    , Convert.ToInt32(levelAmountLabel.Content), Convert.ToInt64(experienseAmountLabel.Content)
                    , Convert.ToInt32(freePointAmountLabel.Content)));
                MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was updated!");
                characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
            }
            else MessageBox.Show("Chose the profession of your character!");
        }

        private void characterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (professionComboBox.SelectedIndex == -1)
            //{
            //    return;
            //}
            //else
            //{
            professionComboBox.IsEnabled = false;
            creationButton.IsEnabled = true;
            nameTextBox.Text = MongoDataBase.ShowWarriorInfo(characterList.SelectedItem.ToString()).Name;
                if (MongoDataBase.ShowWarriorInfo(characterList.SelectedItem.ToString()).Profession=="Warrior")
                    professionComboBox.SelectedIndex=0;
                else if (MongoDataBase.ShowWarriorInfo(characterList.SelectedItem.ToString()).Profession == "Archer")
                    professionComboBox.SelectedIndex = 1;
                else if (MongoDataBase.ShowWarriorInfo(characterList.SelectedItem.ToString()).Profession == "Wizard")
                    professionComboBox.SelectedIndex = 2;
                strAmountLabel.Content = MongoDataBase.ShowWarriorInfo(characterList.SelectedItem.ToString()).Strenght;
                agltAmountLabel.Content = MongoDataBase.ShowWarriorInfo(characterList.SelectedItem.ToString()).Agility;
                intAmountLabel.Content = MongoDataBase.ShowWarriorInfo(characterList.SelectedItem.ToString()).Intelligence;
                stmnAmountLabel.Content = MongoDataBase.ShowWarriorInfo(characterList.SelectedItem.ToString()).Stamina;
                levelAmountLabel.Content= MongoDataBase.ShowWarriorInfo(characterList.SelectedItem.ToString()).Level;
                experienseAmountLabel.Content= MongoDataBase.ShowWarriorInfo(characterList.SelectedItem.ToString()).Experiense;
            //}
        }

        private void creationButton_click(object sender, RoutedEventArgs e)
        {
            professionComboBox.IsEnabled = true;
            creationButton.IsEnabled = false;
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            MongoDataBase.RemoveCharacter(characterList.SelectedItem.ToString());
            MessageBox.Show($"Character {characterList.SelectedValue} was deleted from DB");
            characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
        }
    }
}
