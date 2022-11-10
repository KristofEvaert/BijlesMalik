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
        // als je op deze button clickt wil ik dat de inhoud van label1 veranderd in hallo doe dit door gebruik te maken van een methode( zie regel 32)
        private void LaatHalloVerschijnen_Click(object sender, RoutedEventArgs e)
        {
           // Label1.Content =
        }
        // maak een private methode die een string terug geeft ( private want we gaan ze alleen op deze pagina en deze xaml gebruiken)
        //geef de string de waarde "hallo"
       
        // hergebruik hier de methode waar je een string "hallo" aanmaakt om label2 te vullen
        private void TweedeHallo_Click(object sender, RoutedEventArgs e)
        {
            //Label2.Content = 
        }

        // gebruik de methode om beide labels hun tekst te doen veranderen( regel 47)
        private void Verander_Click(object sender, RoutedEventArgs e)
        {
           // de methode die je maakt op regel 49)
        }

        // maak hier een methode die een nieuwe tekst geeft aan beide label(tip deze methode voert iets uit maar hoeft geen waarde terug te geven)
        // voor de tekst waarde aan de labels te geven maak je een methode die deze text geeft( regel 53)
      



        //maak hier een methode die een string terug geeft om te gebruiken in bovenstaande methode( regel 49)


        //gebruik hier een methode die de labels leegmaakt( regel 62)
        private void Verwijder_Click(object sender, RoutedEventArgs e)
        {
           
        }

        // maak een methode deze methode gaat een parameter nemen namelijk een string( tip dit gaat een lege string worden die meegegeven wordt)
       
    }
}
