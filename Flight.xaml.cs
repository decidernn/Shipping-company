using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Flight.xaml
    /// </summary>
    public partial class Flight : Page
    {
        int id = 0;
        function fn = new function();
        СудоходнаяКомпанияEntities db = new СудоходнаяКомпанияEntities();
        public Flight()
        {
            InitializeComponent();

            var query = from Рейс in СудоходнаяКомпанияEntities.GetContext().Рейс
             join Судно in СудоходнаяКомпанияEntities.GetContext().Судно
             on Рейс.КодСудна equals Судно.Код
             join Клиент in СудоходнаяКомпанияEntities.GetContext().Клиент
             on Рейс.КодКлиента equals Клиент.Код
             join Администратор in СудоходнаяКомпанияEntities.GetContext().Администратор
             on Рейс.КодАдминистратора equals Администратор.Код
             join Статус in СудоходнаяКомпанияEntities.GetContext().Статус
             on Рейс.КодСтатуса equals Статус.Код
            select new {Рейс.Код, Судно.Марка, Администратор.ФамилияАдминистратора, Клиент.ФамилияКлиента, Клиент.ИмяКлиента, Статус.Название, Рейс.ДатаОтправления, Рейс.ДатаПрибытия, Рейс.ГородОтправления, Рейс.ГородПрибытия, Рейс.Груз, Рейс.КапитанСудна };

            FlightGrid.ItemsSource = query.ToList();
        }

        private void txtShip_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from Рейс in СудоходнаяКомпанияEntities.GetContext().Рейс
                        join Судно in СудоходнаяКомпанияEntities.GetContext().Судно
                        on Рейс.КодСудна equals Судно.Код
                        join Клиент in СудоходнаяКомпанияEntities.GetContext().Клиент
                        on Рейс.КодКлиента equals Клиент.Код
                        join Администратор in СудоходнаяКомпанияEntities.GetContext().Администратор
                        on Рейс.КодАдминистратора equals Администратор.Код
                        join Статус in СудоходнаяКомпанияEntities.GetContext().Статус
                        on Рейс.КодСтатуса equals Статус.Код
                        select new { Рейс.Код, Судно.Марка, Администратор.ФамилияАдминистратора, Клиент.ФамилияКлиента, Клиент.ИмяКлиента, Статус.Название, Рейс.ДатаОтправления, Рейс.ДатаПрибытия, Рейс.ГородОтправления, Рейс.ГородПрибытия, Рейс.Груз, Рейс.КапитанСудна };

            FlightGrid.ItemsSource = query.Where(item => item.Марка == txtShip.Text || item.Марка.Contains(txtShip.Text)).ToList();
        }

        private void txtCity_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from Рейс in СудоходнаяКомпанияEntities.GetContext().Рейс
                        join Судно in СудоходнаяКомпанияEntities.GetContext().Судно
                        on Рейс.КодСудна equals Судно.Код
                        join Клиент in СудоходнаяКомпанияEntities.GetContext().Клиент
                        on Рейс.КодКлиента equals Клиент.Код
                        join Администратор in СудоходнаяКомпанияEntities.GetContext().Администратор
                        on Рейс.КодАдминистратора equals Администратор.Код
                        join Статус in СудоходнаяКомпанияEntities.GetContext().Статус
                        on Рейс.КодСтатуса equals Статус.Код
                        select new { Рейс.Код, Судно.Марка, Администратор.ФамилияАдминистратора, Клиент.ФамилияКлиента, Клиент.ИмяКлиента, Статус.Название, Рейс.ДатаОтправления, Рейс.ДатаПрибытия, Рейс.ГородОтправления, Рейс.ГородПрибытия, Рейс.Груз, Рейс.КапитанСудна };

            FlightGrid.ItemsSource = query.Where(item => item.ГородПрибытия == txtCity.Text || item.ГородПрибытия.Contains(txtCity.Text)).ToList();
        }

        private void txtStatus_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from Рейс in СудоходнаяКомпанияEntities.GetContext().Рейс
                        join Судно in СудоходнаяКомпанияEntities.GetContext().Судно
                        on Рейс.КодСудна equals Судно.Код
                        join Клиент in СудоходнаяКомпанияEntities.GetContext().Клиент
                        on Рейс.КодКлиента equals Клиент.Код
                        join Администратор in СудоходнаяКомпанияEntities.GetContext().Администратор
                        on Рейс.КодАдминистратора equals Администратор.Код
                        join Статус in СудоходнаяКомпанияEntities.GetContext().Статус
                        on Рейс.КодСтатуса equals Статус.Код
                        select new { Рейс.Код, Судно.Марка, Администратор.ФамилияАдминистратора, Клиент.ФамилияКлиента, Клиент.ИмяКлиента, Статус.Название, Рейс.ДатаОтправления, Рейс.ДатаПрибытия, Рейс.ГородОтправления, Рейс.ГородПрибытия, Рейс.Груз, Рейс.КапитанСудна };

            FlightGrid.ItemsSource = query.Where(item => item.Название == txtStatus.Text || item.Название.Contains(txtStatus.Text)).ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddFlight());
        }

        private void btnReset1_Click(object sender, RoutedEventArgs e)
        {
            if (txtShip.Text.Length > 0)
            {
                txtShip.Text = "";
            } else
            {
                MessageBox.Show("Поле не заполнено!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnReset3_Click(object sender, RoutedEventArgs e)
        {
            if (txtStatus.Text.Length > 0)
            {
                txtStatus.Text = "";
            }
            else
            {
                MessageBox.Show("Поле не заполнено!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnReset2_Click(object sender, RoutedEventArgs e)
        {
            if (txtCity.Text.Length > 0)
            {
                txtCity.Text = "";
            }
            else
            {
                MessageBox.Show("Поле не заполнено!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var removing = FlightGrid.SelectedItems.Cast<Рейс>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {removing.Count} элемент(а)?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    СудоходнаяКомпанияEntities.GetContext().Рейс.RemoveRange(removing);
                    СудоходнаяКомпанияEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    FlightGrid.ItemsSource = СудоходнаяКомпанияEntities.GetContext().Рейс.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            FlightGrid.ItemsSource = СудоходнаяКомпанияEntities.GetContext().Рейс.ToList();
            MessageBox.Show("Информация обновлена!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new EditFlights());
        }

        private void FlightGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Menu());
        }
    }
}
