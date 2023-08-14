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
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Page
    {
        СудоходнаяКомпанияEntities db = new СудоходнаяКомпанияEntities();
        public Clients()
        {
            InitializeComponent();

            ClientGrid.ItemsSource = СудоходнаяКомпанияEntities.GetContext().Клиент.ToList();
        }

        private void txtShip_TextChanged(object sender, TextChangedEventArgs e)
        {
            ClientGrid.ItemsSource = СудоходнаяКомпанияEntities.GetContext().Клиент.Where(item => item.ФамилияКлиента == txtShip.Text || item.ФамилияКлиента.Contains(txtShip.Text)).ToList();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ClientGrid.ItemsSource = СудоходнаяКомпанияEntities.GetContext().Клиент.ToList();
            MessageBox.Show("Информация обновлена!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new EditClient());
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var removing = ClientGrid.SelectedItems.Cast<Клиент>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {removing.Count} элемент(а)?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    СудоходнаяКомпанияEntities.GetContext().Клиент.RemoveRange(removing);
                    СудоходнаяКомпанияEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    ClientGrid.ItemsSource = СудоходнаяКомпанияEntities.GetContext().Клиент.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddClient());
        }

        private void btnReset1_Click(object sender, RoutedEventArgs e)
        {
            if (txtShip.Text.Length > 0)
            {
                txtShip.Text = "";
            }
            else
            {
                MessageBox.Show("Поле не заполнено!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ClientGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Menu());
        }
    }
}
