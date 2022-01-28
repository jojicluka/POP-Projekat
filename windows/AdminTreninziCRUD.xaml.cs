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
    /// Interaction logic for AdminTreninziCRUD.xaml
    /// </summary>
    public partial class AdminTreninziCRUD : Window
    {

        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        public AdminTreninziCRUD()
        {
            InitializeComponent();
            sql.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT id, datum, vreme, trajanje, status, jmbg_instruktora, jmbg_polaznika FROM treninzi WHERE active = '" + 1 + "';", sql);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            treninziTable.ItemsSource = table.DefaultView;
            sql.Close();
        }

        private void createEvent(object sender, RoutedEventArgs e)
        {
            AdminKreirajTrening adminKreirajTrening = new AdminKreirajTrening();
            adminKreirajTrening.Show();
        }

        private void editEvent(object sender, RoutedEventArgs e)
        {
            string idTreninga = idInput.Text;
            AdminIzmeniTrening adminIzmeniTrening = new AdminIzmeniTrening(idTreninga);
            adminIzmeniTrening.Show();
        }

        private void deleteEvent(object sender, RoutedEventArgs e)
        {
            try
            {
                sql.Open();
                SqlCommand delete = new SqlCommand("UPDATE treninzi SET active = '0' WHERE id = '" + int.Parse(idInput.Text) + "';");
                delete.Connection = sql;
                delete.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Uspesno ste obrisali trening!");
            }
            catch (Exception)
            {
                MessageBox.Show("Unesite pravilan ID!");
            }
        }
    }
}
