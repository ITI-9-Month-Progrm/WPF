using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab1_Task2
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
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Red":
                    ink.DefaultDrawingAttributes.Color = Colors.Red;
                    break;
                case "Green":
                    ink.DefaultDrawingAttributes.Color = Colors.Green;
                    break;
                case "Blue":
                    ink.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Ink":
                    ink.EditingMode = InkCanvasEditingMode.Ink;
                    break;
                case "Select":
                    ink.EditingMode = InkCanvasEditingMode.Select;

                    break;
                case "Erase":
                    ink.EditingMode = InkCanvasEditingMode.EraseByPoint;

                    break;
            }

        }
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Elipse":
                 ink.DefaultDrawingAttributes.StylusTip = StylusTip.Ellipse;
                    break;
                case "Rect":
                    ink.DefaultDrawingAttributes.StylusTip = StylusTip.Rectangle;

                    break;
            }

        }
        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "small":
                    ink.DefaultDrawingAttributes.Height = 10;
                    ink.DefaultDrawingAttributes.Width = 10;
                    break;
                case "normal":
                    
                    ink.DefaultDrawingAttributes.Height = 30;
                    ink.DefaultDrawingAttributes.Width =30;

                    break;
                case "large":
                    ink.DefaultDrawingAttributes.Height = 50;
                    ink.DefaultDrawingAttributes.Width = 40;
                    break;
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ink.Strokes.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ink.CopySelection();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ink.CutSelection();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ink.Paste();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FileStream f = new FileStream("D:/WPF/Day01/Lab1-Task2/canvas.ink", FileMode.Create, FileAccess.Write);
            ink.Strokes.Save(f);
            f.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            FileStream r = new FileStream("D:/WPF/Day01/Lab1-Task2/canvas.ink", FileMode.Open, FileAccess.Read);
            StrokeCollection strokes = new StrokeCollection(r);
            ink.Strokes = strokes;
            r.Close();
        }
    }
}
