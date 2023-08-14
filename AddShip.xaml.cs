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
using System.Xml.Linq;

namespace SudCompany
{
    /// <summary>
    /// Логика взаимодействия для AddShip.xaml
    /// </summary>
    public partial class AddShip : Page
    {
        СудоходнаяКомпанияEntities db = new СудоходнаяКомпанияEntities();
        public List<Судно> Судноs { get; set; }
        public AddShip()
        {
            InitializeComponent();
        }
        public static Boolean IsNumeric(string stringToTest)
        {
            int result;
            return int.TryParse(stringToTest, out result);
        }

        private void btnAddFlight_Click(object sender, RoutedEventArgs e)
        {
            Судно s = new Судно();

            s.Марка = txtMark.Text;
            s.Грузоподъемность = Convert.ToInt32(txtMaxx.Text);
            s.ГодВыпуска = Convert.ToInt32(txtYearOfBurn.Text);

            StringBuilder errors = new StringBuilder();

            if(IsNumeric(txtMaxx.Text) == false)
            {
                errors.AppendLine("Грузоподъемность должна быть числом!");
            }

            if (string.IsNullOrEmpty(txtMark.Text))
            {
                errors.AppendLine("Введите марку судна!");
            }
            if (string.IsNullOrWhiteSpace(txtMaxx.Text))
            {
                errors.AppendLine("Введите грузоподъемность судна!");
            }
            if (string.IsNullOrWhiteSpace(txtYearOfBurn.Text))
            {
                errors.AppendLine("Введите год выпуска судна!");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Заполнены не все поля!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                db.Судно.Add(s);
                db.SaveChanges();
                MessageBox.Show("Данные успешно сохранены!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Ship());
        }
    }
}
