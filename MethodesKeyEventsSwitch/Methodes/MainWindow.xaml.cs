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

namespace Methodes
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

        private void LaatHalloVerschijnen_Click(object sender, RoutedEventArgs e)
        {
            Label1.Content = MaakText();
        }
        private string MaakText()
        {
            string text = "Hallo";
            return text;
        }

        private void TweedeHallo_Click(object sender, RoutedEventArgs e)
        {
            Label2.Content = MaakText();
        }

        private void Verander_Click(object sender, RoutedEventArgs e)
        {
            GeefNieuweTekstAanDeLabels();
        }
        private void GeefNieuweTekstAanDeLabels()
        {
            Label1.Content = NieuweTekst();
            Label2.Content = NieuweTekst();
        }

        private string NieuweTekst()
        {
            return "deze tekst is nieuw";
        }

        private void Verwijder_Click(object sender, RoutedEventArgs e)
        {
            VerwijderTextUitLabels("");
        }

        private void VerwijderTextUitLabels(string leeg)
        {
            Label1.Content = leeg;
            Label2.Content = leeg;
        }
    }
}
