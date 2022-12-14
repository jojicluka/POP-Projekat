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
    /// Interaction logic for InstruktorWindow.xaml
    /// </summary>
    public partial class InstruktorWindow : Window
    {
        public InstruktorWindow(string userId)
        {
            InitializeComponent();
        }

        private void infoEvent(object sender, RoutedEventArgs e)
        {
            PolaznikInfoWindow piw = new PolaznikInfoWindow();
            piw.Show();
        }

        private void treninziEvent(object sender, RoutedEventArgs e)
        {
            InstruktorPregledTreninga instruktorPregledTreninga = new InstruktorPregledTreninga();
            instruktorPregledTreninga.Show();
        }

        private void polazniciEvent(object sender, RoutedEventArgs e)
        {
            InstruktorPregledPolaznika ipp = new InstruktorPregledPolaznika();
            ipp.Show();
        }
    }
}
