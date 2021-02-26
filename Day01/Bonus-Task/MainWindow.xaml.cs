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

namespace Bonus_Task
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

        //Buttons Clicked Function
       
        private void setText(object sender, RoutedEventArgs e)
        {
            
            txt1.Text = "Hello Every One from Set";
            


        }
        
        private void selectAll(object sender, RoutedEventArgs e)
        {
            if (!txt1.IsFocused)
                txt1.Focus();
            
            txt1.SelectAll();
        }
        private void clearText(object sender, RoutedEventArgs e)
        {
          
            txt1.Clear();
        }
        private void prependText(object sender, RoutedEventArgs e)
        {
            string prependValue = "***Prepend***";
            string newText;
            //txt1.PrependText("gg");
            newText = prependValue + txt1.Text;
            txt1.Text = newText;
        }
        private void insetText(object sender, RoutedEventArgs e)
        {
            string oldValue = txt1.Text;
            txt1.Text  =oldValue +  " Hello Every One from insert";
        }
        private void appendText(object sender, RoutedEventArgs e)
        {
           
            txt1.AppendText("***append***");
        }
        private void cutText(object sender, RoutedEventArgs e)
        {
            
            if (txt1.SelectedText != "")
                txt1.Cut();
        }
        private void pastText(object sender, RoutedEventArgs e)
        {
            txt1.Paste();
            
        }
        private void undoText(object sender, RoutedEventArgs e)
        {
            txt1.Undo();
           
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rBtn1= (RadioButton)sender;
            string contentValue = rBtn1.Content.ToString();
            switch (contentValue)
            {
                case "Editable":
                    txt1.IsReadOnly = false;
                    break;
                case "Read Only":
                    txt1.IsReadOnly = true;
                    
                    break;
            }
        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            RadioButton rBtn1 = (RadioButton)sender;
            string contentValue = rBtn1.Content.ToString();
            switch (contentValue)
            {
                case "Left":
                    txt1.TextAlignment = TextAlignment.Left;
                    break;
                case "Center":
                    txt1.TextAlignment = TextAlignment.Center;
                    break;
                case "Right":
                    txt1.TextAlignment = TextAlignment.Right;
                    break;
            }
        }
    }
}
