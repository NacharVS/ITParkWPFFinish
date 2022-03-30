using _2022_03_13_VerificationWork.Interfaces;
using _2022_03_13_VerificationWork.MongoDB;
using MongoDB.Bson.Serialization;
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
                if (characterList.Items.Contains(nameTextBox.Text))
                {
                    MessageBox.Show($"Character {nameTextBox.Text} already exist!");
                }
                else
                {
                    MongoDataBase.AddCharacterToDB(new Warrior(nameTextBox.Text, Convert.ToInt32(strAmountLabel.Content)
                      , Convert.ToInt32(agltAmountLabel.Content), Convert.ToInt32(intAmountLabel.Content)
                      , Convert.ToInt32(stmnAmountLabel.Content), Convert.ToInt32(levelAmountLabel.Content)
                      , Convert.ToInt64(experienseAmountLabel.Content), Convert.ToInt32(freePointAmountLabel.Content)));
                    MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was created!");
                    characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
                }
            }
            else if (professionComboBox.SelectedIndex == 1)
            {
                if (characterList.Items.Contains(nameTextBox.Text))
                {
                    MessageBox.Show($"Character {nameTextBox.Text} already exist!");
                }
                else
                {
                    MongoDataBase.AddCharacterToDB(new Archer(nameTextBox.Text, Convert.ToInt32(strAmountLabel.Content)
                      , Convert.ToInt32(agltAmountLabel.Content), Convert.ToInt32(intAmountLabel.Content)
                      , Convert.ToInt32(stmnAmountLabel.Content), Convert.ToInt32(levelAmountLabel.Content)
                      , Convert.ToInt64(experienseAmountLabel.Content), Convert.ToInt32(freePointAmountLabel.Content)));
                    MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was created!");
                    characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
                }
            }
            else if (professionComboBox.SelectedIndex == 2)
            {
                if (characterList.Items.Contains(nameTextBox.Text))
                {
                    MessageBox.Show($"Character {nameTextBox.Text} already exist!");
                }
                else
                {
                    MongoDataBase.AddCharacterToDB(new Mage(nameTextBox.Text, Convert.ToInt32(strAmountLabel.Content)
                      , Convert.ToInt32(agltAmountLabel.Content), Convert.ToInt32(intAmountLabel.Content)
                      , Convert.ToInt32(stmnAmountLabel.Content), Convert.ToInt32(levelAmountLabel.Content)
                      , Convert.ToInt64(experienseAmountLabel.Content), Convert.ToInt32(freePointAmountLabel.Content)));
                    MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was created!");
                    characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
                }
            }
            else MessageBox.Show("Chose the profession of your character!");
        }
        private void strAddBtn_Click(object sender, RoutedEventArgs e)
        {
            int currentStr = Convert.ToInt32(strAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseFreePoint != 0)
            {
                if (professionComboBox.SelectedIndex == 0)
                {
                    if (currentStr < Warrior.maxStr)
                    {
                        currentStr++;
                        baseFreePoint--;
                        strAmountLabel.Content = currentStr.ToString();
                        freePointAmountLabel.Content = baseFreePoint.ToString();
                        AddStatChange();
                    }
                    else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s strength must not be more than {Warrior.maxStr}" +
                        $" points!");
                }
                if (professionComboBox.SelectedIndex == 1)
                {
                    if (currentStr < Archer.maxStr)
                    {
                        currentStr++;
                        baseFreePoint--;
                        strAmountLabel.Content = currentStr.ToString();
                        freePointAmountLabel.Content = baseFreePoint.ToString();
                        AddStatChange();
                    }
                    else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s strength must not be more than {Archer.maxStr}" +
                        $" points!");
                }
                if (professionComboBox.SelectedIndex == 2)
                {
                    if (currentStr < Mage.maxStr)
                    {
                        currentStr++;
                        baseFreePoint--;
                        strAmountLabel.Content = currentStr.ToString();
                        freePointAmountLabel.Content = baseFreePoint.ToString();
                        AddStatChange();
                    }
                    else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s strength must not be more than {Mage.maxStr}" +
                        $" points!");
                }
            }
            else MessageBox.Show("Free point is empty!");
        }
        private void agltAddBtn_Click(object sender, RoutedEventArgs e)
        {
            int currentAglt = Convert.ToInt32(agltAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseFreePoint != 0)
            {
                if (professionComboBox.SelectedIndex == 0)
                {
                    if (currentAglt < Warrior.maxAglt)
                    {
                        currentAglt++;
                        baseFreePoint--;
                        agltAmountLabel.Content = currentAglt.ToString();
                        freePointAmountLabel.Content = baseFreePoint.ToString();
                        AddStatChange();
                    }
                    else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s agility must not be more than {Warrior.maxAglt}" +
                        $" points!");
                }
                if (professionComboBox.SelectedIndex == 1)
                {
                    if (currentAglt < Archer.maxAglt)
                    {
                        currentAglt++;
                        baseFreePoint--;
                        agltAmountLabel.Content = currentAglt.ToString();
                        freePointAmountLabel.Content = baseFreePoint.ToString();
                        AddStatChange();
                    }
                    else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s agility must not be more than {Archer.maxAglt}" +
                        $" points!");
                }
                if (professionComboBox.SelectedIndex == 2)
                {
                    if (currentAglt < Mage.maxAglt)
                    {
                        currentAglt++;
                        baseFreePoint--;
                        agltAmountLabel.Content = currentAglt.ToString();
                        freePointAmountLabel.Content = baseFreePoint.ToString();
                        AddStatChange();
                    }
                    else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s agility must not be more than {Mage.maxAglt}" +
                        $" points!");
                }
            }
            else MessageBox.Show("Free point is empty!");
        }
        private void intAddBtn_Click(object sender, RoutedEventArgs e)
        {
            int currentInt = Convert.ToInt32(intAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseFreePoint != 0)
            {
                if (professionComboBox.SelectedIndex == 0)
                {
                    if (currentInt < Warrior.maxInt)
                    {
                        currentInt++;
                        baseFreePoint--;
                        intAmountLabel.Content = currentInt.ToString();
                        freePointAmountLabel.Content = baseFreePoint.ToString();
                        AddStatChange();
                    }
                    else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s intelligence must not be more than {Warrior.maxInt}" +
                        $" points!");
                }
                if (professionComboBox.SelectedIndex == 1)
                {
                    if (currentInt < Archer.maxInt)
                    {
                        currentInt++;
                        baseFreePoint--;
                        intAmountLabel.Content = currentInt.ToString();
                        freePointAmountLabel.Content = baseFreePoint.ToString();
                        AddStatChange();
                    }
                    else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s intelligence must not be more than {Archer.maxInt}" +
                        $" points!");
                }
                if (professionComboBox.SelectedIndex == 2)
                {
                    if (currentInt < Mage.maxInt)
                    {
                        currentInt++;
                        baseFreePoint--;
                        intAmountLabel.Content = currentInt.ToString();
                        freePointAmountLabel.Content = baseFreePoint.ToString();
                        AddStatChange();
                    }
                    else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s intelligence must not be more than {Mage.maxInt}" +
                        $" points!");
                }
            }
            else MessageBox.Show("Free point is empty!");
        }
        private void stmnAddBtn_Click(object sender, RoutedEventArgs e)
        {
            int currentStmn = Convert.ToInt32(stmnAmountLabel.Content);
            int baseFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (baseFreePoint != 0)
            {
                if (professionComboBox.SelectedIndex == 0)
                {
                    if (currentStmn < Warrior.maxStmn)
                    {
                        currentStmn++;
                        baseFreePoint--;
                        stmnAmountLabel.Content = currentStmn.ToString();
                        freePointAmountLabel.Content = baseFreePoint.ToString();
                        AddStatChange();
                    }
                    else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s stamina must not be more than {Warrior.maxStmn}" +
                        $" points!");
                }
                if (professionComboBox.SelectedIndex == 1)
                {
                    if (currentStmn < Archer.maxStmn)
                    {
                        currentStmn++;
                        baseFreePoint--;
                        stmnAmountLabel.Content = currentStmn.ToString();
                        freePointAmountLabel.Content = baseFreePoint.ToString();
                        AddStatChange();
                    }
                    else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s stamina must not be more than {Archer.maxStmn}" +
                        $" points!");
                }
                if (professionComboBox.SelectedIndex == 2)
                {
                    if (currentStmn < Mage.maxStr)
                    {
                        currentStmn++;
                        baseFreePoint--;
                        stmnAmountLabel.Content = currentStmn.ToString();
                        freePointAmountLabel.Content = baseFreePoint.ToString();
                        AddStatChange();
                    }
                    else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s stamina must not be more than {Mage.maxStmn}" +
                        $" points!");
                }
            }
            else
            {
                MessageBox.Show("Free point is empty!");
            }
        }

        private void strRemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            int currentStr = Convert.ToInt32(strAmountLabel.Content);
            int currentFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            //int mustFreePoint = Convert.ToInt32(levelAmountLabel.Content) * 5 - 5 + 10;
            if (professionComboBox.SelectedIndex == 0)
            {
                if (currentStr > Warrior.minStr)
                {
                    currentStr--;
                    currentFreePoint++;
                    strAmountLabel.Content = currentStr.ToString();
                    freePointAmountLabel.Content = currentFreePoint.ToString();
                    AddStatChange();
                }
                else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s strength must not be less than {Warrior.minStr}" +
                    $" points!");
            }
            if (professionComboBox.SelectedIndex == 1)
            {
                if (currentStr > Archer.minStr)
                {
                    currentStr--;
                    currentFreePoint++;
                    strAmountLabel.Content = currentStr.ToString();
                    freePointAmountLabel.Content = currentFreePoint.ToString();
                    AddStatChange();
                }
                else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s strength must not be less than {Archer.minStr}" +
                    $" points!");
            }
            if (professionComboBox.SelectedIndex == 2)
            {
                if (currentStr > Mage.minStr)
                {
                    currentStr--;
                    currentFreePoint++;
                    strAmountLabel.Content = currentStr.ToString();
                    freePointAmountLabel.Content = currentFreePoint.ToString();
                    AddStatChange();
                }
                else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s strength must not be less than {Mage.minStr}" +
                    $" points!");
            }
        }

        private void agltRemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            int currentAglt = Convert.ToInt32(agltAmountLabel.Content);
            int currentFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            //int mustFreePoint = Convert.ToInt32(levelAmountLabel.Content) * 5 - 5 + 10;
            if (professionComboBox.SelectedIndex == 0)
            {
                if (currentAglt > Warrior.minAglt)
                {
                    currentAglt--;
                    currentFreePoint++;
                    agltAmountLabel.Content = currentAglt.ToString();
                    freePointAmountLabel.Content = currentFreePoint.ToString();
                    AddStatChange();
                }
                else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s agility must not be less than {Warrior.minAglt}" +
                    $" points!");
            }
            if (professionComboBox.SelectedIndex == 1)
            {
                if (currentAglt > Archer.minAglt)
                {
                    currentAglt--;
                    currentFreePoint++;
                    agltAmountLabel.Content = currentAglt.ToString();
                    freePointAmountLabel.Content = currentFreePoint.ToString();
                    AddStatChange();
                }
                else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s agility must not be less than {Archer.minAglt}" +
                    $" points!");
            }
            if (professionComboBox.SelectedIndex == 2)
            {
                if (currentAglt > Mage.minAglt)
                {
                    currentAglt--;
                    currentFreePoint++;
                    agltAmountLabel.Content = currentAglt.ToString();
                    freePointAmountLabel.Content = currentFreePoint.ToString();
                    AddStatChange();
                }
                else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s agility must not be less than {Mage.minAglt}" +
                    $" points!");
            }
        }

        private void intRemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            int currentInt = Convert.ToInt32(intAmountLabel.Content);
            int currentFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            //int mustFreePoint = Convert.ToInt32(levelAmountLabel.Content) * 5 - 5 + 10;
            if (professionComboBox.SelectedIndex == 0)
            {
                if (currentInt > Warrior.minInt)
                {
                    currentInt--;
                    currentFreePoint++;
                    intAmountLabel.Content = currentInt.ToString();
                    freePointAmountLabel.Content = currentFreePoint.ToString();
                    AddStatChange();
                }
                else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s intelligence must not be less than {Warrior.minInt}" +
                    $" points!");
            }
            if (professionComboBox.SelectedIndex == 1)
            {
                if (currentInt > Archer.minInt)
                {
                    currentInt--;
                    currentFreePoint++;
                    intAmountLabel.Content = currentInt.ToString();
                    freePointAmountLabel.Content = currentFreePoint.ToString();
                    AddStatChange();
                }
                else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s intelligence must not be less than {Archer.minInt}" +
                    $" points!");
            }
            if (professionComboBox.SelectedIndex == 2)
            {
                if (currentInt > Mage.minInt)
                {
                    currentInt--;
                    currentFreePoint++;
                    intAmountLabel.Content = currentInt.ToString();
                    freePointAmountLabel.Content = currentFreePoint.ToString();
                    AddStatChange();
                }
                else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s intelligence must not be less than {Mage.minInt}" +
                    $" points!");
            }
        }
        public void stmnRemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            int currentStmn = Convert.ToInt32(stmnAmountLabel.Content);
            int currentFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            //int mustFreePoint = Convert.ToInt32(levelAmountLabel.Content) * 5 - 5 + 10;
            if (professionComboBox.SelectedIndex == 0)
            {
                if (currentStmn > Warrior.minStmn)
                {
                    currentStmn--;
                    currentFreePoint++;
                    stmnAmountLabel.Content = currentStmn.ToString();
                    freePointAmountLabel.Content = currentFreePoint.ToString();
                    AddStatChange();
                }
                else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s stamina must not be less than {Warrior.minStmn}" +
                    $" points!");
            }
            if (professionComboBox.SelectedIndex == 1)
            {
                if (currentStmn > Archer.minStmn)
                {
                    currentStmn--;
                    currentFreePoint++;
                    stmnAmountLabel.Content = currentStmn.ToString();
                    freePointAmountLabel.Content = currentFreePoint.ToString();
                    AddStatChange();
                }
                else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s stamina must not be less than {Archer.minStmn}" +
                    $" points!");
            }
            if (professionComboBox.SelectedIndex == 2)
            {
                if (currentStmn > Mage.minStmn)
                {
                    currentStmn--;
                    currentFreePoint++;
                    stmnAmountLabel.Content = currentStmn.ToString();
                    freePointAmountLabel.Content = currentFreePoint.ToString();
                    AddStatChange();
                }
                else MessageBox.Show($"{professionComboBox.SelectionBoxItem}'s stamina must not be less than {Mage.minStmn}" +
                    $" points!");
            }
        }

        private void nameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (nameTextBox.Text == "Name") nameTextBox.Clear();
            else return;
        }

        private void nameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (nameTextBox.Text == "") nameTextBox.Text = "Name";
            else return;
        }

        public void WarriorStatChange()
        {
            strAmountLabel.Content = Warrior.minStr.ToString();
            agltAmountLabel.Content = Warrior.minAglt.ToString();
            intAmountLabel.Content = Warrior.minInt.ToString();
            stmnAmountLabel.Content = Warrior.minStmn.ToString();
            freePointAmountLabel.Content = "10";
            levelAmountLabel.Content = "1";
            experienseAmountLabel.Content = "0";
        }
        public void ArcherStatChange()
        {
            strAmountLabel.Content = "20";
            agltAmountLabel.Content = "30";
            intAmountLabel.Content = "15";
            stmnAmountLabel.Content = "20";
            freePointAmountLabel.Content = "10";
            levelAmountLabel.Content = "1";
            experienseAmountLabel.Content = "0";
        }
        public void WizardStatChange()
        {
            strAmountLabel.Content = "15";
            agltAmountLabel.Content = "20";
            intAmountLabel.Content = "35";
            stmnAmountLabel.Content = "20";
            freePointAmountLabel.Content = "10";
            levelAmountLabel.Content = "1";
            experienseAmountLabel.Content = "0";
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
            strRemoveBtn.IsEnabled = true;
            agltRemoveBtn.IsEnabled = true;
            intRemoveBtn.IsEnabled = true;
            stmnRemoveBtn.IsEnabled = true;
            strAddBtn.IsEnabled = true;
            agltAddBtn.IsEnabled = true;
            intAddBtn.IsEnabled = true;
            stmnAddBtn.IsEnabled = true;
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
            BsonClassMap.RegisterClassMap<Warrior>();
            BsonClassMap.RegisterClassMap<Archer>();
            BsonClassMap.RegisterClassMap<Mage>();
        }
        public void LvlChange()
        {
            long currentExp = Convert.ToInt64(experienseAmountLabel.Content);
            int currentLvl = Convert.ToInt32(levelAmountLabel.Content);
            int currentFreePoint = Convert.ToInt32(freePointAmountLabel.Content);
            if (currentExp >= 1000 & currentExp < 3000)
            {
                if (currentLvl != 2)
                {
                    currentLvl=2;
                    currentFreePoint += 5;
                }
            }
            else if (currentExp >= 3000 & currentExp < 6000)
            {
                if (currentLvl != 3)
                {
                    currentLvl=3;
                    currentFreePoint += 5;
                }
            }
            else if (currentExp >= 6000 & currentExp < 10000)
            {
                if (currentLvl != 4)
                {
                    currentLvl=4;
                    currentFreePoint += 5;
                }
            }
            else if (currentExp >= 10000 & currentExp < 15000)
            {
                if (currentLvl != 5)
                {
                    currentLvl=5;
                    currentFreePoint += 5;
                }
            }
            else if (currentExp >= 15000 & currentExp < 21000)
            {
                if (currentLvl != 6)
                {
                    currentLvl=6;
                    currentFreePoint += 5;
                }
            }
            else if (currentExp >= 21000 & currentExp < 28000)
            {
                if (currentLvl != 7)
                {
                    currentLvl=7;
                    currentFreePoint += 5;
                }
            }
            else if (currentExp >= 28000 & currentExp < 36000)
            {
                if (currentLvl != 8)
                {
                    currentLvl=8;
                    currentFreePoint += 5;
                }
            }
            else if (currentExp == 36000)
            {
                if (currentLvl != 9)
                {
                    currentLvl=9;
                    currentFreePoint += 5;
                }
            }
            levelAmountLabel.Content = Convert.ToString(currentLvl);
            freePointAmountLabel.Content = Convert.ToString(currentFreePoint);
        }
        private void _1kExpBtn_Click(object sender, RoutedEventArgs e)
        {
            long baseValue = Convert.ToInt64(experienseAmountLabel.Content);
            long changedValue = 1000 + baseValue;
            int currentLvl = Convert.ToInt32(levelAmountLabel.Content);
            int lvlMust=1;
            if (changedValue > 36000)
            {
                experienseAmountLabel.Content = "36000";
                MessageBox.Show("Max level!");
            }
            else
            {
                for (int i = 0; i < baseValue; i++)
                {
                    if (i == 1000 & currentLvl != 2)
                    {
                        lvlMust = 2;
                        levelAmountLabel.Content = lvlMust.ToString();
                    }
                    else if (i == 3000 & currentLvl != 3)
                    {
                        lvlMust = 3;
                        levelAmountLabel.Content = lvlMust.ToString();
                    }
                    else if (i == 6000 & currentLvl != 4)
                    {
                        lvlMust = 4;
                        levelAmountLabel.Content = lvlMust.ToString();
                    }
                    else if (i == 10000 & currentLvl != 5)
                    {
                        lvlMust = 5;
                        levelAmountLabel.Content = lvlMust.ToString();
                    }
                    else if (i == 15000 & currentLvl != 6)
                    {
                        lvlMust = 6;
                        levelAmountLabel.Content = lvlMust.ToString();
                    }
                    else if (i == 21000 & currentLvl != 7)
                    {
                        lvlMust = 7;
                        levelAmountLabel.Content = lvlMust.ToString();
                    }
                    else if (i == 28000 & currentLvl != 8)
                    {
                        lvlMust = 8;
                        levelAmountLabel.Content = lvlMust.ToString();
                    }
                    else if (i == 36000 & currentLvl != 9)
                    {
                        lvlMust = 9;
                        levelAmountLabel.Content = lvlMust.ToString();
                    }
                }
                
                experienseAmountLabel.Content = Convert.ToString(changedValue);
                //LvlChange();
            }
        }

        private void _3kExpBtn_Click(object sender, RoutedEventArgs e)
        {
            long baseValue = Convert.ToInt64(experienseAmountLabel.Content);
            long changedValue = 3000 + baseValue;
            if (changedValue > 36000)
            {
                experienseAmountLabel.Content = "36000";
                MessageBox.Show("Max level!");
            }
            else
            {
                experienseAmountLabel.Content = Convert.ToString(changedValue);
                LvlChange();
            }
        }

        private void _5kExpBtn_Click(object sender, RoutedEventArgs e)
        {
            long baseValue = Convert.ToInt64(experienseAmountLabel.Content);
            long changedValue = 5000 + baseValue;
            if (changedValue > 36000)
            {
                experienseAmountLabel.Content = "36000";
                MessageBox.Show("Max level!");
            }
            else
            {
                experienseAmountLabel.Content = Convert.ToString(changedValue);
                LvlChange();
            }
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (professionComboBox.SelectedIndex == 0)
            {
                MongoDataBase.ReplaceCharacterToDB(characterList.SelectedItem.ToString(), new Warrior(nameTextBox.Text, Convert.ToInt32(strAmountLabel.Content)
                      , Convert.ToInt32(agltAmountLabel.Content), Convert.ToInt32(intAmountLabel.Content)
                      , Convert.ToInt32(stmnAmountLabel.Content), Convert.ToInt32(levelAmountLabel.Content)
                      , Convert.ToInt64(experienseAmountLabel.Content), Convert.ToInt32(freePointAmountLabel.Content)));
                MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was updated!");
                characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
            }
            else if (professionComboBox.SelectedIndex == 1)
            {
                //MongoDataBase.ReplaceArcher(characterList.SelectedItem.ToString(), new Archer(nameTextBox.Text, professionComboBox.SelectionBoxItem.ToString()
                //    , Convert.ToInt32(strAmountLabel.Content), Convert.ToInt32(agltAmountLabel.Content)
                //    , Convert.ToInt32(intAmountLabel.Content), Convert.ToInt32(stmnAmountLabel.Content)
                //    , Convert.ToInt32(levelAmountLabel.Content), Convert.ToInt64(experienseAmountLabel.Content)
                //    , Convert.ToInt32(freePointAmountLabel.Content)));
                MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was updated!");
                characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
            }
            else if (professionComboBox.SelectedIndex == 2)
            {
                //MongoDataBase.ReplaceWizard(characterList.SelectedItem.ToString(), new Wizard(nameTextBox.Text, professionComboBox.SelectionBoxItem.ToString()
                //    , Convert.ToInt32(strAmountLabel.Content), Convert.ToInt32(agltAmountLabel.Content)
                //    , Convert.ToInt32(intAmountLabel.Content), Convert.ToInt32(stmnAmountLabel.Content)
                //    , Convert.ToInt32(levelAmountLabel.Content), Convert.ToInt64(experienseAmountLabel.Content)
                //    , Convert.ToInt32(freePointAmountLabel.Content)));
                MessageBox.Show($"Character \"{nameTextBox.Text} ({professionComboBox.SelectionBoxItem})\" was updated!");
                characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
            }
            else MessageBox.Show("Chose the profession of your character!");
        }
        private void characterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            professionComboBox.IsEnabled = false;
            creationButton.IsEnabled = true;
            nameTextBox.Text = MongoDataBase.ShowCharacterInfo(characterList.SelectedItem.ToString())._name;
            if (MongoDataBase.ShowCharacterInfo(characterList.SelectedItem.ToString())._profession == "Warrior")
                professionComboBox.SelectedIndex = 0;
            else if (MongoDataBase.ShowCharacterInfo(characterList.SelectedItem.ToString())._profession == "Archer")
                professionComboBox.SelectedIndex = 1;
            else if (MongoDataBase.ShowCharacterInfo(characterList.SelectedItem.ToString())._profession == "Mage")
                professionComboBox.SelectedIndex = 2;
            strAmountLabel.Content = MongoDataBase.ShowCharacterInfo(characterList.SelectedItem.ToString())._strenght;
            agltAmountLabel.Content = MongoDataBase.ShowCharacterInfo(characterList.SelectedItem.ToString())._agility;
            intAmountLabel.Content = MongoDataBase.ShowCharacterInfo(characterList.SelectedItem.ToString())._intelligence;
            stmnAmountLabel.Content = MongoDataBase.ShowCharacterInfo(characterList.SelectedItem.ToString())._stamina;
            levelAmountLabel.Content = MongoDataBase.ShowCharacterInfo(characterList.SelectedItem.ToString())._level;
            experienseAmountLabel.Content = MongoDataBase.ShowCharacterInfo(characterList.SelectedItem.ToString())._experiense;
            freePointAmountLabel.Content = MongoDataBase.ShowCharacterInfo(characterList.SelectedItem.ToString())._freePoint;
        }
        private void creationButton_click(object sender, RoutedEventArgs e)
        {
            professionComboBox.IsEnabled = true;
            creationButton.IsEnabled = false;
            StatChange();
            AddStatChange();
            BtnActivate();
        }
        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            MongoDataBase.RemoveCharacter(characterList.SelectedItem.ToString());
            //characterList.ItemsSource = MongoDataBase.GetCharacterNameList();
            MessageBox.Show($"Character {characterList.SelectedValue} was deleted from DB");
        }
    }
}