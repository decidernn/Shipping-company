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
    /// Логика взаимодействия для EditClient.xaml
    /// </summary>
    public partial class EditClient : Page
    {
        public List<Клиент> Клиентs { get; set; }
        string query;
        function fn = new function();
        public EditClient()
        {
            InitializeComponent();

            query = "SELECT distinct Код FROM Клиент";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnAddFlight_Click(object sender, RoutedEventArgs e)
        {
            if (comboSet.SelectedIndex != -1)
            {
                query = "UPDATE Клиент SET ФамилияКлиента = '" + txtSurname.Text + "', ИмяКлиента = '" + txtName.Text + "',  ОтчествоКлиента = '" + txtPath.Text + "',  Паспорт = '" + txtPassport.Text + "',  " +
                    "НомерТелефона = '" + txtPhone.Text + "' WHERE Код = '" + comboSet.SelectedIndex + 1 + "'";
                fn.setData(query, "Информация обновлена!");

            }
            else
            {
                MessageBox.Show("Сначала выберите вопрос!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void comboSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            query = "select * FROM Клиент WHERE Код = '" + comboSet.SelectedValue + "'";

            DataSet ds = fn.getData(query);

            txtSurname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPath.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPassport.Text = ds.Tables[0].Rows[0][4].ToString();
            txtPhone.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Clients());
        }
    }
}
