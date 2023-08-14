using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для AddFlight.xaml
    /// </summary>
    public partial class AddFlight : Page
    {
        СудоходнаяКомпанияEntities db = new СудоходнаяКомпанияEntities();
        public List<Судно> Судноs { get; set; }
        public List<Администратор> Администраторs { get; set; }
        public List<Клиент> Клиентs { get; set; }
        public List<Статус> Статусs { get; set; }

        int idship;
        int idadmin;
        int idclient;


        public AddFlight()
        {
            InitializeComponent();

            bindcombo1();
            bindcombo2();
            bindcombo3();

            lblStatus.Visibility = Visibility.Hidden;
            comboStatus.Visibility = Visibility.Hidden;
        }

        private void bindcombo1()
        {
            var item = db.Судно.ToList();
            Судноs = item;
            comboShip.DataContext = Судноs;
        }

        private void bindcombo2()
        {
            var item = db.Клиент.ToList();
            Клиентs = item;
            comboClient.DataContext = Клиентs;
        }

        private void bindcombo3()
        {
            var item = db.Администратор.ToList();
            Администраторs = item;
            comboAdmin.DataContext = Администраторs;
        }

        private void bindcombo4()
        {
            var item = db.Статус.ToList();
            Статусs = item;
            comboStatus.DataContext = Статусs;
        }

        private void btnAddFlight_Click(object sender, RoutedEventArgs e)
        {
            Рейс flight = new Рейс();

            flight.КодСудна = idship;
            flight.КодАдминистратора = idadmin;
            flight.КодКлиента = idclient;
            flight.КодСтатуса = 1;
            flight.ДатаОтправления = DatePickerOut.SelectedDate.Value;
            flight.ДатаПрибытия = DatePickerIn.SelectedDate.Value;
            flight.ГородОтправления = txtCityOut.Text;
            flight.ГородПрибытия = txtCityIn.Text;
            flight.Груз = txtCargo.Text;
            flight.КапитанСудна = txtCapitaneOfShip.Text;

            StringBuilder errors = new StringBuilder();

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Заполнены не все поля!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                db.Рейс.Add(flight);
                db.SaveChanges();
                MessageBox.Show("Данные успешно сохранены!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void comboShip_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = comboShip.SelectedItem as Судно;
            idship = item.Код;
        }

        private void comboAdmin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = comboAdmin.SelectedItem as Администратор;
            idadmin = item.Код;
        }

        private void comboClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = comboClient.SelectedItem as Клиент;
            idclient = item.Код;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Flight());
        }
    }
}
