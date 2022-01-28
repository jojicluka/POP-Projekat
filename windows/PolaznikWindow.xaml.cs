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
            piw.Show();
        }

        private void rezervisiEvent(object sender, RoutedEventArgs e)
        {
            PolaznikIzaberiInstruktora polaznik = new PolaznikIzaberiInstruktora();
            polaznik.Show();
        }

        private void treninziEvent(object sender, RoutedEventArgs e)
        {
            PolaznikPregledTreninga polaznikPregledTreninga = new PolaznikPregledTreninga();
            polaznikPregledTreninga.Show();
        }
    }
}
