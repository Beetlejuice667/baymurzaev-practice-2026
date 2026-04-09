using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace baymurzaev
{
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        // Переход к маршрутам
        private void BtnViewRoutes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RoutesPage());
        }
    }
}