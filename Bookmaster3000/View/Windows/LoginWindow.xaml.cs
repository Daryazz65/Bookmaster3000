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
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTb.Text == "administrator")
            {
                if (PasswordTb.Password == "admin123")
                {
                    DialogResult = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("неправильно введен пароль!!!");
                }
            }
            else
            {
                MessageBox.Show("пользователь с данными данными не найден!! !");
            }
        }
    }
}
