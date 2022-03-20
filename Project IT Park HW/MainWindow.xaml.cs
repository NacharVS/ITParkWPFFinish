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

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (cmbClass.SelectedIndex == 0)
                MongoDataBase.AddArcherToDB(txtName.Text, cmbClass.SelectionBoxItem.ToString()), Convert.ToInt32(lblStrength.Content), Convert.ToInt32(lblAgility.Content), Convert.ToInt32(lblIntellect.Content), Convert.ToInt32(lblEndurance.Content)
                        , Convert.ToInt32(levelAmountLabel.Content), Convert.ToInt64(experienseAmountLabel.Content)
                        , Convert.ToInt32(freePointAmountLabel.Content)); ;
            UnitList.ItemsSource = MongoDataBase.GetUnitList();
            UnitClass.ItemsSource = MongoDataBase.GetClassList();
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




