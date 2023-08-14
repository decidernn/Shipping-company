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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudCompany
{
    /// <summary>
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Page
    {
        СудоходнаяКомпанияEntities db = new СудоходнаяКомпанияEntities();
        public List<Клиент> Клиентs { get; set; }
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnAddFlight_Click(object sender, RoutedEventArgs e)
        {
            Клиент k = new Клиент();

            k.ИмяКлиента = txtName.Text;
            k.ФамилияКлиента = txtSurname.Text;
            k.ОтчествоКлиента = txtPath.Text;
            k.НомерТелефона = txtPhone.Text;
            k.Паспорт = txtPassport.Text;

            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errors.AppendLine("Введите имя клиента!");
            }
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                errors.AppendLine("Введите фамилию клиента!");
            }
            if (string.IsNullOrWhiteSpace(txtPath.Text))
            {
                errors.AppendLine("Введите отчество клиента!");
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errors.AppendLine("Введите номер телефона клиента!");
            }
            if (string.IsNullOrWhiteSpace(txtPassport.Text))
            {
                errors.AppendLine("Введите номер паспорта клиента!");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Заполнены не все поля!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                db.Клиент.Add(k);
                db.SaveChanges();
                MessageBox.Show("Данные успешно сохранены!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Clients());
        }
    }
}
