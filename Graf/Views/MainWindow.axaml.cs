using Avalonia.Controls;
using ScottPlot.Avalonia;
 
namespace Graf.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            double[] data = ScottPlot.Generate.Sin();
            
            var plt = MyPlot.Plot;

            plt.Add.Signal(data);
            MyPlot.Refresh();
        }
    }
}