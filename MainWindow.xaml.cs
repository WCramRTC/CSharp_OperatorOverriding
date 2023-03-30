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

namespace CSharp_OperatorOverriding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Point p1;
        Point p2;

        public MainWindow()
        {
            InitializeComponent();
            CreatePoints();

            runPointDisplay.Text = $"Point 1: {p1}\n";
            runPointDisplay.Text += $"Point 2: {p2}\n\n";

            Point pAdd = p1 + p2;
            Point pSubtract = p1 - p2;
            Point pMultiply = p1 * p2;
            bool pGreaterThan = p1 > p2;
            bool pLessThan = p1 < p2;

            runPointDisplay.Text += $"Add Points - {pAdd} \n" +
                $"Subtract Points - {pSubtract}\n" +
                $"Multiple Points - {pMultiply}\n\n" +
                $"Point 1: {p1} - Point 2: {p2}\n" +
                $"Point 1 > Point 2 : {pGreaterThan}\n" +
                $"Point 1 < Point 2 : {pLessThan}";
        }

        public void CreatePoints()
        {
            p1 = new Point(10, 20);
            p2 = new Point(5, 15);
        }
    }
}
