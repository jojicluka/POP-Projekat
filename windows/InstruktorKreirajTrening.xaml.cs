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
    /// Interaction logic for InstruktorKreirajTrening.xaml
    /// </summary>
    public partial class InstruktorKreirajTrening : Window
    {

        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        public InstruktorKreirajTrening()
        {
            InitializeComponent();
        }

        private void createEvent(object sender, RoutedEventArgs e)
        {
            sql.Open();
            SqlCommand userId = new SqlCommand("SELECT userId FROM temp");
            userId.Connection = sql;
            SqlDataReader idReader = userId.ExecuteReader();
            idReader.Read();
            SqlCommand cmd = new SqlCommand("insert into treninzi values('" + idTextBox.Text + "','" + DateTime.Parse(datum.Text) + "','" + vremeTextBox.Text + "','" + trajanjeTextBox.Text + "','" + nameof(status.SLOBODAN) + "','" + idReader.GetValue(0) + "',' 0 ','1');");
            idReader.Close();
            cmd.Connection = sql;
            cmd.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Uspesno ste kreirali trening!");
            this.Close();
        }
    }
}
