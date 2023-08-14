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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Manager.MainFrame = MainFrame;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            Manager.MainFrame.Navigate(new Auth());

            btnStart.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Hidden;
            mainImage.Visibility = Visibility.Hidden;
        }
    }
}
