using Bookmaster3000.Models;
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

namespace Bookmaster3000.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для BrowseCatalogWindow.xaml
    /// </summary>
    public partial class BrowseCatalogWindow : Window
    {
        public BrowseCatalogWindow()
        {
            InitializeComponent();

            // Загружаем данные из бд в ЛВ.
            BookAuthorLv.ItemsSource = App.context.bookAuthor.ToList();

            CountOfPagesTbl.DataContext = App.context.book.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitMI_Click(object sender, RoutedEventArgs e)
        {

        }
        // Событие SelectionChange отслеживает изменение выбора элемента в списке.
        private void BookAuthorLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Передача информации из выбранного элемента.
            // 1) Добавляем в контекст данных выбранный элемент из списка ListView.
            BookDetailsGrid.DataContext = BookAuthorLv.SelectedItem as bookAuthor;
            // 2) В XAML-коде реализовываем привязку данных.

        }
    }
}
