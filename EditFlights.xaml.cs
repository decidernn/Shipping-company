using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
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
    /// Логика взаимодействия для EditFlights.xaml
    /// </summary>
    public partial class EditFlights : Page
    {
        string query;
        СудоходнаяКомпанияEntities db = new СудоходнаяКомпанияEntities();
        function fn = new function();
        public List<Судно> Судноs { get; set; }
        public List<Администратор> Администраторs { get; set; }
        public List<Клиент> Клиентs { get; set; }
        public List<Статус> Статусs { get; set; }

        int idship;
        int idadmin;
        int idclient;
        int idstatus;
        public EditFlights()
        {
            InitializeComponent();

            query = "SELECT distinct Код FROM Рейс";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            bindcombo1();
            bindcombo2();
            bindcombo3();
            bindcombo4();
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

        private void comboStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = comboStatus.SelectedItem as Статус;
            idstatus = item.Код;
        }

        private void btnAddFlight_Click(object sender, RoutedEventArgs e)
        {
            if (comboSet.SelectedIndex != -1)
            {
                query = "UPDATE Рейс SET КодСудна = '" + comboShip.SelectedIndex + 1 + "', КодАдминистратора = '" + comboAdmin.SelectedIndex + 1 + "',  КодКлиента = '" + comboClient.SelectedIndex + 1 + "',  КодСтатуса = '" + comboStatus.SelectedIndex + "',  " +
                    //"ДатаОтправления = '" + DatePickerOut.SelectedDate.Value + "', " +
                    //"ДатаПрибытия = '" + DatePickerIn.SelectedDate.Value + "', " +
                    "ГородОтправления = '" + txtCityOut.Text + "', ГородПрибытия = '" + txtCityIn.Text + "', Груз = '" + txtCargo.Text + "', КапитанСудна = '" + txtCapitaneOfShip.Text + "' WHERE Код = '" + comboSet.SelectedIndex + 1  + "'";
                fn.setData(query, "Информация обновлена!");

            }
            else
            {
                MessageBox.Show("Сначала выберите вопрос!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void comboSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            query = "select * FROM Рейс WHERE Код = '" + comboSet.SelectedValue + "'";

            DataSet ds = fn.getData(query);

            DatePickerOut.SelectedDateFormat = DatePickerFormat.Short;
            DatePickerIn.SelectedDateFormat = DatePickerFormat.Short;

            comboShip.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString()) - 1;
            comboAdmin.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString()) - 1;
            comboClient.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0][3].ToString()) - 1;
            comboStatus.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString()) - 1;
            //DatePickerOut.SelectedDate = Convert.ToDateTime(ds.Tables[0].Rows[0][5].ToString());
            //DatePickerIn.SelectedDate = Convert.ToDateTime(ds.Tables[0].Rows[0][6].ToString());
            txtCityOut.Text = ds.Tables[0].Rows[0][7].ToString();
            txtCityIn.Text = ds.Tables[0].Rows[0][8].ToString();
            txtCargo.Text = ds.Tables[0].Rows[0][9].ToString();
            txtCapitaneOfShip.Text = ds.Tables[0].Rows[0][10].ToString();

            DatePickerOut.SelectedDateFormat = DatePickerFormat.Short;
            DatePickerIn.SelectedDateFormat = DatePickerFormat.Short;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Flight());
        }
    }
}
