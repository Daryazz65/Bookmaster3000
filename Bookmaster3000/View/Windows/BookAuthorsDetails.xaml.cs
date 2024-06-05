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
    /// Логика взаимодействия для BookAuthorsDetails.xaml
    /// </summary>
    public partial class BookAuthorsDetails : Window
    {
        public BookAuthorsDetails(bookAuthor selectedBookAuthor)
        {
            InitializeComponent();
            AuthorsGrid.DataContext = selectedBookAuthor;
            AuthorCmb.ItemsSource = App.context.bookAuthor.Where(ba => ba.BookId == selectedBookAuthor.BookId).ToList();
                    }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AuthorCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bookAuthor selectedBookAuthor = AuthorCmb.SelectedItem as bookAuthor;
            AuthorsGrid.DataContext = selectedBookAuthor;
        }
    }
}
