using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBrushesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //brdSolid.Background = new SolidColorBrush(Color.FromArgb(10, 0, 255, 255));

            //var brush = new LinearGradientBrush();
            //brush.StartPoint = new Point(0, 0);
            //brush.EndPoint = new Point(1, 0);
            //brush.GradientStops.Add(new(Colors.Magenta, 0));
            //brush.GradientStops.Add(new(Colors.Yellow, 1));
            //brdLinear.Background = brush;
        }
    }
}