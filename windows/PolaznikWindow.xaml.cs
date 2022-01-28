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
    /// Interaction logic for PolaznikWindow.xaml
    /// </summary>
    public partial class PolaznikWindow : Window
    {
        public PolaznikWindow(string userId)
        {
            InitializeComponent();
        }

        

        private void polaznikInfoEvent(object sender, RoutedEventArgs e)
        {
            PolaznikInfoWindow piw = new PolaznikInfoWindow();
            this.Hide();
            piw.Show();
        }
    }
}
