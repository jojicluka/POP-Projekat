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
    /// Interaction logic for PolaznikPregledTreninga.xaml
    /// </summary>
    public partial class PolaznikPregledTreninga : Window
    {
        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        public PolaznikPregledTreninga()
        {
            InitializeComponent();
            sql.Open();
            SqlCommand userId = new SqlCommand("SELECT userId FROM temp");
            userId.Connection = sql;
            SqlDataReader idReader = userId.ExecuteReader();
            idReader.Read();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT id, datum, vreme, trajanje, status, jmbg_instruktora, jmbg_polaznika FROM treninzi WHERE active = '" + 1 + "' and jmbg_polaznika = '" + idReader.GetValue(0) + "';", sql);
            idReader.Close();
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            treninziTable.ItemsSource = table.DefaultView;
            sql.Close();
        }

        private void closeEvent(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void otkaziEvent(object sender, RoutedEventArgs e)
        {
            sql.Open();
            SqlCommand userId = new SqlCommand("SELECT userId FROM temp");
            userId.Connection = sql;
            SqlDataReader idReader = userId.ExecuteReader();
            idReader.Read();
            SqlCommand update = new SqlCommand("UPDATE treninzi SET status = ' " + nameof(status.SLOBODAN) + "', jmbg_polaznika = 0 WHERE id = '" + idInput.Text + "';");
            idReader.Close();
            update.Connection = sql;
            update.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Uspesno ste otkazali trening!");
            this.Close();
        }
    }
}
