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
using Guichet_bancaire.views;

namespace Guichet_bancaire
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreationComptePersonne();
            main.Content = new Connection();
        }

        public void CreationComptePersonne()
        {
            classes.Personne personne = new classes.Personne("Einstein","Albert","einstein.albert@gmail.com","Test1");
            CompteCourant ComptePerso = new CompteCourant("BE64 4568 3455 1500", 0, -2000);
            CompteEpargne CompteEpargne = new CompteEpargne("BE64 4568 3455 1501", 0, 2);
        }
    }
}
