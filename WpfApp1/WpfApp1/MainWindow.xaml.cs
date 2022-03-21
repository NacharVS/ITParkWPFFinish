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
        List<string> bufferWarriors = DataBaseMethods.GetListOfWarriors();
        List<string> bufferArchers = DataBaseMethods.GetListOfArchers();
        List<string> bufferShamans = DataBaseMethods.GetListOfShamans();

        string bufProfession = "profession";
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
            if (bufName == "Name" || bufName == "" || bufName == " ")
            {
                MessageBox.Show("Enter the name of personage");
            }

            else if (bufferWarriors.Exists(x => x == bufName) || bufferArchers.Exists(x => x == bufName) || bufferShamans.Exists(x => x == bufName))
            {
                MessageBox.Show("Pesonage with this name is already exist");
            }

            else if (warriorRB.IsChecked == true)
            {
                Warrior warrior_1 = new Warrior(bufName);
                
                bufProfession = warrior_1.Profession.ToString();
                txtHealth.Text = warrior_1.CurrentHelth.ToString();
                bufHealth = Convert.ToInt32(txtHealth.Text);

                txtPower.Text = warrior_1.PowerCurrent.ToString();
                bufPower = Convert.ToDouble(txtPower.Text);
                txtSkill.Text = warrior_1.SkillCurrent.ToString();
                bufSkill = Convert.ToDouble(txtSkill.Text);
                txtIntellect.Text = warrior_1.IntellectCurrent.ToString();
                bufIntellect = Convert.ToDouble(txtIntellect.Text);
                txtStamina.Text = warrior_1.SkillCurrent.ToString();
                bufStamina = Convert.ToDouble(txtStamina.Text);

                DataBaseMethods.AddWarriorToDatabase(warrior_1);
                MessageBox.Show($"Personage Warrior {warrior_1.Name} is created");
            }
            else if (archerRB.IsChecked == true)
            {
                Archer archer_1 = new Archer(bufName);
       
                bufProfession = archer_1.Profession.ToString();
                txtHealth.Text = archer_1.CurrentHelth.ToString();
                bufHealth = Convert.ToInt32(txtHealth.Text);

                txtPower.Text = archer_1.PowerCurrent.ToString();
                bufPower = Convert.ToDouble(txtPower.Text);
                txtSkill.Text = archer_1.SkillCurrent.ToString();
                bufSkill = Convert.ToDouble(txtSkill.Text);
                txtIntellect.Text = archer_1.IntellectCurrent.ToString();
                bufIntellect = Convert.ToDouble(txtIntellect.Text);
                txtStamina.Text = archer_1.SkillCurrent.ToString();
                bufStamina = Convert.ToDouble(txtStamina.Text);

                DataBaseMethods.AddArcherToDatabase(archer_1);
                MessageBox.Show($"Personage Archer {archer_1.Name} is created");
            }
            else if (shamanRB.IsChecked == true)
            {
                Shaman shaman_1 = new Shaman(bufName);
                bufProfession = shaman_1.Profession.ToString();
                txtHealth.Text = shaman_1.CurrentHelth.ToString();
                bufHealth = Convert.ToInt32(txtHealth.Text);

                txtPower.Text = shaman_1.PowerCurrent.ToString();
                bufPower = Convert.ToDouble(txtPower.Text);
                txtSkill.Text = shaman_1.SkillCurrent.ToString();
                bufSkill = Convert.ToDouble(txtSkill.Text);
                txtIntellect.Text = shaman_1.IntellectCurrent.ToString();
                bufIntellect = Convert.ToDouble(txtIntellect.Text);
                txtStamina.Text = shaman_1.SkillCurrent.ToString();
                bufStamina = Convert.ToDouble(txtStamina.Text);

                DataBaseMethods.AddShamanToDatabase(shaman_1);
                MessageBox.Show($"Personage Shaman {shaman_1.Name} is created");
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
