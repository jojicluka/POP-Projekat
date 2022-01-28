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
    /// Interaction logic for AdminKreirajInstruktora.xaml
    /// </summary>
    public partial class AdminKreirajInstruktora : Window
    {

        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        public AdminKreirajInstruktora()
        {
            InitializeComponent();
        }

        private void createEvent(object sender, RoutedEventArgs e)
        {
            sql.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into users values ('" + imeTextBox.Text + "','" + prezimeTextBox.Text + "', '" + int.Parse(jmbgTextBox.Text) + "', '" + polComboBox.Text + "', '" + ulicaTextBox.Text + "', '" + brojTextBox.Text + "', '" + gradTextBox.Text + "', '" + drzavaTextBox.Text + "', '" + emailTextBox.Text + "', '" + passwordTextBox.Text + "', '" + nameof(role.INSTRUKTOR) + "','" + 1 + "')", sql);
            sqlCommand.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Kreiranje instruktora JMBG: " + int.Parse(jmbgTextBox.Text) + " uspesna!");
            this.Close();
        }
    }
}
