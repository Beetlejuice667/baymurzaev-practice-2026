using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace baymurzaev
{
    public partial class autoPage : Page
    {
        public autoPage()
        {
            InitializeComponent();
        }

        private void BtnViewRoutes_Click(object sender, RoutedEventArgs e)
        {
            // Переход к таблице
            NavigationService.Navigate(new RoutesPage());
        }
    }
}