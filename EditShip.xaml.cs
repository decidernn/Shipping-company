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
using System.Xml.Linq;

namespace SudCompany
{
    /// <summary>
    /// Логика взаимодействия для EditShip.xaml
    /// </summary>
    public partial class EditShip : Page
    {
        public List<Судно> Судноs { get; set; }
        string query;
        function fn = new function();
        public EditShip()
        {
            InitializeComponent();

            query = "SELECT distinct Код FROM Судно";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            
        }

        private void comboSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            query = "select * FROM Судно WHERE Код = '" + comboSet.SelectedValue + "'";

            DataSet ds = fn.getData(query);

            txtMark.Text = ds.Tables[0].Rows[0][1].ToString();
            txtMaxx.Text = ds.Tables[0].Rows[0][2].ToString();
            txtYearOfBurn.Text = ds.Tables[0].Rows[0][3].ToString();
        }

        private void btnAddFlight_Click(object sender, RoutedEventArgs e)
        {
            if (comboSet.SelectedIndex != -1)
            {
                query = "UPDATE Судно SET Марка = '" + txtMark.Text + "', Грузоподъемность = '" + txtMaxx.Text + "',  ГодВыпуска = '" + txtYearOfBurn.Text + "' WHERE Код = '" + comboSet.SelectedIndex + 1 + "'";
                fn.setData(query, "Информация обновлена!");

            }
            else
            {
                MessageBox.Show("Сначала выберите вопрос!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Ship());
        }
    }
}
