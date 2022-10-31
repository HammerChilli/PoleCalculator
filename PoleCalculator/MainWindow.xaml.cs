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

namespace PoleCalculator
{
    public partial class MainWindow : Window
    {
        public string[] mathValue { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            mathValue = new string[] { "1.5", "5", "10", "15" };
            DataContext = this;
        }

        private void mathClick(object sender, RoutedEventArgs e)
        {
            foreach (var num in inputBox.Text.Split("\n"))
            {
                if (double.TryParse(num, out double value))
                {
                    outputBox.Text = Convert.ToString(value * 2);
                }
            }
        }
    }
}
