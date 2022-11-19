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

namespace KeyEvents
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
        private string text = "";
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.H)
            {
                text += "h";
                H.Background = Brushes.Aqua;
            }
            if (e.Key == Key.A)
            {
                text += "a";
                A.Background = Brushes.Aqua;
            }
            if (e.Key == Key.L)
            {
                text += "l";
                L.Background = Brushes.Aqua;
            }
            if (e.Key == Key.O)
            {
                text += "o";
                O.Background = Brushes.Aqua;
            }
            if (e.Key == Key.Enter)
            {
                Output.Text = text;
                text = "";
            }

            /*

            switch (e.Key)
            {
               case Key.H:
                    text += "h";
                    H.Background = Brushes.Aqua;
                    break;
                case Key.A:
                    text += "a";
                    A.Background = Brushes.Aqua;
                    break;
                case Key.L:
                    text += "l";
                    L.Background = Brushes.Aqua;
                    break;
                case Key.O:
                    text += "o";
                    O.Background = Brushes.Aqua;
                    break;
                case Key.Enter:
                    Output.Text = text;
                    text = "";
                    break;
                default:
                    break;
            }
            */
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.H)
            {

                H.Background = Brushes.Gray;
            }
            if (e.Key == Key.A)
            {

                A.Background = Brushes.Gray;
            }
            if (e.Key == Key.L)
            {

                L.Background = Brushes.Gray;
            }
            if (e.Key == Key.O)
            {

                O.Background = Brushes.Gray;
            }
            if (e.Key == Key.Delete)
            {
                Output.Text = "";
                text = "";
            }
            
            /*
            switch (e.Key)
            {
                case Key.H:
                    H.Background = Brushes.Gray;
                    break;
                case Key.A:
                    A.Background = Brushes.Gray;
                    break;
                case Key.L:
                    L.Background = Brushes.Gray;
                    break;
                case Key.O:
                    O.Background = Brushes.Gray;
                    break;
                case Key.Enter:
                    Output.Text = text;
                    text = "";
                    break;
                default:
                    break;
            }
            */
        }
    }
}
