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
using bench.model;


namespace bench.windows
{
    /// <summary>
    /// Interaction logic for AdminIzmeniPolaznika.xaml
    /// </summary>
    public partial class AdminIzmeniPolaznika : Window
    {

        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        public AdminIzmeniPolaznika(string jmbgPolaznika)
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("SELECT ime, prezime, jmbg, pol, ulica, broj, grad, drzava, mail, password  FROM users WHERE jmbg = '" + jmbgPolaznika + "'");
            cmd.Connection = sql;
            SqlDataReader userInfo = cmd.ExecuteReader();
            InitializeComponent();
            while (userInfo.Read())
            {
                imeTextBox.Text = userInfo.GetValue(0).ToString();
                prezimeTextBox.Text = userInfo.GetValue(1).ToString();
                jmbgTextBox.Text = userInfo.GetValue(2).ToString();
                ulicaTextBox.Text = userInfo.GetValue(4).ToString();
                brojTextBox.Text = userInfo.GetValue(5).ToString();
                gradTextBox.Text = userInfo.GetValue(6).ToString();
                drzavaTextBox.Text = userInfo.GetValue(7).ToString();
                mailTextBox.Text = userInfo.GetValue(8).ToString();
                passwordTextBox.Text = userInfo.GetValue(9).ToString();
            }
            userInfo.Close();
            sql.Close();
        }

        private void closeEvent(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void editEvent(object sender, RoutedEventArgs e)
        {
            sql.Open();
            SqlCommand update = new SqlCommand("UPDATE users SET ime = ' " + imeTextBox.Text + "', prezime = '" + prezimeTextBox.Text + "', jmbg = '" + int.Parse(jmbgTextBox.Text) +
                "', ulica = '" + ulicaTextBox.Text + "', broj = '" + int.Parse(brojTextBox.Text) + "', grad = '" + gradTextBox.Text + "', drzava = '" + drzavaTextBox.Text +
                "', mail = '" + mailTextBox.Text + "', password = '" + passwordTextBox.Text + "' WHERE jmbg = '" + jmbgTextBox.Text + "';");
            update.Connection = sql;
            update.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Uspesno ste izmenili podatke polaznika!");
        }
    }
}
