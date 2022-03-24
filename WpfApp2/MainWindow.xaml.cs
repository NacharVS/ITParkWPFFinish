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

namespace WpfApp2
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

     

        Archer archer = new Archer("Name", "Archer", 20, 30, 15, 20);
        Mage mage = new Mage("Name", "Mage", 15, 20, 35, 20);
        Warrior warrior = new Warrior("Name", "Warrior", 30, 15, 10, 25);
        private void Name_GotFocus(object sender, RoutedEventArgs e)
        {
            Name.Clear();
        }

       
    private void professions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (professions.SelectedIndex == 0)
            {
                
                ChosenProfession.Text = "Archer";
                points.Content = 10;
                Strength.Content = archer.CurrentStrength;
                Agility.Content = archer.CurrentAgility;
                Intelligence.Content = archer.CurrentIntelligence;
                Endurance.Content = archer.CurrentEndurance;
                life.Content = Convert.ToDouble(archer.CurrentStrength.ToString()) * 2 + Convert.ToDouble(archer.CurrentEndurance.ToString()) * 5;
                physicDefense.Content = Convert.ToDouble(archer.CurrentStrength.ToString()) * 1 + Convert.ToDouble(archer.CurrentAgility.ToString()) * 5 + Convert.ToDouble(archer.CurrentEndurance.ToString()) * 2;
                physicDamage.Content = Convert.ToDouble(archer.CurrentStrength.ToString()) * 3 + Convert.ToDouble(archer.CurrentAgility.ToString()) * 7;
                magicDefense.Content = Convert.ToDouble(archer.CurrentAgility.ToString()) * 3 + Convert.ToDouble(archer.CurrentIntelligence.ToString()) * 3 + Convert.ToDouble(archer.CurrentEndurance.ToString()) * 1;
                magicDamage.Content = Convert.ToDouble(archer.CurrentIntelligence.ToString()) * 3;
                mana.Content = Convert.ToDouble(archer.CurrentIntelligence.ToString()) * 1;
                level.Content = "0";
            }

            if (professions.SelectedIndex == 1)
            {
                ChosenProfession.Text = "Mage";
                points.Content = 10;
                Strength.Content = mage.CurrentStrength;
                Agility.Content = mage.CurrentAgility;
                Intelligence.Content = mage.CurrentIntelligence;
                Endurance.Content = mage.CurrentEndurance;
                life.Content = Convert.ToDouble(mage.CurrentStrength.ToString())  + Convert.ToDouble(mage.CurrentIntelligence.ToString()) +  Convert.ToDouble(mage.CurrentEndurance.ToString()) * 3;
                physicDefense.Content = Convert.ToDouble(mage.CurrentStrength.ToString()) + Convert.ToDouble(mage.CurrentAgility.ToString()) + Convert.ToDouble(mage.CurrentEndurance.ToString()) * 2;
                physicDamage.Content = Convert.ToDouble(mage.CurrentStrength.ToString()) + Convert.ToDouble(mage.CurrentAgility.ToString());
                magicDefense.Content = Convert.ToDouble(mage.CurrentIntelligence.ToString()) * 5 + Convert.ToDouble(mage.CurrentEndurance.ToString());
                magicDamage.Content = Convert.ToDouble(mage.CurrentIntelligence.ToString()) * 7;
                mana.Content =   Convert.ToDouble(mage.CurrentIntelligence.ToString()) * 2 ;
            }
            if (professions.SelectedIndex == 2)
            {
                ChosenProfession.Text = "Warrior";
                points.Content = 10;
                Strength.Content = warrior.CurrentStrength; 
                Agility.Content = warrior.CurrentAgility;
                Intelligence.Content = warrior.CurrentIntelligence; 
                Endurance.Content = warrior.CurrentEndurance;
                life.Content = Convert.ToDouble(warrior.CurrentStrength.ToString())*5 +  Convert.ToDouble(warrior.CurrentEndurance.ToString()) * 10;
                physicDefense.Content = Convert.ToDouble(warrior.CurrentStrength.ToString())*2 + Convert.ToDouble(warrior.CurrentAgility.ToString())*3 + Convert.ToDouble(warrior.CurrentEndurance.ToString()) * 3;
                physicDamage.Content = Convert.ToDouble(warrior.CurrentStrength.ToString())*7 + Convert.ToDouble(warrior.CurrentAgility.ToString())*2;
                magicDefense.Content = Convert.ToDouble(warrior.CurrentStrength.ToString())+ Convert.ToDouble(warrior.CurrentIntelligence.ToString()) * 2 + Convert.ToDouble(warrior.CurrentEndurance.ToString());
                magicDamage.Content = Convert.ToDouble(warrior.CurrentIntelligence.ToString());
                mana.Content = Convert.ToDouble(warrior.CurrentIntelligence.ToString());
            }
        }
       
       

        private void saveCharacter_Click(object sender, RoutedEventArgs e)
        {
            if (ChosenProfession.Text == "Archer")
            {
               MongoDB.ArcherAddToDB(Name.Text, ChosenProfession.Text, Convert.ToDouble(Strength.Content.ToString()), Convert.ToDouble(Agility.Content.ToString()), Convert.ToDouble(Intelligence.Content.ToString()), Convert.ToDouble(Endurance.Content.ToString()));
               savedСharacters.ItemsSource = MongoDB.ArcherGetList();
               MessageBox.Show($"Archer {Name.Text} was saved");

            }

            else if(ChosenProfession.Text == "Mage")
            {
                MongoDB.MageAddToDB(Name.Text, ChosenProfession.Text, Convert.ToDouble(Strength.Content.ToString()), Convert.ToDouble(Agility.Content.ToString()), Convert.ToDouble(Intelligence.Content.ToString()), Convert.ToDouble(Endurance.Content.ToString()));
                savedСharacters.ItemsSource = MongoDB.MageGetList();
                MessageBox.Show($"Mage {Name.Text} was saved");
            }
            else if(ChosenProfession.Text == "Warrior")
            {
                MongoDB.MageAddToDB(Name.Text, ChosenProfession.Text, Convert.ToDouble(Strength.Content.ToString()), Convert.ToDouble(Agility.Content.ToString()), Convert.ToDouble(Intelligence.Content.ToString()), Convert.ToDouble(Endurance.Content.ToString()));
                savedСharacters.ItemsSource = MongoDB.WarriorGetList();
                MessageBox.Show($"Warrior {Name.Text} was saved");
            }
        }

        private void savedСharacters_Loaded(object sender, RoutedEventArgs e)
        {
            if (MongoDB.ArcherGetList() == null)  
            {
                MessageBox.Show($"Saved archers are not listed");
            }
               else if(MongoDB.MageGetList() == null)
               {
                MessageBox.Show($"Saved mage are not listed");
               }
               else if (MongoDB.WarriorGetList() == null)
               {
                MessageBox.Show($"Saved warrior are not listed");
               }

            else
            {
                savedСharacters.ItemsSource = MongoDB.ArcherGetList();
                savedСharacters.ItemsSource = MongoDB.MageGetList();
                savedСharacters.ItemsSource = MongoDB.WarriorGetList();
            }
        }

        private void savedСharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (savedСharacters.SelectedIndex == -1)
            {
                return;
            }
            else 
            {
                if (ChosenProfession.Text == "Archer")
                {
                    Name.Text = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).Name;
                    ChosenProfession.Text = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).Proffesion;
                    Strength.Content = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).CurrentStrength;
                    Agility.Content = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).CurrentAgility;
                    Intelligence.Content = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).CurrentIntelligence;
                    Endurance.Content = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).CurrentEndurance;
                    //life.Content = Convert.ToDouble(archer.CurrentStrength.ToString()) * 2 + Convert.ToDouble(archer.CurrentEndurance.ToString()) * 5;
                    //physicDefense.Content = Convert.ToDouble(archer.CurrentStrength.ToString()) * 1 + Convert.ToDouble(archer.CurrentAgility.ToString()) * 5 + Convert.ToDouble(archer.CurrentEndurance.ToString()) * 2;
                    //physicDamage.Content = Convert.ToDouble(archer.CurrentStrength.ToString()) * 3 + Convert.ToDouble(archer.CurrentAgility.ToString()) * 7;
                    //magicDefense.Content = Convert.ToDouble(archer.CurrentAgility.ToString()) * 3 + Convert.ToDouble(archer.CurrentIntelligence.ToString()) * 3 + Convert.ToDouble(archer.CurrentEndurance.ToString()) * 1;
                    //magicDamage.Content = Convert.ToDouble(archer.CurrentIntelligence.ToString()) * 3;
                    //mana.Content = Convert.ToDouble(archer.CurrentIntelligence.ToString()) * 1;
                    level.Content = "0";
                }
                else if (ChosenProfession.Text == "Mage")
                {

                    Name.Text = MongoDB.GetMage(savedСharacters.SelectedItem.ToString()).Name;
                    ChosenProfession.Text = MongoDB.GetMage(savedСharacters.SelectedItem.ToString()).Proffesion;
                    Strength.Content = MongoDB.GetMage(savedСharacters.SelectedItem.ToString()).CurrentStrength;
                    Agility.Content = MongoDB.GetMage(savedСharacters.SelectedItem.ToString()).CurrentAgility;
                    Intelligence.Content = MongoDB.GetMage(savedСharacters.SelectedItem.ToString()).CurrentIntelligence;
                    Endurance.Content = MongoDB.GetMage(savedСharacters.SelectedItem.ToString()).CurrentEndurance;
                    //life.Content = Convert.ToDouble(mage.CurrentStrength.ToString()) + Convert.ToDouble(mage.CurrentIntelligence.ToString()) + Convert.ToDouble(mage.CurrentEndurance.ToString()) * 3;
                    //physicDefense.Content = Convert.ToDouble(mage.CurrentStrength.ToString()) + Convert.ToDouble(mage.CurrentAgility.ToString()) + Convert.ToDouble(mage.CurrentEndurance.ToString()) * 2;
                    //physicDamage.Content = Convert.ToDouble(mage.CurrentStrength.ToString()) + Convert.ToDouble(mage.CurrentAgility.ToString());
                    //magicDefense.Content = Convert.ToDouble(mage.CurrentIntelligence.ToString()) * 5 + Convert.ToDouble(mage.CurrentEndurance.ToString());
                    //magicDamage.Content = Convert.ToDouble(mage.CurrentIntelligence.ToString()) * 7;
                    mana.Content = Convert.ToDouble(mage.CurrentIntelligence.ToString()) * 2;
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    Name.Text = MongoDB.GetWarrior(savedСharacters.SelectedItem.ToString()).Name;
                    ChosenProfession.Text = MongoDB.GetWarrior(savedСharacters.SelectedItem.ToString()).Proffesion;
                    Strength.Content = MongoDB.GetWarrior(savedСharacters.SelectedItem.ToString()).CurrentStrength;
                    Agility.Content = MongoDB.GetWarrior(savedСharacters.SelectedItem.ToString()).CurrentAgility;
                    Intelligence.Content = MongoDB.GetWarrior(savedСharacters.SelectedItem.ToString()).CurrentIntelligence;
                    Endurance.Content = MongoDB.GetWarrior(savedСharacters.SelectedItem.ToString()).CurrentEndurance;
                    //life.Content = Convert.ToDouble(warrior.CurrentStrength.ToString()) * 5 + Convert.ToDouble(warrior.CurrentEndurance.ToString()) * 10;
                    //physicDefense.Content = Convert.ToDouble(warrior.CurrentStrength.ToString()) * 2 + Convert.ToDouble(warrior.CurrentAgility.ToString()) * 3 + Convert.ToDouble(warrior.CurrentEndurance.ToString()) * 3;
                    //physicDamage.Content = Convert.ToDouble(warrior.CurrentStrength.ToString()) * 7 + Convert.ToDouble(warrior.CurrentAgility.ToString()) * 2;
                    //magicDefense.Content = Convert.ToDouble(warrior.CurrentStrength.ToString()) + Convert.ToDouble(warrior.CurrentIntelligence.ToString()) * 2 + Convert.ToDouble(warrior.CurrentEndurance.ToString());
                    //magicDamage.Content = Convert.ToDouble(warrior.CurrentIntelligence.ToString());
                    mana.Content = Convert.ToDouble(warrior.CurrentIntelligence.ToString());

                } 
            }
        }
        private void StrengthPointsPlus_Click(object sender, RoutedEventArgs e)
        {
            double life2 = Convert.ToDouble(life.Content);
            double currentStrength = Convert.ToDouble(Strength.Content);
            double basePoints = Convert.ToDouble(points.Content);
            if (basePoints > 0)
            {
                
                if (ChosenProfession.Text == "Archer")
                {
                    currentStrength++;
                    basePoints--;
                    Strength.Content = currentStrength.ToString();
                    points.Content = basePoints.ToString();
                    if (currentStrength > 55)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Strength.Content = archer.CurrentStrength;
                    }
                    archer.CurrentStrength = currentStrength;
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    currentStrength++;
                    basePoints--;
                    Strength.Content = currentStrength.ToString();
                    points.Content = basePoints.ToString();
                    if (currentStrength > 45)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Strength.Content = mage.CurrentStrength;
                    }
                    mage.CurrentStrength = currentStrength;
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    currentStrength++;
                    basePoints--;
                    Strength.Content = currentStrength.ToString();
                    points.Content = basePoints.ToString();
                    if (currentStrength > 50)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Strength.Content = warrior.CurrentStrength;
                    }
                    warrior.CurrentStrength = currentStrength;
                }
            }
            else
            {
                MessageBox.Show("Point is empty!");
            }
        }

        private void AgilityPointsPlus_Click(object sender, RoutedEventArgs e)
        {
            double currentAgility = Convert.ToDouble(Agility.Content);
            double basePoints = Convert.ToDouble(points.Content);
            if (basePoints > 0)
            {
                if (ChosenProfession.Text == "Archer")
                {
                    currentAgility++;
                    basePoints--;
                    Agility.Content = currentAgility.ToString();
                    points.Content = basePoints.ToString();
                    if (currentAgility > 250)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Agility.Content = archer.CurrentAgility;
                    }
                    archer.CurrentAgility = currentAgility;
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    currentAgility++;
                    basePoints--;
                    Agility.Content = currentAgility.ToString();
                    points.Content = basePoints.ToString();
                    if (currentAgility > 45)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Agility.Content = mage.CurrentAgility;
                    }
                    mage.CurrentAgility = currentAgility;
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    currentAgility++;
                    basePoints--;
                    Agility.Content = currentAgility.ToString();
                    points.Content = basePoints.ToString();
                    if (currentAgility > 80)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Agility.Content = warrior.CurrentAgility;
                    }
                    warrior.CurrentAgility = currentAgility;
                }
            }
            else
            {
                MessageBox.Show("Point is empty!");
            }
        }

        private void IntelligencePointsPlus_Click(object sender, RoutedEventArgs e)
        {
            double currentIntelligence = Convert.ToDouble(Intelligence.Content);
            double basePoints = Convert.ToDouble(points.Content);
            if (basePoints > 0)
            {
                if (ChosenProfession.Text == "Archer")
                {
                    currentIntelligence++;
                    basePoints--;
                    Intelligence.Content = currentIntelligence.ToString();
                    points.Content = basePoints.ToString();
                    if (currentIntelligence > 70)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Intelligence.Content = archer.CurrentIntelligence;
                    }
                    archer.CurrentIntelligence = currentIntelligence;
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    currentIntelligence++;
                    basePoints--;
                    Intelligence.Content = currentIntelligence.ToString();
                    points.Content = basePoints.ToString();
                    mage.CurrentIntelligence = currentIntelligence;
                    if (currentIntelligence > 250)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        mage.CurrentIntelligence = mage.CurrentIntelligence;
                    }
                    mage.CurrentIntelligence = currentIntelligence;
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    currentIntelligence++;
                    basePoints--;
                    Intelligence.Content = currentIntelligence.ToString();
                    points.Content = basePoints.ToString();
                    
                    if ( currentIntelligence > 50)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Intelligence.Content = warrior.CurrentIntelligence;
                    }
                    warrior.CurrentIntelligence = currentIntelligence;
                }
               
            }
            else
            {
                MessageBox.Show("Point is empty!");
            }
        }

        private void EndurancePointsPlus_Click(object sender, RoutedEventArgs e)
        {
            double currentEndurance = Convert.ToDouble(Endurance.Content);
            double basePoints = Convert.ToDouble(points.Content);
            if (basePoints > 0)
            {
               
                if (ChosenProfession.Text == "Archer")
                {
                    currentEndurance++;
                    basePoints--;
                    Endurance.Content = currentEndurance.ToString();
                    points.Content = basePoints.ToString();
                    if (currentEndurance > 80)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Endurance.Content = archer.CurrentEndurance;
                    }
                    archer.CurrentEndurance = currentEndurance;
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    currentEndurance++;
                    basePoints--;
                    Endurance.Content = currentEndurance.ToString();
                    points.Content = basePoints.ToString();
                    if (currentEndurance > 80)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Endurance.Content = mage.CurrentEndurance;
                    }
                    mage.CurrentEndurance = currentEndurance;
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    currentEndurance++;
                    basePoints--;
                    Endurance.Content = currentEndurance.ToString();
                    points.Content = basePoints.ToString();
                    
                    if (currentEndurance > 100)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Endurance.Content = warrior.CurrentEndurance;
                    }
                    warrior.CurrentEndurance = currentEndurance;
                }
               
            }
            else
            {
                MessageBox.Show("Point is empty!");
            }
        }

        private void StrengthPointsMinus_Click(object sender, RoutedEventArgs e)
        {
            double currentStrength = Convert.ToDouble(Strength.Content);
            double basePoints = Convert.ToDouble(points.Content);
            if (basePoints < 10)
            {
               
                if (ChosenProfession.Text == "Archer")
                {
                    currentStrength--;
                    basePoints++;
                    Strength.Content = currentStrength.ToString();
                    points.Content = basePoints.ToString();
                    
                    if (currentStrength < 20 )
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Strength.Content = archer.CurrentStrength;
                    }
                    archer.CurrentStrength = currentStrength;
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    currentStrength--;
                    basePoints++;
                    Strength.Content = currentStrength.ToString();
                    points.Content = basePoints.ToString();
                    
                    if (currentStrength < 15)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Strength.Content = mage.CurrentStrength;
                    }
                    mage.CurrentStrength = currentStrength;
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    currentStrength--;
                    basePoints++;
                    Strength.Content = currentStrength.ToString();
                    points.Content = basePoints.ToString();
                    
                    if (currentStrength < 30)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Strength.Content = warrior.CurrentStrength;
                    }
                    warrior.CurrentStrength = currentStrength;
                }
                
            }
            else
            {
                MessageBox.Show("Can't be taken away at the minimum value!");
            }
           
        }

        private void AgilityPointsMinus_Click(object sender, RoutedEventArgs e)
        {
            double currentAgility = Convert.ToDouble(Agility.Content);
            double basePoints = Convert.ToDouble(points.Content);
            if (basePoints < 10)
            {
                
                if (ChosenProfession.Text == "Archer")
                {
                    currentAgility--;
                    basePoints++;
                    Agility.Content = currentAgility.ToString();
                    points.Content = basePoints.ToString();
                    
                    if (currentAgility < 30 )
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Agility.Content = archer.CurrentAgility;
                    }
                    archer.CurrentAgility = currentAgility;
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    currentAgility--;
                    basePoints++;
                    Agility.Content = currentAgility.ToString();
                    points.Content = basePoints.ToString();
                    
                    if (currentAgility < 20 )
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Agility.Content = mage.CurrentAgility;

                    }
                    mage.CurrentAgility = currentAgility;
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    currentAgility--;
                    basePoints++;
                    Agility.Content = currentAgility.ToString();
                    points.Content = basePoints.ToString();
                    
                    if (currentAgility < 15)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Agility.Content = warrior.CurrentAgility;
                    }
                    warrior.CurrentAgility = currentAgility;
                }
            }
            else
            {
                MessageBox.Show("Can't be taken away at the minimum value!");
            }
        }

        private void IntelligencePointsMinus_Click(object sender, RoutedEventArgs e)
        {
            double currentIntelligence = Convert.ToDouble(Intelligence.Content);
            double basePoints = Convert.ToDouble(points.Content);
            if (basePoints < 10)
            {
               
                if (ChosenProfession.Text == "Archer")
                {
                    currentIntelligence--;
                    basePoints++;
                    Intelligence.Content = currentIntelligence.ToString();
                    points.Content = basePoints.ToString();
                    
                    if (currentIntelligence < 15 )
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Intelligence.Content = archer.CurrentIntelligence;
                    }
                    archer.CurrentIntelligence = currentIntelligence;
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    currentIntelligence--;
                    basePoints++;
                    Intelligence.Content = currentIntelligence.ToString();
                    points.Content = basePoints.ToString();
                   
                    if (currentIntelligence < 35 )
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Intelligence.Content = mage.CurrentIntelligence;
                    }
                    mage.CurrentIntelligence = currentIntelligence;
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    currentIntelligence--;
                    basePoints++;
                    Intelligence.Content = currentIntelligence.ToString();
                    points.Content = basePoints.ToString();
                   
                    if (currentIntelligence < 10 )
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Intelligence.Content = warrior.CurrentIntelligence;

                    }
                    warrior.CurrentIntelligence = currentIntelligence;
                }
               
            }
            else
            {
                MessageBox.Show("Can't be taken away at the minimum value!");
            }
        }

        private void EndurancePointsMinus_Click(object sender, RoutedEventArgs e)
        {
            double currentEndurance = Convert.ToDouble(Endurance.Content);
            double basePoints = Convert.ToDouble(points.Content);
            if (basePoints < 10)
            {
                
                if (ChosenProfession.Text == "Archer")
                {
                    currentEndurance--;
                    basePoints++;
                    Endurance.Content = currentEndurance.ToString();
                    points.Content = basePoints.ToString();
                   
                    if (currentEndurance < 20)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Endurance.Content = archer.CurrentEndurance;
                    }
                    archer.CurrentEndurance = currentEndurance;
                }
               else if (ChosenProfession.Text == "Mage")
                {
                    currentEndurance--;
                    basePoints++;
                    Endurance.Content = currentEndurance.ToString();
                    points.Content = basePoints.ToString();
                    if (currentEndurance < 20)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Endurance.Content = mage.CurrentEndurance;
                    }
                    mage.CurrentEndurance = currentEndurance;
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    currentEndurance--;
                    basePoints++;
                    Endurance.Content = currentEndurance.ToString();
                    points.Content = basePoints.ToString();
                    if (currentEndurance < 25)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Endurance.Content = warrior.CurrentEndurance;
                    }
                    warrior.CurrentEndurance = currentEndurance;
                }
            }
            else
            {
                MessageBox.Show("Can't be taken away at the minimum value!");
            }
        }

        private void experience_Click(object sender, RoutedEventArgs e)
        {
            if (experience.Content.ToString() == "Experience")
            {
                experience.Content = "+1000 exp";
                level.Content = 1;
                if (ChosenProfession.Text == "Archer")
                {
                    archer.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {archer.Level}.\n You are awarded 5 bonus points");
                }
               else if (ChosenProfession.Text == "Mage")
                {
                    mage.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {mage.Level}.\n You are awarded 5 bonus points");
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    warrior.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {warrior.Level}.\n You are awarded 5 bonus points");
                }
                points.Content = Convert.ToDouble(points.Content.ToString()) + 5;
            }
           else if (experience.Content.ToString() == "+1000 exp")
            {
                experience.Content = "+3000 exp";
                level.Content = 2;
                if (ChosenProfession.Text == "Archer")
                {
                    archer.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {archer.Level}.\n You are awarded 5 bonus points");
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    mage.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {mage.Level}.\n You are awarded 5 bonus points");
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    warrior.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {warrior.Level}.\n You are awarded 5 bonus points");
                }
                points.Content = Convert.ToDouble(points.Content.ToString()) + 5;
               
            }
           else if (experience.Content.ToString() == "+3000 exp")
            {
                experience.Content = "+6000 exp";
                level.Content = 3;
                if (ChosenProfession.Text == "Archer")
                {
                    archer.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {archer.Level}.\n You are awarded 5 bonus points");
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    mage.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {mage.Level}.\n You are awarded 5 bonus points");
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    warrior.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {warrior.Level}.\n You are awarded 5 bonus points");
                }

                points.Content = Convert.ToDouble(points.Content.ToString()) + 5;
            }
            else if (experience.Content.ToString() == "+6000 exp")
            {
                experience.Content = "+10000 exp";
                level.Content = 4;
                if (ChosenProfession.Text == "Archer")
                {
                    archer.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {archer.Level}.\n You are awarded 5 bonus points");
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    mage.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {mage.Level}.\n You are awarded 5 bonus points");
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    warrior.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {warrior.Level}.\n You are awarded 5 bonus points");
                }

                points.Content = Convert.ToDouble(points.Content.ToString()) + 5;
            }
            else if (experience.Content.ToString() == "+10000 exp")
            {
                experience.Content = "+15000 exp";
                level.Content = 5;
                if (ChosenProfession.Text == "Archer")
                {
                    archer.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {archer.Level}.\n You are awarded 5 bonus points");
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    mage.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {mage.Level}.\n You are awarded 5 bonus points");
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    warrior.Level = Convert.ToDouble(level.Content);
                    MessageBox.Show($"Your character level - {warrior.Level}.\n You are awarded 5 bonus points");
                }
                points.Content = Convert.ToDouble(points.Content.ToString()) + 5;
            }
        }

        private void editing_Click(object sender, RoutedEventArgs e)
        {
            if (ChosenProfession.Text == "Archer")
            {
                MongoDB.ReplaceArcher(savedСharacters.SelectedItem.ToString(), new Archer(Name.Text, ChosenProfession.Text, Convert.ToDouble(Strength.Content), Convert.ToDouble(Agility.Content.ToString()), Convert.ToDouble(Intelligence.Content.ToString()), Convert.ToDouble(Endurance.Content.ToString())));

            }
           else if (ChosenProfession.Text == "Mage")
            {
                MongoDB.ReplaceMage(savedСharacters.SelectedItem.ToString(), new Mage(Name.Text, ChosenProfession.Text, Convert.ToDouble(Strength.Content.ToString()), Convert.ToDouble(Agility.Content.ToString()), Convert.ToDouble(Intelligence.Content.ToString()), Convert.ToDouble(Endurance.Content.ToString())));

            }
            else if (ChosenProfession.Text == "Warrior")
            {
                MongoDB.ReplaceWarrior(savedСharacters.SelectedItem.ToString(), new Warrior(Name.Text, ChosenProfession.Text, Convert.ToDouble(Strength.Content.ToString()), Convert.ToDouble(Agility.Content.ToString()), Convert.ToDouble(Intelligence.Content.ToString()), Convert.ToDouble(Endurance.Content.ToString())));

            }
        }

        private void deleting_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}


