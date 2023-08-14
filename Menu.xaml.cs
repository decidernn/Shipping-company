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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnFlight_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Flight());
        }

        private void btnAccounts_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Clients());
        }

        private void btnShip_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Ship());
        }
    }
}
