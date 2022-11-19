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

namespace MethodesKeyEventsSwitch
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

        private int BerekenKwadraat(string getal)
        {
             int kwadraat = Convert.ToInt32(getal) * Convert.ToInt32(getal);    
            return kwadraat;
        }

        private string NiceNumber(int getal)
        {
            string output = "";
            switch (getal)
            {
                case 16:
                    output = "Dit is een nice number";
                    break;
                case 25:
                    output = "Dit is een super nice number";
                    break;
                default:
                    output = " dit nummer suckt";
                    break;
            }
            return output;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            KwadraatOutput.Text = NiceNumber(BerekenKwadraat(KwadraatInput.Text));
        }
    }
}