//6. Работа с базой данных
//6.1 При выборе из списка, подгружаются данные о характеристиках и, если необходимо, о показателях, в том числе неизрасходованные очки характеристик и текущий показатель опыта.

//6.3. Реализовать кнопку редактирования данных персонажа, который уже сохранен в базу.
//6.4. Реализовать кнопку удаления персонажа из базы данных

//7*
//Добавить возможность выбора оружия(3 вида: Меч, Лук, Посох) через ComboBox.

//Меч:
//параметры:
//Мин физ. урон 10, Макс физ. Урон 50.
//Мин маг. урон 1, Макс маг. Урон 5.
//требования:
//мин Сила 50, мин ловкость 25.


//Лук:
//параметры:
//Мин физ. урон 1, Макс физ. Урон 70.
//Мин маг. урон 7, Макс маг. Урон 7.
//требования:
//мин Сила 20, мин ловкость 50.

//Хрустальный меч:
//параметры:
//Мин физ. урон 5, Макс физ. Урон 10.
//Мин маг. урон 10, Макс маг. Урон 40.
//требования:
//мин Интелект 50, мин ловкость 25, мин сила 20

//8**
//Реализовать кнопку нанесения урона. Урон отображать в MessageBox.

//9***
//Реализовать шанс на критический урон и множитель критического урона.

