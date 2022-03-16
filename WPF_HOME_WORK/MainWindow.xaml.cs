﻿using System;
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

namespace WPF_HOME_WORK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user = new User("Name", "Profession");
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            User.AddToDB(Enter_a_name.Text, Enter_a_profession.Text);

            ListName.ItemsSource = User.GetNameList();
        }

        private void ListName_Loaded_1(object sender, RoutedEventArgs e)
        {
            ListName.ItemsSource = User.GetNameList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Enter_a_name.Text = user.Name;
            Enter_a_profession.Text = user.Profession;
        }

        private void ListName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListName.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                Enter_a_name.Text = User.GetUser(ListName.SelectedItem.ToString()).Name;
                Enter_a_profession.Text = User.GetUser(ListName.SelectedItem.ToString()).Profession;
            }
        }
    }
}