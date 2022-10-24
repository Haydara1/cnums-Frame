using System.Diagnostics;
using System;
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
using System.Windows.Controls.Primitives;


namespace cnums_Frame.Pop_ups
{
    /// <summary>
    /// Interaction logic for References.xaml
    /// </summary>
    public class References : PopupWindow
    {
        public References()
        {
            InitializeComponent();
            AddButtons();
        }

        private void AddButtons()
        {
            Style? style = this.FindResource("PopupButton") as Style;

            Button cnums = new()
            { 
                Content = "cnums",
                Style = style,
                ToolTip = "",
            };

            Button OxyPlot = new()
            { 
                Content = "Oxyplot",
                Style = style 
            };

            Button WPFMath = new()
            {
                Content = "WPFMath",
                Style = style
            };

            container.Children.Add(cnums);
            container.Children.Add(OxyPlot);
            container.Children.Add(WPFMath);

            cnums.Click += cnumsClick;
            OxyPlot.Click += OxyplotClick;
            WPFMath.Click += WPFMathClick;

            SetHeight();
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
