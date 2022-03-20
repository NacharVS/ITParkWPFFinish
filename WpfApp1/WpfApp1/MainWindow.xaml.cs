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
        Warrior warrior = new Warrior("Name");
        Archer archer = new Archer("Name");
        Shaman shaman = new Shaman("Name");

        //List<string> buffer = DataBaseMethods.GetListOfPersonages();

        string bufProfession = "Profession";
        int bufHealth;
        double bufPower;
        double bufSkill;
        double bufIntellect;
        double bufStamina;

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
            personage.Name = "Name";
            txtName.Text = personage.Name.ToString();
            bufName = personage.Name.ToString();
            bufProfession = personage.Profession.ToString();
            txtHealth.Text = personage.CurrentHelth.ToString();
            bufHealth = Convert.ToInt32(txtHealth.Text);
                        
            txtPower.Text = personage.PowerCurrent.ToString();
            bufPower = Convert.ToDouble(txtPower.Text);
            txtSkill.Text = personage.SkillCurrent.ToString();
            bufSkill = Convert.ToDouble(txtSkill.Text);
            txtIntellect.Text = personage.IntellectCurrent.ToString();
            bufIntellect = Convert.ToDouble(txtIntellect.Text);
            txtStamina.Text = personage.SkillCurrent.ToString();
            bufStamina = Convert.ToDouble(txtStamina.Text);

            warriorRB.IsChecked = false;
            archerRB.IsChecked = false;
            shamanRB.IsChecked = false;

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if(bufName == "Name" || bufName == "" || bufName == " ")
            {
                MessageBox.Show("Enter the name of personage");
            }

            //else if (buffer.Exists(x => x == bufName))
            //{
            //    MessageBox.Show("Pesonage with this name is already exist");
            //}

            else if (warriorRB.IsChecked == true)
            {
                warrior.Name = txtName.Text;
                
                bufName = warrior.Name.ToString();
                bufProfession = warrior.Profession.ToString();
                txtHealth.Text = warrior.CurrentHelth.ToString();
                bufHealth = Convert.ToInt32(txtHealth.Text);

                txtPower.Text = warrior.PowerCurrent.ToString();
                bufPower = Convert.ToDouble(txtPower.Text);
                txtSkill.Text = warrior.SkillCurrent.ToString();
                bufSkill = Convert.ToDouble(txtSkill.Text);
                txtIntellect.Text = warrior.IntellectCurrent.ToString();
                bufIntellect = Convert.ToDouble(txtIntellect.Text);
                txtStamina.Text = warrior.SkillCurrent.ToString();
                bufStamina = Convert.ToDouble(txtStamina.Text);

                DataBaseMethods.AddPersonageToDatabase(warrior);
                MessageBox.Show($"Personage Warrior {warrior.Name} is created");
            }
            else if (archerRB.IsChecked == true)
            {
                archer.Name = txtName.Text;

                bufName = archer.Name.ToString();
                bufProfession = archer.Profession.ToString();
                txtHealth.Text = archer.CurrentHelth.ToString();
                bufHealth = Convert.ToInt32(txtHealth.Text);

                txtPower.Text = archer.PowerCurrent.ToString();
                bufPower = Convert.ToDouble(txtPower.Text);
                txtSkill.Text = archer.SkillCurrent.ToString();
                bufSkill = Convert.ToDouble(txtSkill.Text);
                txtIntellect.Text = archer.IntellectCurrent.ToString();
                bufIntellect = Convert.ToDouble(txtIntellect.Text);
                txtStamina.Text = archer.SkillCurrent.ToString();
                bufStamina = Convert.ToDouble(txtStamina.Text);

                DataBaseMethods.AddPersonageToDatabase(archer);
                MessageBox.Show($"Personage Archer {archer.Name} is created");
            }
            else if (shamanRB.IsChecked == true)
            {
                shaman.Name = txtName.Text;

                bufName = shaman.Name.ToString();
                bufProfession = shaman.Profession.ToString();
                txtHealth.Text = shaman.CurrentHelth.ToString();
                bufHealth = Convert.ToInt32(txtHealth.Text);

                txtPower.Text = shaman.PowerCurrent.ToString();
                bufPower = Convert.ToDouble(txtPower.Text);
                txtSkill.Text = shaman.SkillCurrent.ToString();
                bufSkill = Convert.ToDouble(txtSkill.Text);
                txtIntellect.Text = shaman.IntellectCurrent.ToString();
                bufIntellect = Convert.ToDouble(txtIntellect.Text);
                txtStamina.Text = shaman.SkillCurrent.ToString();
                bufStamina = Convert.ToDouble(txtStamina.Text);

                DataBaseMethods.AddPersonageToDatabase(shaman);
                MessageBox.Show($"Personage Shaman {shaman.Name} is created");
            }
            else
            {
                
                personage.Name = txtName.Text;
                
                bufName = personage.Name.ToString();
                bufProfession = personage.Profession.ToString();
                txtHealth.Text = personage.CurrentHelth.ToString();
                bufHealth = Convert.ToInt32(txtHealth.Text);

                txtPower.Text = personage.PowerCurrent.ToString();
                bufPower = Convert.ToDouble(txtPower.Text);
                txtSkill.Text = personage.SkillCurrent.ToString();
                bufSkill = Convert.ToDouble(txtSkill.Text);
                txtIntellect.Text = personage.IntellectCurrent.ToString();
                bufIntellect = Convert.ToDouble(txtIntellect.Text);
                txtStamina.Text = personage.SkillCurrent.ToString();
                bufStamina = Convert.ToDouble(txtStamina.Text);

                MessageBox.Show("Choose the profession of Personage");
            }
        }
    }
}
