using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bench.model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace bench.windows
{
    /// <summary>
    /// Interaction logic for RegistracijaWindow.xaml
    /// </summary>
    public partial class RegistracijaWindow : Window
    {
        public RegistracijaWindow()
        {
            InitializeComponent();
        }

        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        private void registerVerify(object sender, RoutedEventArgs e )
        {
            sql.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into users values ('" + imeTextBox.Text + "','" + prezimeTextBox.Text + "', '" + int.Parse(jmbgTextBox.Text) + "', '" + polComboBox.Text + "', '" + ulicaTextBox.Text + "', '" + brojTextBox.Text + "', '" + gradTextBox.Text + "', '" + drzavaTextBox.Text + "', '" + emailTextBox.Text + "', '" + passwordTextBox.Text + "', '" + nameof(role.POLAZNIK) + "','" + 1 + "')", sql) ;
            sqlCommand.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Registracija korisnika JMBG: " + int.Parse(jmbgTextBox.Text) + " uspesna!");
            this.Close();
        }
    }
}
