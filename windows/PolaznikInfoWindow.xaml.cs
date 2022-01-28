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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace bench.windows
{
    /// <summary>
    /// Interaction logic for PolaznikInfoWindow.xaml
    /// </summary>
    public partial class PolaznikInfoWindow : Window
    {

        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        public PolaznikInfoWindow()
        {
            sql.Open();
            SqlCommand userId = new SqlCommand("SELECT userId FROM temp");
            userId.Connection = sql;
            SqlDataReader idReader = userId.ExecuteReader();
            idReader.Read();
            SqlCommand cmd = new SqlCommand("SELECT ime, prezime, jmbg, pol, ulica, broj, grad, drzava, mail, password  FROM users WHERE jmbg = '200312'");
            cmd.Connection = sql;
            idReader.Close();
            SqlDataReader userInfo = cmd.ExecuteReader();
            InitializeComponent();
            while (userInfo.Read())
            {
                imeTextBox.Text = userInfo.GetValue(0).ToString();
                prezimeTextBox.Text = userInfo.GetValue(1).ToString();
                jmbgTextBox.Text = userInfo.GetValue(2).ToString();
                polTextBox.Text = userInfo.GetValue(3).ToString();
                ulicaTextBox.Text = userInfo.GetValue(4).ToString();
                brojTextBox.Text = userInfo.GetValue(5).ToString();
                gradTextBox.Text = userInfo.GetValue(6).ToString();
                drzavaTextBox.Text = userInfo.GetValue(7).ToString();
                mailTextBox.Text = userInfo.GetValue(8).ToString();
                passwordTextBox.Text = userInfo.GetValue(9).ToString();

            }
            sql.Close();
        }

        private void closeEvent(object sender, RoutedEventArgs e )
        {

        }

        private void editEvent(object sender, RoutedEventArgs e)
        {

        }

    }
}
