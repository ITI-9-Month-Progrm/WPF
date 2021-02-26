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

namespace Lab01_Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            if((txt0.Text != "")&&(txt1.Text != "") && (txt2.Text != "") && (txt3.Text != "") && (txt4.Text != "") && (txt5.Text != "") && (txt6.Text != "") && (txt7.Text != "") && (txt8.Text != ""))
            {
                MessageBox.Show("Data Saved Successfull ^^ ","Save_Data");
            }
            else
            {
                MessageBox.Show("Some Data Lose ^^ ", "Error");
            }
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            txt0.Text = " ";
            txt1.Text = " ";
            txt2.Text = " "; 
            txt3.Text = " "; 
            txt4.Text = " "; 
            txt5.Text = " "; 
            txt6.Text = " "; 
            txt7.Text = " ";
            txt8.Text = " ";
        }
    }
}
