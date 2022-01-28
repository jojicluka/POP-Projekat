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
    /// Interaction logic for AdminInstruktoriCRUD.xaml
    /// </summary>
    public partial class AdminInstruktoriCRUD : Window
    {
        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        public AdminInstruktoriCRUD()
        {
            InitializeComponent();
            sql.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ime, prezime, jmbg, pol, ulica, broj, grad, drzava, mail, password FROM users WHERE role = '" + nameof(role.INSTRUKTOR) + "' and active = '" + 1 + "';", sql);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            instruktoriTable.ItemsSource = table.DefaultView;
            sql.Close();
        }

        private void createEvent(object sender, RoutedEventArgs e)
        {
            AdminKreirajInstruktora adminKreirajInstruktora = new AdminKreirajInstruktora();
            adminKreirajInstruktora.Show();
        }

        private void editEvent(object sender, RoutedEventArgs e)
        {
            string jmbgInstruktora = jmbgInput.Text;
            AdminIzmeniInstruktora adminIzmeni = new AdminIzmeniInstruktora(jmbgInstruktora);
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
            MessageBox.Show("Uspesno ste obrisali instruktora!");
            } catch (Exception)
            {
                MessageBox.Show("Unesite pravilan JMBG!");
            }
        }
    }
}
