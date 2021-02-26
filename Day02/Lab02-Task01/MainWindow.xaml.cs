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
using static Lab02_Task01.Calculation;
namespace Lab02_Task01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string equation = "";
        public string result = "result";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void num_0_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "0";
           
        }
        private void num_1_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "1";
        }
        private void num_2_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "2";
        }
        private void num_3_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "3";
        }
        private void num_4_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "4";
        }
        private void num_5_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "5";
        }
        private void num_6_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "6";
        }
        private void num_7_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "7";
        }
        
        private void num_8_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "8";
        }
        private void num_9_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "9";
        }
        private void num_dot_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + ".";
        }
        private void num_divided_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "/";
        }
        private void num_multiple_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "*";
        }
        private void num_sum_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "+";
        }
        private void num_sub_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            txt_eq.Text = equation + "-";
        }

        private void Cancle_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            int len = equation.Length;
            string newEq = equation.Substring(0, len - 1);
            txt_eq.Text = newEq;
        }

        private void cleare_Click(object sender, RoutedEventArgs e)
        {
            txt_eq.Text = string.Empty;

        }
        private void num_equal_Click(object sender, RoutedEventArgs e)
        {
            equation = txt_eq.Text;
            result = calcResult(equation);
            txt_eq.TextAlignment = TextAlignment.Right;
            txt_eq.Text = result;
        }

        
    }
}
