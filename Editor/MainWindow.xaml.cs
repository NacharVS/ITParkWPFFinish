using MongoDB.Driver;
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

namespace Editor
{
   

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Рersonage CurrentPersonage;
        public Рersonage SelectPersonageFromDataBase;
        public List<Рersonage> PersonagesDataBase;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateGraph()
        {
            NameInput.Text = CurrentPersonage.Name;
            Radio1.IsChecked = CurrentPersonage.CharacterType == "Воин" ? true : false;
            Radio2.IsChecked = CurrentPersonage.CharacterType == "Лучник" ? true : false;
            Radio3.IsChecked = CurrentPersonage.CharacterType == "Волшебник" ? true : false;

            strengthTextBlock.Text = CurrentPersonage.Strength.ToString();
            agilityTextBlock.Text = CurrentPersonage.Agility.ToString();
            intelligenceTextBlock.Text = CurrentPersonage.Intelligence.ToString();
            EndureTextBlock.Text = CurrentPersonage.Endure.ToString();

            physicalDamageTxt.Text = CurrentPersonage.РhysicalDamage.ToString();
            physicalProtectionTxt.Text = CurrentPersonage.PhysicalProtection.ToString();
            magicDamageTxt.Text = CurrentPersonage.MagicDamage.ToString();
            magicProtectionTxt.Text = CurrentPersonage.MagicProtection.ToString();
            lifeTxt.Text = CurrentPersonage.Life.ToString();
            magicTxt.Text = CurrentPersonage.Magic.ToString();

            remainderPointsTxt.Text = CurrentPersonage.CountRemainderPoints.ToString();
            levelTxt.Text = CurrentPersonage.Level.ToString();
            experienceTxt.Text = CurrentPersonage.Experience.ToString();
        }

        private void UpdateDataBaseList()
        {
            ShowDataBaseList();
        }

        private void NameInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowDataBaseList();
        }

        public void ShowDataBaseList()
        {
            PersonagesDataBase = new List<Рersonage>();
            personageListBox.Items.Clear();

            List<Warrior> listWarrior = new List<Warrior>();
            List<Archer> listArcher = new List<Archer>();
            List<Magician> listMagician = new List<Magician>();

            listWarrior = MongoAPI.GetWarriorFromDataBase();
            listArcher = MongoAPI.GetArcherFromDataBase();
            listMagician = MongoAPI.GetMagicianFromDataBase();

            foreach (var warrior in listWarrior)
            {
                PersonagesDataBase.Add(warrior);
            }

            foreach (var archer in listArcher)
            {
                PersonagesDataBase.Add(archer);
            }

            foreach (var magician in listMagician)
            {
                PersonagesDataBase.Add(magician);
            }

            foreach (var personage in PersonagesDataBase)
            {
                personageListBox.Items.Add(personage.Name);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //MessageBox.Show("До новых встреч :)");
        }

        private void NameInput_GotFocus(object sender, RoutedEventArgs e)
        {
            NameInput.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Save(object sender, RoutedEventArgs e)
        {
            MongoAPI.AddPersonageToDataBase(CurrentPersonage);
            personageListBox.Items.Add(CurrentPersonage.Name);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CurrentPersonage.ExperienceIncrease(3000);
            UpdateGraph();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MongoAPI.EditPersonageToDataBase(SelectPersonageFromDataBase, SelectPersonageFromDataBase.ComparisonObjects(CurrentPersonage));
            ShowDataBaseList();
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            CurrentPersonage = new Warrior(NameInput.Text, 1, 10);
            UpdateGraph();
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            CurrentPersonage = new Archer(NameInput.Text, 1, 10);
            UpdateGraph();
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            CurrentPersonage = new Magician(NameInput.Text, 1, 10);
            UpdateGraph();
        }

        private void IncreaseBtn1_Click(object sender, RoutedEventArgs e)
        {
            CurrentPersonage.PointsStrengthIncrease();
            UpdateGraph();
        }

        private void IncreaseBtn2_Click(object sender, RoutedEventArgs e)
        {
            CurrentPersonage.PointsAgilityIncrease();
            UpdateGraph();
        }

        private void IncreaseBtn3_Click(object sender, RoutedEventArgs e)
        {
            CurrentPersonage.PointsIntelligenceIncrease();
            UpdateGraph();

        }

        private void IncreaseBtn4_Click(object sender, RoutedEventArgs e)
        {
            CurrentPersonage.PointsEndureIncrease();
            UpdateGraph();
        }

        private void DecreaseBtn1_Click(object sender, RoutedEventArgs e)
        {
            CurrentPersonage.PointsStrengthDecrease();
            UpdateGraph();
        }

        private void DecreaseBtn2_Click(object sender, RoutedEventArgs e)
        {
            CurrentPersonage.PointsAgilityDecrease();
            UpdateGraph();
        }

        private void DecreaseBtn4_Click(object sender, RoutedEventArgs e)
        {
            CurrentPersonage.PointsEndureDecrease();
            UpdateGraph();
        }

        private void DecreaseBtn3_Click(object sender, RoutedEventArgs e)
        {
            CurrentPersonage.PointsIntelligenceDecrease();
            UpdateGraph();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CurrentPersonage.ExperienceIncrease(1000);
            UpdateGraph();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            CurrentPersonage.ExperienceIncrease(5000);
            UpdateGraph();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MongoAPI.DeletePersanageFromDataBase(SelectPersonageFromDataBase);
            UpdateDataBaseList();
        }

        private void personageListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(personageListBox.SelectedIndex >= 0)
            {
                CurrentPersonage = PersonagesDataBase[personageListBox.SelectedIndex];
                SelectPersonageFromDataBase = PersonagesDataBase[personageListBox.SelectedIndex];
                UpdateGraph();
            }

            personageListBox.SelectedIndex = -1;
        }

        private void PersonageListBox_Selected(object sender, RoutedEventArgs e)
        {
            if (personageListBox.SelectedIndex >= 0)
            {
                CurrentPersonage = PersonagesDataBase[personageListBox.SelectedIndex];
                SelectPersonageFromDataBase = PersonagesDataBase[personageListBox.SelectedIndex];
                UpdateGraph();
            }
            personageListBox.SelectedIndex = -1;
        }
    }
}
