using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace baymurzaev
{
    /// <summary>
    /// Логика взаимодействия для RoutesPage.xaml
    /// </summary>
    public partial class RoutesPage : Page
    {
        public RoutesPage()
        {
            InitializeComponent();

            // Загружаем данные при открытии страницы
            UpdateData();
        }

        /// <summary>
        /// Метод для обновления и фильтрации данных
        /// </summary>
        private void UpdateData()
        {
            // 1. Получаем контекст базы данных через статический метод GetContext
            // Это исправляет ошибку CS0117.
            var context = baymurzaevEntities.GetContext();

            // 2. Извлекаем список маршрутов из таблицы
            var currentRoutes = context.Маршруты.ToList();

            // 3. Реализуем поиск (фильтрацию)
            // Важно: используем поле "Название", так как "Начальная_точка" отсутствует в твоей базе.
            if (!string.IsNullOrWhiteSpace(TBoxSearch.Text))
            {
                currentRoutes = currentRoutes.Where(p => p.Название.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
            }

            // 4. Привязываем данные к элементу управления LBoxRoutes (вместо DataGrid)
            // Это обеспечит отображение в виде современных карточек.
            LBoxRoutes.ItemsSource = currentRoutes;

            // 5. Обновляем счетчик записей
            TBlockCount.Text = $"Найдено маршрутов: {currentRoutes.Count}";
        }

        /// <summary>
        /// Обработчик изменения текста в поле поиска
        /// </summary>
        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            // При каждом вводе символа обновляем список
            UpdateData();
        }

        // Если ты добавишь кнопки "Изменить" или "Удалить" в карточки, 
        // обработчики событий Click можно будет добавить сюда.
    }
}