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
        // ter oefening zou ik graag hebben dat je een string aanmaakt die je in beide methodes (key-events) kan gebruiken

        // in de key event ga je zien dat er parameters worden weergegeven Window_KeyDown(object sender, KeyEventArgs e)
        // de KeyEventArgs e is degene die we willen gebruiken deze geeft eigenlijk data door van de xaml naar de bachend
        // dus we willen eigenlijk gaan kijken welke key er ingeduwd word ==> e.Key geeft ons de data weer van welke key er gebruikt word
        // ook hebben we een handige oplijsting van alle keys op het toetsen bord deze kunnen we opvragen met KEY.'keyname'
        // deze e.Key gaan we dan vergelijken met de KEY.'keyname' (TIP als deze e.Key == ...) 


        // voor deze oefening zou ik graag hebben dat je  door 'hallo' te typen gevolgd door de enter toets de text 'hallo' weergeeft in de output box
        // ook als je op de delete toets duwt zou het output veld en de string leeg moeten gemaakt worden 
        // je kan dit ook eerst per letter testen ( tip vul je string en geef ze weer als je op enter duwt)
        // ook telkens als je een toets induwd zou de kleur(background ) van de button op het scherm van kleur moeten veranderen
        // de kleur van de button zou terug normaal moeten worden als je de key los laat



        // maak een key Down event aan (Tip is hetzelfde als een button click maar dan op het window)(TIP bliksem in xaml op de window)







        // maak een key UP event aan (Tip is hetzelfde als een button click maar dan op het window)


    }
}
