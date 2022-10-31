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
            mathValue = new string[] { "Up Class", "5 Foot", "10 Foot", "15 Foot" };
            DataContext = this;
        }

        private void mathClick(object sender, RoutedEventArgs e)
        {
            outputBox.Text = string.Empty;
            double embedDouble = Convert.ToDouble(embedBox.Text);
            double poleHeightDouble = Convert.ToDouble(poleHeightBox.Text);
            string[] stringNum = inputBox.Text.Split("\n");
            string comboMath = mathSetting.Text;
            switch (comboMath)
            {
                case "5 Foot":
                    for (int i = 0; i < stringNum.Length; i++)
                    {
                        double num = Double.TryParse(stringNum[i], out double value) ? value : 0;
                        double increase5 = (embedDouble - ((poleHeightDouble + 5) * 0.1 + 2)) + 5;
                        outputBox.Text += Convert.ToString($"{num + increase5}\n");
                    }
                    break;
                case "10 Foot":
                    for (int i = 0; i < stringNum.Length; i++)
                    {
                        double num = Double.TryParse(stringNum[i], out double value) ? value: 0;
                        double increase10 = (embedDouble - ((poleHeightDouble + 10) * 0.1 + 2)) + 10;
                        outputBox.Text += Convert.ToString($"{num + increase10}\n");
                    }
                    break;
                case "15 Foot":
                    for (int i = 0; i < stringNum.Length; i++)
                    {
                        double num = Double.TryParse(stringNum[i], out double value) ? value : 0;
                        double increase15 = (embedDouble - ((poleHeightDouble + 15) * 0.1 + 2)) + 15;
                        outputBox.Text += Convert.ToString($"{num + increase15}\n");
                    }
                    break;
                case "Up Class":
                    for (int i = 0; i < stringNum.Length; i++)
                    {
                        double num = Double.TryParse(stringNum[i], out double value) ? value : 0;
                        double upClass = (embedDouble - ((poleHeightDouble) * 0.1 + 2));
                        outputBox.Text += Convert.ToString($"{num + upClass}\n");
                    }
                    break;
            }
            
        }
    }
}
