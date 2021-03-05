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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab03_Task01
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create Animation
            DoubleAnimation movingBall = new DoubleAnimation();
            //Animation Configuration
            movingBall.From = 100;
            movingBall.To = 600;
            movingBall.Duration = TimeSpan.FromSeconds(3);
            movingBall.AutoReverse = true;
            movingBall.RepeatBehavior = RepeatBehavior.Forever;
            //Connect Animation With Ball 
            ball.BeginAnimation(LeftProperty, movingBall);

        }
    }
}
