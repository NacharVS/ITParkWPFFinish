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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string bufName = "Name";

        BasePersonage personage = new BasePersonage("Name");

        List<string> bufferBasePersonages = DataBaseMethods.GetListOfBasePersonages();

        string bufProfession = "profession";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            bufName = txtName.Text;
        }

        private void txtName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (bufName != "Name")
            {
                return;
            }
            else txtName.Clear();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            personage = new BasePersonage("Name");

            txtName.Text = personage.Name.ToString();
            bufName = personage.Name.ToString();
            bufProfession = personage.Profession;

            txtHealth.Text = personage.CurrentHelth.ToString();
            
            txtPower.Text = personage.PowerCurrent.ToString();
            txtSkill.Text = personage.SkillCurrent.ToString();
            txtIntellect.Text = personage.IntellectCurrent.ToString();
            txtStamina.Text = personage.StaminaCurrent.ToString();
            
            warriorRB.IsChecked = false;
            archerRB.IsChecked = false;
            shamanRB.IsChecked = false;
            warriorRB.IsEnabled = true;
            archerRB.IsEnabled = true;
            shamanRB.IsEnabled = true;

            bufferBasePersonages = DataBaseMethods.GetListOfBasePersonages();
            listOfPersonages.ItemsSource = DataBaseMethods.GetListOfBasePersonages();
            listOfPersonages.SelectedIndex = -1;

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (bufName == "Name" || bufName == "" || bufName == " ")
            {
                MessageBox.Show("Enter the name of personage");
            }

            else if (bufferBasePersonages.Exists(x => x == bufName))
            {
                MessageBox.Show("Pesonage with this name is already exist");
            }

            else if (warriorRB.IsChecked == true)
            {
                Warrior warrior_1 = new Warrior(bufName);

                txtHealth.Text = warrior_1.CurrentHelth.ToString();
                txtPower.Text = warrior_1.PowerCurrent.ToString();
                txtSkill.Text = warrior_1.SkillCurrent.ToString();
                txtIntellect.Text = warrior_1.IntellectCurrent.ToString();
                txtStamina.Text = warrior_1.SkillCurrent.ToString();

                //personage = warrior_1;
                DataBaseMethods.AddPersonageToDatabase(warrior_1);

                bufferBasePersonages = DataBaseMethods.GetListOfBasePersonages();
                listOfPersonages.ItemsSource = DataBaseMethods.GetListOfBasePersonages();
                MessageBox.Show($"Personage Warrior {warrior_1.Name} is created");
            }
            else if (archerRB.IsChecked == true)
            {
                Archer archer_1 = new Archer(bufName);

                bufProfession = archer_1.Profession.ToString();
                txtHealth.Text = archer_1.CurrentHelth.ToString();
                txtPower.Text = archer_1.PowerCurrent.ToString();
                txtSkill.Text = archer_1.SkillCurrent.ToString();
                txtIntellect.Text = archer_1.IntellectCurrent.ToString();
                txtStamina.Text = archer_1.SkillCurrent.ToString();
                
                //personage = archer_1;
                DataBaseMethods.AddPersonageToDatabase(archer_1);

                bufferBasePersonages = DataBaseMethods.GetListOfBasePersonages();
                listOfPersonages.ItemsSource = DataBaseMethods.GetListOfBasePersonages();
                MessageBox.Show($"Personage Archer {archer_1.Name} is created");
            }
            else if (shamanRB.IsChecked == true)
            {
                Shaman shaman_1 = new Shaman(bufName);
                txtHealth.Text = shaman_1.CurrentHelth.ToString();

                txtPower.Text = shaman_1.PowerCurrent.ToString();
                txtSkill.Text = shaman_1.SkillCurrent.ToString();
                txtIntellect.Text = shaman_1.IntellectCurrent.ToString();
                txtStamina.Text = shaman_1.SkillCurrent.ToString();

                //personage = shaman_1;
                DataBaseMethods.AddPersonageToDatabase(shaman_1);

                bufferBasePersonages = DataBaseMethods.GetListOfBasePersonages();
                listOfPersonages.ItemsSource = DataBaseMethods.GetListOfBasePersonages();
                MessageBox.Show($"Personage Shaman {shaman_1.Name} is created");
            }
            else
            {
                MessageBox.Show("Choose the profession of Personage");
            }
        }

        private void listOfPersonages_Loaded(object sender, RoutedEventArgs e)
        {
            listOfPersonages.ItemsSource = DataBaseMethods.GetListOfBasePersonages();
        }

        private void listOfPersonages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listOfPersonages.SelectedIndex == -1)
            {
                txtName.Text = personage.Name.ToString();
                bufName = personage.Name.ToString();
                bufProfession = personage.Profession;

                txtHealth.Text = personage.CurrentHelth.ToString();

                txtPower.Text = "10";
                txtSkill.Text = "10";
                txtIntellect.Text = "10";
                txtStamina.Text = "10";

                personage.PowerCurrent = Convert.ToDouble(txtPower.Text);
                personage.SkillCurrent = Convert.ToDouble(txtSkill.Text);
                personage.IntellectCurrent = Convert.ToDouble(txtIntellect.Text);
                personage.StaminaCurrent = Convert.ToDouble(txtStamina.Text);

                warriorRB.IsChecked = false;
                archerRB.IsChecked = false;
                shamanRB.IsChecked = false;
                warriorRB.IsEnabled = true;
                archerRB.IsEnabled = true;
                shamanRB.IsEnabled = true;
            }
            else
            {
                listOfPersonages.ItemsSource = DataBaseMethods.GetListOfBasePersonages();
                personage = DataBaseMethods.GetPersonage(listOfPersonages.SelectedItem.ToString());

                txtName.Text = personage.Name.ToString();
                bufName = personage.Name.ToString();
                bufProfession = personage.Profession;

                txtHealth.Text = personage.CurrentHelth.ToString();

                txtName.Text = personage.Name;
                txtHealth.Text = personage.CurrentHelth.ToString();
                txtPower.Text = personage.PowerCurrent.ToString();
                txtSkill.Text = personage.SkillCurrent.ToString();
                txtIntellect.Text = personage.IntellectCurrent.ToString();
                txtStamina.Text = personage.StaminaCurrent.ToString();

                if (personage.Profession == "warrior")
                {
                    warriorRB.IsChecked = true;
                    archerRB.IsChecked = false;
                    shamanRB.IsChecked = false;
                    archerRB.IsEnabled = false;
                    shamanRB.IsEnabled = false;
                }
                else if (personage.Profession == "archer")
                {
                    warriorRB.IsChecked = false;
                    archerRB.IsChecked = true;
                    shamanRB.IsChecked = false;
                    warriorRB.IsEnabled = false;
                    shamanRB.IsEnabled = false;
                }
                else if (personage.Profession == "shaman")
                {
                    warriorRB.IsChecked = false;
                    archerRB.IsChecked = false;
                    shamanRB.IsChecked = true;
                    archerRB.IsEnabled = false;
                    warriorRB.IsEnabled = false;
                }
                else MessageBox.Show(personage.Profession.ToString() + " ERROR!!!");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (listOfPersonages.SelectedIndex == -1)
                MessageBox.Show("Choose the personage!!!");

            else
            {
                BasePersonage personage1; // = new BasePersonage(txtName.Text.ToString());

                if (warriorRB.IsChecked == true)
                {
                    personage1 = new Warrior(txtName.Text.ToString());
                }
                                    
                else if (archerRB.IsChecked == true)
                {
                    personage1 = new Archer(txtName.Text.ToString());

                }

                else
                {
                    personage1 = new Shaman(txtName.Text.ToString());
                }
                personage1.CurrentHelth = Convert.ToDouble(txtHealth.Text);
                personage1.PowerCurrent = Convert.ToDouble(txtPower.Text);
                personage1.SkillCurrent = Convert.ToDouble(txtSkill.Text);
                personage1.IntellectCurrent = Convert.ToDouble(txtIntellect.Text);
                personage1.StaminaCurrent = Convert.ToDouble(txtStamina.Text);

                DataBaseMethods.ReplacePersonageToDB(personage1, listOfPersonages.SelectedItem.ToString());

                listOfPersonages.SelectedItem = txtName.Text;
                listOfPersonages.ItemsSource = DataBaseMethods.GetListOfBasePersonages();
                MessageBox.Show($"Personage {personage1.Profession} {personage1.Name} is updated");
            }
        }

        private void btnPowerBoost_Click(object sender, RoutedEventArgs e)
        {
            if (listOfPersonages.SelectedIndex == -1)
                MessageBox.Show("Choose the personage!!!");
            else
            {
                if (personage.PowerCurrent >= personage.PowerMax)
                {
                    MessageBox.Show($"Power of personage {personage.Profession} cannot exceed {personage.PowerMax}");
                }
                else if (personage.CurrentHelth <= 50)
                {
                    MessageBox.Show("Health is not enough");
                }
                else
                {
                    personage.PowerCurrent += 5;
                    personage.CurrentHelth -= 5;

                    txtHealth.Text = personage.CurrentHelth.ToString();
                    txtPower.Text = personage.PowerCurrent.ToString();
                }
            }

        }

        private void btnSkillBoost_Click(object sender, RoutedEventArgs e)
        {
            if (listOfPersonages.SelectedIndex == -1)
                MessageBox.Show("Choose the personage!!!");
            else
            {
                if (personage.SkillCurrent >= personage.SkillMax)
                {
                    MessageBox.Show($"Skill of personage {personage.Profession} cannot exceed {personage.SkillMax}");
                }
                else if (personage.CurrentHelth <= 50)
                {
                    MessageBox.Show("Health is not enough");
                }
                else
                {
                    personage.SkillCurrent += 5;
                    personage.CurrentHelth -= 5;

                    txtHealth.Text = personage.CurrentHelth.ToString();
                    txtSkill.Text = personage.SkillCurrent.ToString();
                }
            }
        }

        private void btnIntellectBoost_Click(object sender, RoutedEventArgs e)
        {
            if (listOfPersonages.SelectedIndex == -1)
                MessageBox.Show("Choose the personage!!!");
            else
            {
                if (personage.IntellectCurrent >= personage.IntellectMax)
                {
                    MessageBox.Show($"Intellect of personage {personage.Profession} cannot exceed {personage.IntellectMax}");
                }
                else if (personage.CurrentHelth <= 50)
                {
                    MessageBox.Show("Health is not enough");
                }
                else
                {
                    personage.IntellectCurrent += 5;
                    personage.CurrentHelth -= 5;

                    txtHealth.Text = personage.CurrentHelth.ToString();
                    txtIntellect.Text = personage.IntellectCurrent.ToString();
                }
            }
        }

        private void btnStaminaBoost_Click(object sender, RoutedEventArgs e)
        {
            if (listOfPersonages.SelectedIndex == -1)
                MessageBox.Show("Choose the personage!!!");
            else
            {
                if (personage.StaminaCurrent >= personage.StaminaMax)
                {
                    MessageBox.Show($"Stamina of personage {personage.Profession} cannot exceed {personage.StaminaMax}");
                }
                else if (personage.CurrentHelth <= 50)
                {
                    MessageBox.Show("Health is not enough");
                }
                else
                {
                    personage.StaminaCurrent += 5;
                    personage.CurrentHelth -= 5;

                    txtHealth.Text = personage.CurrentHelth.ToString();
                    txtStamina.Text = personage.StaminaCurrent.ToString();
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (listOfPersonages.SelectedIndex == -1)
                MessageBox.Show("Choose the personage!!!");
            else
            {
                string nameToDelete = listOfPersonages.SelectedItem.ToString();
                
                personage = new Archer("Name");
                listOfPersonages.SelectedIndex = -1;

                DataBaseMethods.RemovePersonage(nameToDelete);
                MessageBox.Show($"Personage {nameToDelete} is deleted");

                bufferBasePersonages = DataBaseMethods.GetListOfBasePersonages();
                listOfPersonages.ItemsSource = DataBaseMethods.GetListOfBasePersonages();
            }
        }
    }
}
