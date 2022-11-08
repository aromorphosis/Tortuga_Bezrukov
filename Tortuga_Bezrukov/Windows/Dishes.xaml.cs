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
using System.Windows.Shapes;
using Tortuga_Bezrukov.ClassHelper;
using Tortuga_Bezrukov.EF;
using static Tortuga_Bezrukov.ClassHelper.Class1;

namespace Tortuga_Bezrukov.Windows
{
    /// <summary>
    /// Логика взаимодействия для Dishes.xaml
    /// </summary>
    public partial class Dishes : Window
    {
        public Dishes()
        {
            InitializeComponent();
            AllDishes.ItemsSource = context.Dish.Where(i => i.IdCategory == 3).ToList();

        }

        private void BtnBakery_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Bakery bakery = new Bakery();
            bakery.ShowDialog();
            this.Close();
        }

        private void BtnBeverages_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Beverages beverages = new Beverages();
            beverages.ShowDialog();
            this.Close();
        }

        private void BtnSalads_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Salads salads = new Salads();
            salads.ShowDialog();
            this.Close();
        }

        private void BtnBacket_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Backet backet = new Backet();
            backet.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var btnAddToCart = sender as Button;

            if (btnAddToCart == null)
                return;
            var dishes = btnAddToCart.DataContext as Dish;

            if (dishes == null)
                return;

            foreach (var item in Backet1.dishes)
            {
                if (item == dishes)
                {
                    item.Qty++;
                    Backet.FinalCost += dishes.Cost;
                    return;
                }
            }
            Backet1.dishes.Add(dishes);
        }
    }
}
