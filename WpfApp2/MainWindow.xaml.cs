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

        double currentStrength;
        double currentAgility;
        double currentIntelligence;
        double currentEndurance;

        private void ArchersIndicators()
        {
            currentStrength = Convert.ToDouble(Strength.Content);
            currentAgility = Convert.ToDouble(Agility.Content);
            currentIntelligence = Convert.ToDouble(Intelligence.Content);
            currentEndurance = Convert.ToDouble(Endurance.Content);

            life.Content = currentStrength * 2 + currentEndurance * 5;
            physicDefense.Content = currentStrength * 1 + currentAgility * 5 + currentEndurance * 2;
            physicDamage.Content = currentStrength * 3 + currentAgility * 7;
            magicDefense.Content = currentAgility * 3 + currentIntelligence * 3 + currentEndurance * 1;
            magicDamage.Content = currentIntelligence * 3;
            mana.Content = currentIntelligence * 1;
        }
        private void MagesIndicators()
        {
            currentStrength = Convert.ToDouble(Strength.Content);
            currentAgility = Convert.ToDouble(Agility.Content);
            currentIntelligence = Convert.ToDouble(Intelligence.Content);
            currentEndurance = Convert.ToDouble(Endurance.Content);

            life.Content = currentStrength + currentIntelligence + currentEndurance * 3;
            physicDefense.Content = currentStrength + currentAgility + currentEndurance * 2;
            physicDamage.Content = currentStrength + currentAgility;
            magicDefense.Content = currentIntelligence * 5 + currentEndurance;
            magicDamage.Content = currentIntelligence * 7;
            mana.Content = currentIntelligence * 2;
        }
        private void WarriorsIndicators()
        {
            currentStrength = Convert.ToDouble(Strength.Content);
            currentAgility = Convert.ToDouble(Agility.Content);
            currentIntelligence = Convert.ToDouble(Intelligence.Content);
            currentEndurance = Convert.ToDouble(Endurance.Content);

            life.Content = currentStrength * 5 + currentEndurance * 10;
            physicDefense.Content = currentStrength * 2 + currentAgility * 3 + currentEndurance * 3;
            physicDamage.Content = currentStrength * 7 + currentAgility * 2;
            magicDefense.Content = currentStrength + currentIntelligence * 2 + currentEndurance;
            magicDamage.Content = currentIntelligence;
            mana.Content = currentIntelligence;
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
                ArchersIndicators();
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
                MagesIndicators();
            }
            if (professions.SelectedIndex == 2)
            {
                ChosenProfession.Text = "Warrior";
                points.Content = 10;
                Strength.Content = warrior.CurrentStrength; 
                Agility.Content = warrior.CurrentAgility;
                Intelligence.Content = warrior.CurrentIntelligence; 
                Endurance.Content = warrior.CurrentEndurance;
                WarriorsIndicators();
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
                savedСharacters_Loaded(sender, e);

                if (ChosenProfession.Text == "Archer")
                {
                    Name.Text = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).Name;
                    ChosenProfession.Text = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).Proffesion;
                    Strength.Content = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).CurrentStrength;
                    Agility.Content = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).CurrentAgility;
                    Intelligence.Content = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).CurrentIntelligence;
                    Endurance.Content = MongoDB.GetArcher(savedСharacters.SelectedItem.ToString()).CurrentEndurance;
                    ArchersIndicators();
                }

                else if (ChosenProfession.Text == "Mage")
                {

                    Name.Text = MongoDB.GetMage(savedСharacters.SelectedItem.ToString()).Name;
                    ChosenProfession.Text = MongoDB.GetMage(savedСharacters.SelectedItem.ToString()).Proffesion;
                    Strength.Content = MongoDB.GetMage(savedСharacters.SelectedItem.ToString()).CurrentStrength;
                    Agility.Content = MongoDB.GetMage(savedСharacters.SelectedItem.ToString()).CurrentAgility;
                    Intelligence.Content = MongoDB.GetMage(savedСharacters.SelectedItem.ToString()).CurrentIntelligence;
                    Endurance.Content = MongoDB.GetMage(savedСharacters.SelectedItem.ToString()).CurrentEndurance;
                    MagesIndicators();

                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    Name.Text = MongoDB.GetWarrior(savedСharacters.SelectedItem.ToString()).Name;
                    ChosenProfession.Text = MongoDB.GetWarrior(savedСharacters.SelectedItem.ToString()).Proffesion;
                    Strength.Content = MongoDB.GetWarrior(savedСharacters.SelectedItem.ToString()).CurrentStrength;
                    Agility.Content = MongoDB.GetWarrior(savedСharacters.SelectedItem.ToString()).CurrentAgility;
                    Intelligence.Content = MongoDB.GetWarrior(savedСharacters.SelectedItem.ToString()).CurrentIntelligence;
                    Endurance.Content = MongoDB.GetWarrior(savedСharacters.SelectedItem.ToString()).CurrentEndurance;
                    WarriorsIndicators();
                }
            }
        }
       
        private void StrengthPointsPlus_Click(object sender, RoutedEventArgs e)
        {
            double basePoints = Convert.ToDouble(points.Content);
            currentStrength++;
            basePoints--;
            Strength.Content = currentStrength.ToString();
            points.Content = basePoints.ToString();

            if (basePoints > 0)
            {
                if (ChosenProfession.Text == "Archer")
                {
                    if (currentStrength > 55)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Strength.Content = archer.CurrentStrength;
                    }
                    else
                    {
                        archer.CurrentStrength = currentStrength;
                        ArchersIndicators();
                    }
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    if (currentStrength > 45)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Strength.Content = mage.CurrentStrength;
                    }
                    mage.CurrentStrength = currentStrength;
                    MagesIndicators();
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    if (currentStrength > 50)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Strength.Content = warrior.CurrentStrength;
                    }
                    warrior.CurrentStrength = currentStrength;
                    WarriorsIndicators();                   
                }
            }
            else
            {
                MessageBox.Show("Point is empty!");
            }
        }

        private void AgilityPointsPlus_Click(object sender, RoutedEventArgs e)
        {
           double basePoints = Convert.ToDouble(points.Content);
            currentAgility++;
            basePoints--;
            Agility.Content = currentAgility.ToString();
            points.Content = basePoints.ToString();
            if (basePoints > 0)
            {
                if (ChosenProfession.Text == "Archer")
                {
                    if (currentAgility > 250)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Agility.Content = archer.CurrentAgility;
                    }
                    archer.CurrentAgility = currentAgility;
                    ArchersIndicators();
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    if (currentAgility > 45)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Agility.Content = mage.CurrentAgility;
                    }
                    mage.CurrentAgility = currentAgility;
                    MagesIndicators();
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    if (currentAgility > 80)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Agility.Content = warrior.CurrentAgility;
                    }
                    warrior.CurrentAgility = currentAgility;
                    WarriorsIndicators();
                }
            }
            else
            {
                MessageBox.Show("Point is empty!");
            }
        }

        private void IntelligencePointsPlus_Click(object sender, RoutedEventArgs e)
        {
            double basePoints = Convert.ToDouble(points.Content);
            currentIntelligence++;
            basePoints--;
            Intelligence.Content = currentIntelligence.ToString();
            points.Content = basePoints.ToString();
            if (basePoints > 0)
            {
                if (ChosenProfession.Text == "Archer")
                {
                    if (currentIntelligence > 70)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Intelligence.Content = archer.CurrentIntelligence;
                    }
                    archer.CurrentIntelligence = currentIntelligence;
                    ArchersIndicators();
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    if (currentIntelligence > 250)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        mage.CurrentIntelligence = mage.CurrentIntelligence;
                    }
                    mage.CurrentIntelligence = currentIntelligence;
                    MagesIndicators();
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    if ( currentIntelligence > 50)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Intelligence.Content = warrior.CurrentIntelligence;
                    }
                    warrior.CurrentIntelligence = currentIntelligence;
                    WarriorsIndicators();
                }
            }
            else
            {
                MessageBox.Show("Point is empty!");
            }
        }

        private void EndurancePointsPlus_Click(object sender, RoutedEventArgs e)
        {
            double basePoints = Convert.ToDouble(points.Content);
            currentEndurance++;
            basePoints--;
            Endurance.Content = currentEndurance.ToString();
            points.Content = basePoints.ToString();
            if (basePoints > 0)
            {
                if (ChosenProfession.Text == "Archer")
                {
                    if (currentEndurance > 80)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Endurance.Content = archer.CurrentEndurance;
                    }
                    archer.CurrentEndurance = currentEndurance;
                    ArchersIndicators();
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    if (currentEndurance > 80)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Endurance.Content = mage.CurrentEndurance;
                    }
                    mage.CurrentEndurance = currentEndurance;
                    MagesIndicators();
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    if (currentEndurance > 100)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Endurance.Content = warrior.CurrentEndurance;
                    }
                    warrior.CurrentEndurance = currentEndurance;
                    WarriorsIndicators();
                }
            }
            else
            {
                MessageBox.Show("Point is empty!");
            }
        }

        private void StrengthPointsMinus_Click(object sender, RoutedEventArgs e)
        {
            double basePoints = Convert.ToDouble(points.Content);
            currentStrength--;
            basePoints++;
            Strength.Content = currentStrength.ToString();
            points.Content = basePoints.ToString();
            if (basePoints < 10)
            {
                if (ChosenProfession.Text == "Archer")
                {
                    if (currentStrength < 20 )
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Strength.Content = archer.CurrentStrength;
                    }
                    archer.CurrentStrength = currentStrength;
                    ArchersIndicators();
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    if (currentStrength < 15)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Strength.Content = mage.CurrentStrength;
                    }
                    mage.CurrentStrength = currentStrength;
                    MagesIndicators();
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    if (currentStrength < 30)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Strength.Content = warrior.CurrentStrength;
                    }
                    warrior.CurrentStrength = currentStrength;
                    WarriorsIndicators();
                }
            }
            else
            {
                MessageBox.Show("Can't be taken away at the minimum value!");
            }
        }

        private void AgilityPointsMinus_Click(object sender, RoutedEventArgs e)
        {
            double basePoints = Convert.ToDouble(points.Content);
            currentAgility--;
            basePoints++;
            Agility.Content = currentAgility.ToString();
            points.Content = basePoints.ToString();
            if (basePoints < 10)
            {
                if (ChosenProfession.Text == "Archer")
                {
                    if (currentAgility < 30 )
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Agility.Content = archer.CurrentAgility;
                    }
                    archer.CurrentAgility = currentAgility;
                    ArchersIndicators();
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    if (currentAgility < 20 )
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Agility.Content = mage.CurrentAgility;

                    }
                    mage.CurrentAgility = currentAgility;
                    MagesIndicators();
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    if (currentAgility < 15)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Agility.Content = warrior.CurrentAgility;
                    }
                    warrior.CurrentAgility = currentAgility;
                    WarriorsIndicators();
                }
            }
            else
            {
                MessageBox.Show("Can't be taken away at the minimum value!");
            }
        }

        private void IntelligencePointsMinus_Click(object sender, RoutedEventArgs e)
        {
            double basePoints = Convert.ToDouble(points.Content);
            currentIntelligence--;
            basePoints++;
            Intelligence.Content = currentIntelligence.ToString();
            points.Content = basePoints.ToString();
            if (basePoints < 10)
            {
                if (ChosenProfession.Text == "Archer")
                {
                    if (currentIntelligence < 15 )
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Intelligence.Content = archer.CurrentIntelligence;
                    }
                    archer.CurrentIntelligence = currentIntelligence;
                    ArchersIndicators();
                }
                else if (ChosenProfession.Text == "Mage")
                {
                    if (currentIntelligence < 35 )
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Intelligence.Content = mage.CurrentIntelligence;
                    }
                    mage.CurrentIntelligence = currentIntelligence;
                    MagesIndicators();
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    if (currentIntelligence < 10 )
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Intelligence.Content = warrior.CurrentIntelligence;
                    }
                    warrior.CurrentIntelligence = currentIntelligence;
                    WarriorsIndicators();
                }
            }
            else
            {
                MessageBox.Show("Can't be taken away at the minimum value!");
            }
        }

        private void EndurancePointsMinus_Click(object sender, RoutedEventArgs e)
        { 
            double basePoints = Convert.ToDouble(points.Content);
            currentEndurance--;
            basePoints++;
            Endurance.Content = currentEndurance.ToString();
            points.Content = basePoints.ToString();
            if (basePoints < 10)
            {
                if (ChosenProfession.Text == "Archer")
                {
                    if (currentEndurance < 20)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Endurance.Content = archer.CurrentEndurance;
                    }
                    archer.CurrentEndurance = currentEndurance;
                    ArchersIndicators();
                }
               else if (ChosenProfession.Text == "Mage")
                {
                    if (currentEndurance < 20)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Endurance.Content = mage.CurrentEndurance;
                    }
                    mage.CurrentEndurance = currentEndurance;
                    MagesIndicators();
                }
                else if (ChosenProfession.Text == "Warrior")
                {
                    if (currentEndurance < 25)
                    {
                        MessageBox.Show(" It is impossible to make less than the minimum and maximum values!");
                        Endurance.Content = warrior.CurrentEndurance;
                    }
                    warrior.CurrentEndurance = currentEndurance;
                    WarriorsIndicators();
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
            MongoDB.DeletingWarrior(savedСharacters.SelectedItem.ToString());
            MessageBox.Show($"{savedСharacters.SelectedItem} Deleted!");
            savedСharacters.ItemsSource = MongoDB.WarriorGetList();
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

