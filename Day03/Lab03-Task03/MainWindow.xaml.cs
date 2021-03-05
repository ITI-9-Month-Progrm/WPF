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

namespace Lab03_Task03
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

        private void btnReadOnly_Checked(object sender, RoutedEventArgs e)
        {
            borderTxt.BorderBrush = System.Windows.Media.Brushes.Blue;
            txt1.IsReadOnly = false;
        }

        private void btnReadOnly_Unchecked(object sender, RoutedEventArgs e)
        {
            borderTxt.BorderBrush = System.Windows.Media.Brushes.SkyBlue;
            txt1.IsReadOnly = true;
        }
    }
}
