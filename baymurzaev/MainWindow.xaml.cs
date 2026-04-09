using System;
using System.Windows;

namespace baymurzaev
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Начальная страница приложения
            MainFrame.Navigate(new autoPage());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
                MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            // Изменение: используем Collapsed вместо Hidden, 
            // чтобы интерфейс подстраивался под отсутствие кнопки
            if (MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Collapsed;
            }

            // Добавим динамическое изменение заголовка окна в зависимости от страницы
            if (MainFrame.Content is FrameworkElement element)
            {
                this.Title = $"ЦОП - {element.Tag ?? "Главная"}";
            }
        }
    }
}