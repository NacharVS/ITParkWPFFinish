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

namespace Project_IT_Park_HW
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
        public void StartStat()
        {
            lblStrength.Content = "10";
            lblAgility.Content = "10";
            lblIntellect.Content = "10";
            lblEndurance.Content = "10";
            lblPoints.Content = "10";
            lblLevel.Content = "1";
            lblExperience.Content = "0";
        }
        public void ArcherStartStat()
        {
            lblStrength.Content = "20";
            lblAgility.Content = "30";
            lblIntellect.Content = "15";
            lblEndurance.Content = "20";
        }
        public void MageStartStat()
        {
            lblStrength.Content = "15";
            lblAgility.Content = "20";
            lblIntellect.Content = "35";
            lblEndurance.Content = "20";
        }
        public void WarriorstartStat()
        {
            lblStrength.Content = "30";
            lblAgility.Content = "15";
            lblIntellect.Content = "10";
            lblEndurance.Content = "25";
        }
        private void cmbClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbClass.SelectedIndex == 0)
            {
                ArcherStartStat();
            }
            else if (cmbClass.SelectedIndex == 1)
            {
                MageStartStat();
            }
            else if (cmbClass.SelectedIndex == 2)
            {
                WarriorstartStat();
            }
        }
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (cmbClass.SelectedIndex == 0)
            {
                if (txtName.Text == MongoDataBase.FindUser(txtName.Text))
                {
                    MessageBox.Show($"A unit named {txtName.Text} exist!");
                }
                else
                {
                    MongoDataBase.AddUnitToDB(txtName.Text, cmbClass.SelectionBoxItem.ToString(), Convert.ToInt32(lblStrength.Content), Convert.ToInt32(lblAgility.Content), Convert.ToInt32(lblIntellect.Content), Convert.ToInt32(lblEndurance.Content), Convert.ToInt32(lblLevel.Content), Convert.ToInt32(lblExperience.Content), Convert.ToInt32(lblPoints.Content));
                    lbxUnitList.ItemsSource = MongoDataBase.GetUnitList();
                    lbxUnitClass.ItemsSource = MongoDataBase.GetClassUnitList();
                    ArcherStartStat();
                    txtName.Clear();
                }
            }
            else
            if (cmbClass.SelectedIndex == 1)
            {
                if (txtName.Text == MongoDataBase.FindUser(txtName.Text))
                {
                    MessageBox.Show($"A unit named {txtName.Text} exist!");
                }
                else
                {
                    MongoDataBase.AddUnitToDB(txtName.Text, cmbClass.SelectionBoxItem.ToString(), Convert.ToInt32(lblStrength.Content), Convert.ToInt32(lblAgility.Content), Convert.ToInt32(lblIntellect.Content), Convert.ToInt32(lblEndurance.Content), Convert.ToInt32(lblLevel.Content), Convert.ToInt32(lblExperience.Content), Convert.ToInt32(lblPoints.Content));
                    lbxUnitList.ItemsSource = MongoDataBase.GetUnitList();
                    lbxUnitClass.ItemsSource = MongoDataBase.GetClassUnitList();
                    MageStartStat();
                    txtName.Clear();
                }
            }
            else
            if (cmbClass.SelectedIndex == 2)
            {
                if (txtName.Text == MongoDataBase.FindUser(txtName.Text))
                {
                    MessageBox.Show($"A unit named {txtName.Text} exist!");
                }
                else
                {
                    MongoDataBase.AddUnitToDB(txtName.Text, cmbClass.SelectionBoxItem.ToString(), Convert.ToInt32(lblStrength.Content), Convert.ToInt32(lblAgility.Content), Convert.ToInt32(lblIntellect.Content), Convert.ToInt32(lblEndurance.Content), Convert.ToInt32(lblLevel.Content), Convert.ToInt32(lblExperience.Content), Convert.ToInt32(lblPoints.Content));
                    lbxUnitList.ItemsSource = MongoDataBase.GetUnitList();
                    lbxUnitClass.ItemsSource = MongoDataBase.GetClassUnitList();
                    WarriorstartStat();
                }
            }
        }

        int physDamage;
        int physProtection;
        int magDamage;
        int magProtection;
        int health;
        int mana;
        public void AddStatChange()
        {
            if (cmbClass.SelectedIndex == 0)
            {
                AddArcherStat();
            }
            else if (cmbClass.SelectedIndex == 1)
            {
                AddMageStat();
            }
            else if (cmbClass.SelectedIndex == 2)
            {
                AddWarriorStat();
            }
        }
        public void AddArcherStat()
        {
            physDamage = Convert.ToInt32(3 * Convert.ToInt32(lblStrength.Content) + 7 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content));
            physProtection = 1 * Convert.ToInt32(lblStrength.Content) + 5 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 2 * Convert.ToInt32(lblEndurance.Content);
            magDamage = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 3 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
            magProtection = 0 * Convert.ToInt32(lblStrength.Content) + 3 * Convert.ToInt32(lblAgility.Content) + 3 * Convert.ToInt32(lblIntellect.Content) + 1 * Convert.ToInt32(lblEndurance.Content);
            health = 2 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 5 * Convert.ToInt32(lblEndurance.Content);
            mana = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 1 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
            lblPhysDamage.Content = physDamage.ToString();
            lblPhysProtect.Content = physProtection.ToString();
            lblMagDamage.Content = magDamage.ToString();
            lblMagProtect.Content = magProtection.ToString();
            lblHealth.Content = health.ToString();
            lblMana.Content = mana.ToString();
        }
        public void AddMageStat()
        {
            physDamage = 1 * Convert.ToInt32(lblStrength.Content) + 1 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
            physProtection = 1 * Convert.ToInt32(lblStrength.Content) + 1 * Convert.ToInt32(lblAgility.Content) + 1 * Convert.ToInt32(lblIntellect.Content) + 2 * Convert.ToInt32(lblEndurance.Content);
            magDamage = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 7 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
            magProtection = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 5 * Convert.ToInt32(lblIntellect.Content) + 1 * Convert.ToInt32(lblEndurance.Content);
            health = 1 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 3 * Convert.ToInt32(lblEndurance.Content);
            mana = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 2 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
            lblPhysDamage.Content = physDamage.ToString();
            lblPhysProtect.Content = physProtection.ToString();
            lblMagDamage.Content = magDamage.ToString();
            lblMagProtect.Content = magProtection.ToString();
            lblHealth.Content = health.ToString();
            lblMana.Content = mana.ToString();
        }
        public void AddWarriorStat()
        {
            physDamage = 7 * Convert.ToInt32(lblStrength.Content) + 2 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
            physProtection = 2 * Convert.ToInt32(lblStrength.Content) + 3 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 3 * Convert.ToInt32(lblEndurance.Content);
            magDamage = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 1 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
            magProtection = 1 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 2 * Convert.ToInt32(lblIntellect.Content) + 1 * Convert.ToInt32(lblEndurance.Content);
            health = 5 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 10 * Convert.ToInt32(lblEndurance.Content);
            mana = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 1 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
            lblPhysDamage.Content = physDamage.ToString();
            lblPhysProtect.Content = physProtection.ToString();
            lblMagDamage.Content = magDamage.ToString();
            lblMagProtect.Content = magProtection.ToString();
            lblHealth.Content = health.ToString();
            lblMana.Content = mana.ToString();
        }
        private void btnMinusStrength_Click(object sender, RoutedEventArgs e)
        {
            int strengthPoint = Convert.ToInt32(lblStrength.Content);
            int point = Convert.ToInt32(lblPoints.Content);
            if (cmbClass.SelectedIndex == 0 & 21 <= strengthPoint)
            {
                if (point >= 0)
                {
                    lblStrength.Content = strengthPoint - 1;
                    lblPoints.Content = point + 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 1 & 16 <= strengthPoint)
            {
                if (point >= 0)
                {
                    lblStrength.Content = strengthPoint - 1;
                    lblPoints.Content = point + 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 2 & 31 <= strengthPoint)
            {
                if (point >= 0)
                {
                    lblStrength.Content = strengthPoint - 1;
                    lblPoints.Content = point + 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
        }
        private void btnPlusStrength_Click(object sender, RoutedEventArgs e)
        {
            int strengthPoint = Convert.ToInt32(lblStrength.Content);
            int point = Convert.ToInt32(lblPoints.Content);
            if (cmbClass.SelectedIndex == 0 & strengthPoint <= 54)
            {
                if (point != 0)
                {
                    lblStrength.Content = strengthPoint + 1;
                    lblPoints.Content = point - 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 1 & strengthPoint <= 44)
            {
                if (point != 0)
                {
                    lblStrength.Content = strengthPoint + 1;
                    lblPoints.Content = point - 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 2 & strengthPoint <= 249)
            {
                if (point != 0)
                {
                    lblStrength.Content = strengthPoint + 1;
                    lblPoints.Content = point - 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
        }

        private void btnMInusAgility_Click(object sender, RoutedEventArgs e)
        {
            int strengthPoint = Convert.ToInt32(lblAgility.Content);
            int point = Convert.ToInt32(lblPoints.Content);
            if (cmbClass.SelectedIndex == 0 & 31 <= strengthPoint)
            {
                if (point >= 0)
                {
                    lblAgility.Content = strengthPoint - 1;
                    lblPoints.Content = point + 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 1 & 21 <= strengthPoint)
            {
                if (point >= 0)
                {
                    lblAgility.Content = strengthPoint - 1;
                    lblPoints.Content = point + 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 2 & 16 <= strengthPoint)
            {
                if (point >= 0)
                {
                    lblAgility.Content = strengthPoint - 1;
                    lblPoints.Content = point + 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
        }

        private void btnPlusAgility_Click(object sender, RoutedEventArgs e)
        {
            int strengthPoint = Convert.ToInt32(lblAgility.Content);
            int point = Convert.ToInt32(lblPoints.Content);
            if (cmbClass.SelectedIndex == 0 & strengthPoint <= 249)
            {
                if (point != 0)
                {
                    lblAgility.Content = strengthPoint + 1;
                    lblPoints.Content = point - 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 1 & strengthPoint <= 84)
            {
                if (point != 0)
                {
                    lblAgility.Content = strengthPoint + 1;
                    lblPoints.Content = point - 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 2 & strengthPoint <= 79)
            {
                if (point != 0)
                {
                    lblAgility.Content = strengthPoint + 1;
                    lblPoints.Content = point - 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
        }

        private void btnMInusIntellect_Click(object sender, RoutedEventArgs e)
        {
            int strengthPoint = Convert.ToInt32(lblIntellect.Content);
            int point = Convert.ToInt32(lblPoints.Content);
            if (cmbClass.SelectedIndex == 0 & 16 <= strengthPoint)
            {
                if (point >= 0)
                {
                    lblIntellect.Content = strengthPoint - 1;
                    lblPoints.Content = point + 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 1 & 36 <= strengthPoint)
            {
                if (point >= 0)
                {
                    lblIntellect.Content = strengthPoint - 1;
                    lblPoints.Content = point + 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 2 & 11 <= strengthPoint)
            {
                if (point >= 0)
                {
                    lblIntellect.Content = strengthPoint - 1;
                    lblPoints.Content = point + 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
        }

        private void btnPlusIntellect_Click(object sender, RoutedEventArgs e)
        {
            int strengthPoint = Convert.ToInt32(lblIntellect.Content);
            int point = Convert.ToInt32(lblPoints.Content);
            if (cmbClass.SelectedIndex == 0 & strengthPoint <= 69)
            {
                if (point != 0)
                {
                    lblIntellect.Content = strengthPoint + 1;
                    lblPoints.Content = point - 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 1 & strengthPoint <= 249)
            {
                if (point != 0)
                {
                    lblIntellect.Content = strengthPoint + 1;
                    lblPoints.Content = point - 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 2 & strengthPoint <= 9)
            {
                if (point != 0)
                {
                    lblIntellect.Content = strengthPoint + 1;
                    lblPoints.Content = point - 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
        }

        private void btnMinusEndurance_Click(object sender, RoutedEventArgs e)
        {
            int strengthPoint = Convert.ToInt32(lblEndurance.Content);
            int point = Convert.ToInt32(lblPoints.Content);
            if (cmbClass.SelectedIndex == 0 & 21 <= strengthPoint)
            {
                if (point >= 0)
                {
                    lblEndurance.Content = strengthPoint - 1;
                    lblPoints.Content = point + 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 1 & 21 <= strengthPoint)
            {
                if (point >= 0)
                {
                    lblEndurance.Content = strengthPoint - 1;
                    lblPoints.Content = point + 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 2 & 26 <= strengthPoint)
            {
                if (point >= 0)
                {
                    lblEndurance.Content = strengthPoint - 1;
                    lblPoints.Content = point + 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
        }

        private void btnPlusEndurance_Click(object sender, RoutedEventArgs e)
        {
            int strengthPoint = Convert.ToInt32(lblEndurance.Content);
            int point = Convert.ToInt32(lblPoints.Content);
            if (cmbClass.SelectedIndex == 0 & strengthPoint <= 79)
            {
                if (point != 0)
                {
                    lblEndurance.Content = strengthPoint + 1;
                    lblPoints.Content = point - 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 1 & strengthPoint <= 79)
            {
                if (point != 0)
                {
                    lblEndurance.Content = strengthPoint + 1;
                    lblPoints.Content = point - 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
            else
            if (cmbClass.SelectedIndex == 2 & strengthPoint <= 99)
            {
                if (point != 0)
                {
                    lblEndurance.Content = strengthPoint + 1;
                    lblPoints.Content = point - 1;
                    AddStatChange();
                }
                else
                {
                    MessageBox.Show("Point is empty!");
                }
            }
        }

        private void lbxUnitList_Loaded(object sender, RoutedEventArgs e)
        {
            lbxUnitList.ItemsSource = MongoDataBase.GetUnitList();
            lbxUnitClass.ItemsSource = MongoDataBase.GetClassUnitList();
            rbAllowed.IsEnabled = false;
            rbForbidden.IsEnabled = false;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MongoDataBase.RemoveUnit(lbxUnitList.SelectedItem.ToString());
            MongoDataBase.RemoveClass(lbxUnitList.SelectedItem.ToString());
            lbxUnitList.ItemsSource = MongoDataBase.GetUnitList();
            lbxUnitClass.ItemsSource = MongoDataBase.GetClassUnitList();
            MessageBox.Show("Unit deleted!");
        }

        private void btn1000exp_Click(object sender, RoutedEventArgs e)
        {
            int experience = Convert.ToInt32(lblExperience.Content);
            //int point = Convert.ToInt32(lblPoints.Content);
            if (experience >= 55000)
            {
                MessageBox.Show("Max level reached!");
            }
            else
            {
                lblExperience.Content = experience + 1000;
                LevelUp();
                //lblPoints.Content = Convert.ToString(point + 10);
            }
        }

        private void btn3000exp_Click(object sender, RoutedEventArgs e)
        {
            int experience = Convert.ToInt32(lblExperience.Content);
            if (experience >= 55000)
            {
                MessageBox.Show("Max level reached!");
            }
            else
            {
                lblExperience.Content = experience + 3000;
                LevelUp();
            }
        }

        private void btn5000exp_Click(object sender, RoutedEventArgs e)
        {
            int experience = Convert.ToInt32(lblExperience.Content);
            if (experience >= 55000)
            {
                MessageBox.Show("Max level reached!");
            }
            else
            {
                lblExperience.Content = experience + 5000;
                LevelUp();
            }
        }

        public void LevelUp()
        {
            int experience = Convert.ToInt32(lblExperience.Content);
            if (experience >= 1000 & experience < 3000)
            {
                lblLevel.Content = "2";
            }
            else
            if (experience >= 3000 & experience < 6000)
            {
                lblLevel.Content = "3";
            }
            else
            if (experience >= 6000 & experience < 10000)
            {
                lblLevel.Content = "4";
            }
            else
            if (experience >= 10000 & experience < 15000)
            {
                lblLevel.Content = "5";
            }
            else
            if (experience >= 15000 & experience < 21000)
            {
                lblLevel.Content = "6";
            }
            else
            if (experience >= 28000 & experience < 36000)
            {
                lblLevel.Content = "7";
            }
            else
            if (experience >= 36000 & experience < 45000)
            {
                lblLevel.Content = "8";
            }
            else
            if (experience >= 45000 & experience < 55000)
            {
                lblLevel.Content = "9";
            }
            else
            if (experience >= 55000)
            {
                lblLevel.Content = "10";
            }
        }

        private void txtName_SelectionChanged(object sender, RoutedEventArgs e)
        {
            StartStat();
        }

        private void txtName_GotFocus(object sender, RoutedEventArgs e)
        {
            cmbClass.IsEnabled = true;
            txtName.Clear();
            StartStat();
        }

        private void btnEditing_Click(object sender, RoutedEventArgs e)
        {
            string buffer = Convert.ToString(btnEditing.Content);
            if (buffer == "Disable unit editing?")
            {
                btnMInusStrength.IsEnabled = false;
                btnPlusStrength.IsEnabled = false;
                btnMInusAgility.IsEnabled = false;
                btnPlusAgility.IsEnabled = false;
                btnMInusIntellect.IsEnabled = false;
                btnPlusIntellect.IsEnabled = false;
                btnMinusEndurance.IsEnabled = false;
                btnPlusEndurance.IsEnabled = false;
                btn1000exp.IsEnabled = false;
                btn3000exp.IsEnabled = false;
                btn5000exp.IsEnabled = false;
                cmbClass.IsEnabled = false;
                rbAllowed.IsChecked = false;
                rbForbidden.IsChecked = true;
                btnEditing.Content = "Allow unit editing?";
            }
            else
            if (buffer == "Allow unit editing?")
            {
                btnMInusStrength.IsEnabled = true;
                btnPlusStrength.IsEnabled = true;
                btnMInusAgility.IsEnabled = true;
                btnPlusAgility.IsEnabled = true;
                btnMInusIntellect.IsEnabled = true;
                btnPlusIntellect.IsEnabled = true;
                btnMinusEndurance.IsEnabled = true;
                btnPlusEndurance.IsEnabled = true;
                btn1000exp.IsEnabled = true;
                btn3000exp.IsEnabled = true;
                btn5000exp.IsEnabled = true;
                cmbClass.IsEnabled = true;
                rbAllowed.IsChecked = true;
                rbForbidden.IsChecked = false;
                btnEditing.Content = "Disable unit editing?";
            }
        }

        private void lbxUnitList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character character = MongoDataBase.GetCharacter(lbxUnitList.SelectedItem.ToString());
            lbxUnitList.ItemsSource = MongoDataBase.GetUnitList();

            if (character.classes == "Archer")
            {
                cmbClass.SelectedIndex = 0;
            }
            else
            if (character.classes == "Mage")
            {
                cmbClass.SelectedIndex = 1;
            }
            else
            if (character.classes == "Warrior")
            {
                cmbClass.SelectedIndex = 2;
            }
            cmbClass.IsEnabled = false;
            txtName.Text = character.name;
            lblStrength.Content = character.strenght;
            lblAgility.Content = character.agility;
            lblIntellect.Content = character.intellect;
            lblEndurance.Content = character.endurance;
            lblLevel.Content = character.level;
            lblExperience.Content = character.experience;
            lblPoints.Content = character.point;
            AddStatChange();

        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            Character character = MongoDataBase.GetCharacter(lbxUnitList.SelectedItem.ToString());

            if (character.classes == "Archer")
            {
                cmbClass.SelectedIndex = 0;
                MongoDataBase.ReplaceUnit(new Archer(txtName.Text.ToString(), "Archer", Convert.ToInt32(lblStrength.Content), Convert.ToInt32(lblAgility.Content), Convert.ToInt32(lblIntellect.Content), Convert.ToInt32(lblEndurance.Content), Convert.ToInt32(lblLevel.Content), Convert.ToInt32(lblExperience.Content), Convert.ToInt32(lblPoints.Content)), txtName.Text.ToString());
            }
            else
            if (character.classes == "Mage")
            {
                cmbClass.SelectedIndex = 1;
                MongoDataBase.ReplaceUnit(new Archer(txtName.Text.ToString(), "Mage", Convert.ToInt32(lblStrength.Content), Convert.ToInt32(lblAgility.Content), Convert.ToInt32(lblIntellect.Content), Convert.ToInt32(lblEndurance.Content), Convert.ToInt32(lblLevel.Content), Convert.ToInt32(lblExperience.Content), Convert.ToInt32(lblPoints.Content)), txtName.Text.ToString());
            }
            else
            if (character.classes == "Warrior")
            {
                cmbClass.SelectedIndex = 2;
                MongoDataBase.ReplaceUnit(new Archer(txtName.Text.ToString(), "Warrior", Convert.ToInt32(lblStrength.Content), Convert.ToInt32(lblAgility.Content), Convert.ToInt32(lblIntellect.Content), Convert.ToInt32(lblEndurance.Content), Convert.ToInt32(lblLevel.Content), Convert.ToInt32(lblExperience.Content), Convert.ToInt32(lblPoints.Content)), txtName.Text.ToString());
            }
            MessageBox.Show("Changes applied!");
        }
    }
}
//    Character Editor.

//1. Реализовать поле ввода имени. Реализовать возможность выбора профессии(Воин, лучник, волшебник)

//2. Реализовать панель с характеристиками персонажа (Сила, Ловкость, Интеллект, Выносливость). Базовый показатель каждой характеристики равен 10(До выбора профессии).
//2.1 Реализовать возможность изменения харатеристики(прибавление/убавление) при помощи расходования допольнительных очков характеристик(базовое значение: 10).  Базовое значение дополнительных очков не зависит от выбраной профессии персонажа.
//2.1.1 Учесть необходимость минимального и максимального значения характеристик.




//Минимальное/Максимальное значение характеристик по профессиям.

//                Воин          Лучник           Маг
//Сила		     30/250			20/55			15/45
//Ловкость       15/80			30/250			20/85
//Интеллект      10/50			15/70			35/250
//Выносливать    25/100			20/80			20/80
//3.Реализовать панель с показателями Физ.Урона, Физ.Защиты, Маг. Урона, Маг. Защиты, количества жизни и магии.
//3.1 Показатели изменяются в зависимости от характеристик и выбранной профессии. 

//Сила (за 1 единицу характеристики):
//		          Воин          Лучник			 Маг
//Физ.Урон	      +7			 +3			     +1
//Физ.Защита	  +2			 +1			     +1
//Маг.Урон	      +0		 	 +0			     +0	
//Маг.Защита	  +1		 	 +0			     +0
//Жизнь		      +5			 +2			     +1
//Магия		      +0			 +0			     +0	

//Ловкость (за 1 единицу характеристики):
//		          Воин          Лучник			 Маг
//Физ.Урон	      +2			 +7			     +1
//Физ.Защита	  +3			 +5			     +1
//Маг.Урон	      +0			 +0			     +0	
//Маг.Защита	  +0			 +3			     +0
//Жизнь		      +0			 +0			     +0
//Магия		      +0			 +0			     +0

//Интеллект (за 1 единицу характеристики):
//		          Воин          Лучник			 Маг
//Физ.Урон	      +0			 +0			     +0
//Физ.Защита	  +0			 +0			     +1
//Маг.Урон	      +1			 +3			     +7	
//Маг.Защита	  +2			 +3			     +5
//Жизнь		      +0			 +0			     +0
//Магия		      +1		 	 +1			     +2

//Выносливость (за 1 единицу характеристики):
//		          Воин          Лучник			 Маг
//Физ.Урон	      +0			 +0			     +0
//Физ.Защита	  +3			 +2			     +2
//Маг.Урон	      +0			 +0			     +0	
//Маг.Защита	  +1			 +1			     +1
//Жизнь		      +10			 +5			     +3
//Магия		      +0			 +0			     +0

//4. Реализовать кнопки для получения опыта +1000 exp, +3000 exp, +5000 exp.
//5. Реализовать повышение уровня персонажа:
//	1 ур - 0,
//	2 УР - 1000,
//	3 ур - 3000,
//	4 ур - 6000,
//	5 ур - 10000,
//	6 ур - 15000

//6.Работа с базой данных
//6.1 Реализовать Список персонажей(выводим только имя персонажа) сохраненных в базу. При выборе из списка, подгружаются данные о характеристиках и, если необходимо, о показателях, в том числе неизрасходованные очки характеристик и текущий показатель опыта.
//6.2 Реализовать кнопки добавления в базу нового персонажа. 
//6.3. Реализовать кнопку редактирования данных персонажа, который уже сохранен в базу.
//6.4. Реализовать кнопку удаления персонажа из базы данных



