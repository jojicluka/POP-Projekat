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

namespace bench.windows
{
    /// <summary>
    /// Interaction logic for FitnessCentarInfo.xaml
    /// </summary>
    public partial class FitnessCentarInfo : Window
    {
        SqlConnection sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=benchdb;Trusted_Connection=True;");
        public FitnessCentarInfo()
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from fitnessCentar");
            cmd.Connection = sql;
            SqlDataReader userInfo = cmd.ExecuteReader();
            InitializeComponent();
            while (userInfo.Read())
            {
                idText.Text = userInfo.GetValue(0).ToString();
                nazivText.Text = userInfo.GetValue(1).ToString();
                ulicaText.Text = userInfo.GetValue(2).ToString();
                brojText.Text = userInfo.GetValue(3).ToString();
                gradText.Text = userInfo.GetValue(4).ToString();
                drzavaText.Text = userInfo.GetValue(5).ToString();
            }
        }

        private void closeEvent(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
