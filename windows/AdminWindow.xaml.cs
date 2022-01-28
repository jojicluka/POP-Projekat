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

namespace bench.windows
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow(string userId)
        {
            InitializeComponent();
        }

        private void infoEvent(object sender, RoutedEventArgs e)
        {
            PolaznikInfoWindow piw = new PolaznikInfoWindow();
            this.Hide();
            piw.Show();
        }

        private void polazniciEvent(object sender, RoutedEventArgs e)
        {
            AdminPolazniciCrud adminPolazniciCrud = new AdminPolazniciCrud();
            adminPolazniciCrud.Show();
        }

        private void instruktoriEvent(object sender, RoutedEventArgs e)
        {
            AdminInstruktoriCRUD adminInstruktoriCRUD = new AdminInstruktoriCRUD();
            adminInstruktoriCRUD.Show();
        }

        private void treninziEvent(object sender, RoutedEventArgs e)
        {

        }
    }
}
