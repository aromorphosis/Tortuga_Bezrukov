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
using Tortuga_Bezrukov;
using static Tortuga_Bezrukov.ClassHelper.Backet1;
using Tortuga_Bezrukov.ClassHelper;

namespace Tortuga_Bezrukov.Windows
{
    /// <summary>
    /// Логика взаимодействия для Backet.xaml
    /// </summary>
    public partial class Backet : Window
    {

        public Backet()
        {
            InitializeComponent();
            lvOrder.SelectedItem = Backet1.dishes.ToList();
        }

        private void PaymentBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.ShowDialog();
            this.Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Bakery bakery = new Bakery();
            bakery.ShowDialog();
            this.Close();
        }

    }
}
