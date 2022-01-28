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
    /// Interaction logic for AdminIzmeniTrening.xaml
    /// </summary>
    public partial class AdminIzmeniTrening : Window
    {

        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        public AdminIzmeniTrening(string idTreninga)
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("SELECT id, datum, vreme, trajanje, status, jmbg_instruktora, jmbg_polaznika  FROM treninzi WHERE id = '" + idTreninga + "'");
            cmd.Connection = sql;
            SqlDataReader trInfo = cmd.ExecuteReader();
            InitializeComponent();
            while (trInfo.Read())
            {
                idTextBox.Text = trInfo.GetValue(0).ToString();
                datum.Text = trInfo.GetValue(1).ToString();
                vremeTextBox.Text = trInfo.GetValue(2).ToString();
                trajanjeTextBox.Text = trInfo.GetValue(3).ToString();
                jmbgInstruktoraTextBox.Text = trInfo.GetValue(5).ToString();
            }
            trInfo.Close();
            sql.Close();
        }

        private void closeEvent(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void editEvent(object sender, RoutedEventArgs e)
        {
            sql.Open();
            SqlCommand update = new SqlCommand("UPDATE treninzi SET datum = ' " + DateTime.Parse(datum.Text) + "', vreme = '" + vremeTextBox.Text + "', trajanje = '" + trajanjeTextBox.Text +
                "', jmbg_instruktora = '" + jmbgInstruktoraTextBox.Text +"' WHERE id = '" + idTextBox.Text + "';");
            update.Connection = sql;
            update.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Uspesno ste izmenili podatke treninga!");
        }
    }
}
