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
using System.Data;

namespace bench.windows
{
    /// <summary>
    /// Interaction logic for AdminPolazniciCrud.xaml
    /// </summary>
    public partial class AdminPolazniciCrud : Window
    {
        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        public AdminPolazniciCrud()
        {
            InitializeComponent();
            sql.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ime, prezime, jmbg, pol, ulica, broj, grad, drzava, mail, password FROM users WHERE role = '" + nameof(role.POLAZNIK) + "' and active = '" + 1 + "';", sql);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            polazniciTable.ItemsSource = table.DefaultView;
            sql.Close();
        }

        private void createEvent(object sender, RoutedEventArgs e)
        {
            AdminKreirajPolaznika adminKreirajPolaznika = new AdminKreirajPolaznika();
            adminKreirajPolaznika.Show();
        }

        private void editEvent(object sender, RoutedEventArgs e)
        {
            string jmbgPolaznika = jmbgInput.Text;
            AdminIzmeniPolaznika adminIzmeniPolaznika = new AdminIzmeniPolaznika(jmbgPolaznika);
            adminIzmeniPolaznika.Show();
        }

        private void deleteEvent(object sender, RoutedEventArgs e)
        {
            try
            {
                sql.Open();
                SqlCommand delete = new SqlCommand("UPDATE users SET active = '0' WHERE jmbg = '" + int.Parse(jmbgInput.Text) + "';");
                delete.Connection = sql;
                delete.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Uspesno ste obrisali polaznika!");
            }
            catch (Exception)
            {
                MessageBox.Show("Unesite pravilan JMBG!");
            }
        }
    }
}
