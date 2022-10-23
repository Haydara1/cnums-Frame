using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace cnums_Frame.Pop_ups
{
    /// <summary>
    /// Interaction logic for References.xaml
    /// </summary>
    public partial class References : Window
    {
        public References()
        {
            InitializeComponent();
        }

        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);
            Close();
        }

        private void cnumsClick(object sender, RoutedEventArgs e)
        {
            string url = "https://www.github.com/Haydara1/cnums";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
        }

        private void OxyplotClick(object sender, RoutedEventArgs e)
        {
            string url = "https://github.com/oxyplot/oxyplot";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
        }

        private void WPFMathClick(object sender, RoutedEventArgs e)
        {
            string url = "https://github.com/ForNeVeR/wpf-math";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
        }
    }
}
