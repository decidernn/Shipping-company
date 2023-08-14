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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudCompany
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        СудоходнаяКомпанияEntities db = new СудоходнаяКомпанияEntities();
        public Auth()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                errors.AppendLine("Введите логин!");
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Password))
            {
                errors.AppendLine("Введите пароль!");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            var account = db.Администратор.AsNoTracking().FirstOrDefault(a => a.ЛогинАдминистратора == txtLogin.Text && a.Пароль == txtPassword.Password);

            if (account == null)
            {
                MessageBox.Show("Пользователь с такими данными не найден!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Добро пожаловать в систему!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);

            Menu m = new Menu();
            Manager.MainFrame.Navigate(m);
        }
    }
}
