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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        private void loginVerify(object sender, RoutedEventArgs e)
        {
            sql.Open();
            SqlCommand sqlCommandDelete = new SqlCommand("DELETE FROM temp");
            sqlCommandDelete.Connection = sql;
            sqlCommandDelete.ExecuteNonQuery();
            if (roleComboBox.Text == "Polaznik")
            {
                string verification = "SELECT * FROM users WHERE jmbg = '" + int.Parse(jmbgTextBox.Text.Trim()) + "' and password = '" + passwordTextBox.Text.Trim() + "' and role = '" + nameof(role.POLAZNIK) + "' and active = '" + 1 + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(verification, sql);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if(dataTable.Rows.Count == 1)
                {
                    string userId = jmbgTextBox.Text.Trim();
                    MessageBox.Show("Uspesan login za JMBG: " + userId);
                    SqlCommand sqlCommand = new SqlCommand("insert into temp values ('" + userId + "')", sql);
                    sqlCommand.ExecuteNonQuery();
                    sql.Close();
                    PolaznikWindow polaznikWindow = new PolaznikWindow(userId);
                    this.Close();
                    polaznikWindow.Show();
                }
                else
                {
                    MessageBox.Show("Neuspesan login");
                }
            }
            if(roleComboBox.Text == "Instruktor")
            {
                string verification = "SELECT * FROM users WHERE jmbg = '" + int.Parse(jmbgTextBox.Text.Trim()) + "' and password = '" + passwordTextBox.Text.Trim() + "' and role = '" + nameof(role.INSTRUKTOR) + "' and active = '" + 1 + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(verification, sql);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    string userId = jmbgTextBox.Text.Trim();
                    MessageBox.Show("Uspesan login za JMBG: " + userId);
                    SqlCommand sqlCommand = new SqlCommand("insert into temp values ('" + userId + "')", sql);
                    sqlCommand.ExecuteNonQuery();
                    sql.Close();
                    InstruktorWindow instruktorWindow = new InstruktorWindow(userId);
                    this.Close();
                    instruktorWindow.Show();
                }
                else
                {
                    MessageBox.Show("Neuspesan login");
                }
            }
            if(roleComboBox.Text == "Admin")
            {
                string verification = "SELECT * FROM users WHERE jmbg = '" + int.Parse(jmbgTextBox.Text.Trim()) + "' and password = '" + passwordTextBox.Text.Trim() + "' and role = '" + nameof(role.ADMINISTRATOR) + "' and active = '" + 1 + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(verification, sql);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    string userId = jmbgTextBox.Text.Trim();
                    MessageBox.Show("Uspesan login za JMBG: " + userId);
                    SqlCommand sqlCommand = new SqlCommand("insert into temp values ('" + userId + "')", sql);
                    sqlCommand.ExecuteNonQuery();
                    sql.Close();
                    AdminWindow adminWindow = new AdminWindow(userId);
                    this.Close();
                    adminWindow.Show();
                }
                else
                {
                    MessageBox.Show("Neuspesan login");
                }
            }
            sql.Close();
        }
    }
}
