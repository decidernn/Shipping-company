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
    /// Логика взаимодействия для Ship.xaml
    /// </summary>
    public partial class Ship : Page
    {
        СудоходнаяКомпанияEntities db = new СудоходнаяКомпанияEntities();
        public Ship()
        {
            InitializeComponent();

            ShipGrid.ItemsSource = СудоходнаяКомпанияEntities.GetContext().Судно.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddShip());
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var removing = ShipGrid.SelectedItems.Cast<Судно>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {removing.Count} элемент(а)?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    СудоходнаяКомпанияEntities.GetContext().Судно.RemoveRange(removing);
                    СудоходнаяКомпанияEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    ShipGrid.ItemsSource = СудоходнаяКомпанияEntities.GetContext().Судно.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }
            }
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new EditShip());
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ShipGrid.ItemsSource = СудоходнаяКомпанияEntities.GetContext().Судно.ToList();
            MessageBox.Show("Информация обновлена!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void txtShip_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShipGrid.ItemsSource = СудоходнаяКомпанияEntities.GetContext().Судно.Where(item => item.Марка == txtShip.Text || item.Марка.Contains(txtShip.Text)).ToList();
        }

        private void ShipGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Menu());
        }
    }
}
