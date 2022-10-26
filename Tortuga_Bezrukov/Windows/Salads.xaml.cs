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
using System.Windows.Shapes;
using Tortuga_Bezrukov.EF;

namespace Tortuga_Bezrukov.Windows
{
    /// <summary>
    /// Логика взаимодействия для Salads.xaml
    /// </summary>
    public partial class Salads : Window
    {
        public Salads()
        {
            InitializeComponent();
            AllSalads.ItemsSource = ClassHelper.Class1.context.Salad.ToList();
        }

        private void BtnBakery_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Bakery bakery = new Bakery();
            bakery.ShowDialog();
            this.Close();
        }

        private void BtnDishes_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Dishes dishes = new Dishes();
            dishes.ShowDialog();
            this.Close();
        }

        private void BtnBeverages_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Beverages beverages = new Beverages();
            beverages.ShowDialog();
            this.Close();
        }

        private void BtnBacket_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Backet backet = new Backet();
            backet.ShowDialog();
            this.Close();
        }
    }
}