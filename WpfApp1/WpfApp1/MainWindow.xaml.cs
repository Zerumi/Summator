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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator.Symbols symbol = new Calculator.Symbols();

        public MainWindow()
        {
            InitializeComponent();
        }

        public bool isNextNumStartWrite = false;

        private void BClear_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text = "0";
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            Calculator.DeleteZeroIfExists(this);
            tbOutput.Text += "1";
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            Calculator.DeleteZeroIfExists(this);
            tbOutput.Text += "2";
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            Calculator.DeleteZeroIfExists(this);
            tbOutput.Text += "3";
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            Calculator.DeleteZeroIfExists(this);
            tbOutput.Text += "4";
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            Calculator.DeleteZeroIfExists(this);
            tbOutput.Text += "5";
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            Calculator.DeleteZeroIfExists(this);
            tbOutput.Text += "6";
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            Calculator.DeleteZeroIfExists(this);
            tbOutput.Text += "7";
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            Calculator.DeleteZeroIfExists(this);
            tbOutput.Text += "8";
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            Calculator.DeleteZeroIfExists(this);
            tbOutput.Text += "9";
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            Calculator.DeleteZeroIfExists(this);
            tbOutput.Text += "0";
        }

        private void BDiv_Click(object sender, RoutedEventArgs e)
        {
            Calculator.AddNumber(Convert.ToInt32(tbOutput.Text));
            symbol = Calculator.Symbols.Div;
            isNextNumStartWrite = true;
        }

        private void BMult_Click(object sender, RoutedEventArgs e)
        {
            Calculator.AddNumber(Convert.ToInt32(tbOutput.Text));
            symbol = Calculator.Symbols.Mul;
            isNextNumStartWrite = true;
        }

        private void BDif_Click(object sender, RoutedEventArgs e)
        {
            Calculator.AddNumber(Convert.ToInt32(tbOutput.Text));
            symbol = Calculator.Symbols.Dif;
            isNextNumStartWrite = true;
        }

        private void BSum_Click(object sender, RoutedEventArgs e)
        {
            Calculator.AddNumber(Convert.ToInt32(tbOutput.Text));
            symbol = Calculator.Symbols.Sum;
            isNextNumStartWrite = true;
        }

        private void BCalc_Click(object sender, RoutedEventArgs e)
        {
            Calculator.AddNumber(Convert.ToInt32(tbOutput.Text));
            tbOutput.Text = Calculator.Calculate(symbol);
            isNextNumStartWrite = true;
        }
    }
}
