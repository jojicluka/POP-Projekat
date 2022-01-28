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
using System.Windows.Navigation;
using System.Windows.Shapes;
using bench.windows;
using System.Data.SqlClient;

namespace bench
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void registracijaBtnEvent(object sender, RoutedEventArgs e)
        {
            RegistracijaWindow registracija = new RegistracijaWindow();
            this.Hide();
            registracija.Show();
        }

        private void loginBtnEvent(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            this.Hide();
            loginWindow.Show();
        }

        private void fcEvent(object sender, RoutedEventArgs e)
        {
            FitnessCentarInfo fci = new FitnessCentarInfo();
            fci.Show();
        }

        private void instruktoriEvent(object sender, RoutedEventArgs e)
        {
            PrikaziInstruktore pi = new PrikaziInstruktore();
            pi.Show();
        }
    }
}
