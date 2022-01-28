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
using System.Data;
using System.Data.SqlClient;
using bench.model;

namespace bench.windows
{
    /// <summary>
    /// Interaction logic for InstruktorPregledTreninga.xaml
    /// </summary>
    public partial class InstruktorPregledTreninga : Window
    {

        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        public InstruktorPregledTreninga()
        {
            InitializeComponent();
            sql.Open();
            SqlCommand userId = new SqlCommand("SELECT userId FROM temp");
            userId.Connection = sql;
            SqlDataReader idReader = userId.ExecuteReader();
            idReader.Read();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT id, datum, vreme, trajanje, status, jmbg_instruktora, jmbg_polaznika FROM treninzi WHERE active = '" + 1 + "' and jmbg_instruktora = '" + idReader.GetValue(0) + "'; ", sql);
            idReader.Close();
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            treninziTable.ItemsSource = table.DefaultView;
            sql.Close();
        }

        public void deleteEvent(object sender, RoutedEventArgs e)
        {
            sql.Open();
            SqlCommand userId = new SqlCommand("SELECT userId FROM temp");
            userId.Connection = sql;
            SqlDataReader idReader = userId.ExecuteReader();
            idReader.Read();
            SqlCommand delete = new SqlCommand("UPDATE treninzi SET active = '0' WHERE jmbg_instruktora = '" + idReader.GetValue(0) + "' and id = '" + int.Parse(idInput.Text) + "' and status = 'SLOBODAN';");
            delete.Connection = sql;
            idReader.Close();
            delete.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Uspesno ste obrisali trening!");
        }

        public void createEvent(object sender, RoutedEventArgs e)
        {
            InstruktorKreirajTrening instruktor = new InstruktorKreirajTrening();
            this.Hide();
            instruktor.Show();
        }
    }
}
