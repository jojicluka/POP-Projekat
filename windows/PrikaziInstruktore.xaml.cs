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
    /// Interaction logic for PrikaziInstruktore.xaml
    /// </summary>
    public partial class PrikaziInstruktore : Window
    {

        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        public PrikaziInstruktore()
        {
            InitializeComponent();
            sql.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ime, prezime, jmbg, pol, ulica, broj, grad, drzava, mail, password FROM users WHERE role = '" + nameof(role.INSTRUKTOR) + "';", sql);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            instruktoriTable.ItemsSource = table.DefaultView;
            sql.Close();
        }

        private void closeEvent(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
