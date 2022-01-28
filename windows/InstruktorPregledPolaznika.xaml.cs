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
    /// Interaction logic for InstruktorPregledPolaznika.xaml
    /// </summary>
    public partial class InstruktorPregledPolaznika : Window
    {
        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        public InstruktorPregledPolaznika()
        {
            InitializeComponent();
            sql.Open();
            SqlCommand userId = new SqlCommand("SELECT userId FROM temp");
            userId.Connection = sql;
            SqlDataReader idReader = userId.ExecuteReader();
            idReader.Read();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT jmbg_polaznika FROM treninzi WHERE jmbg_instruktora = '" + idReader.GetValue(0) + "';", sql);
            idReader.Close();
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            polazniciTable.ItemsSource = table.DefaultView;
            sql.Close();
        }

        private void closeEvent(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
