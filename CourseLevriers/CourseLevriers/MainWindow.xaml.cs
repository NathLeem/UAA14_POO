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

namespace CourseLevriers
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

        private void btnlancer_Click(object sender, RoutedEventArgs e)
        {
            int[] tabChien = new int[2];
            tabChien[0] = 40;
            tabChien[1] = 20;
            Chien chien1 = new Chien(1, tabChien);
            tabChien[1] = 100;
            Chien chien2 = new Chien(2, tabChien);
            tabChien[1] = 180;
            Chien chien3 = new Chien(3, tabChien);
            tabChien[1] = 260;
            Chien chien4 = new Chien(4, tabChien);
            int[] tabToutChien = new int[1];
            chien1.CourtEnsemble(chien1,chien2,chien3,chien4);
        }
        private void btnPari_Click(object sender, RoutedEventArgs e)
        {
            int valeurPari = 0;
            valeurPari = Int32.Parse(txtNbrEcu.Text);
            Parieur Joe = new Parieur("Joe", 50);
            if ((bool)rdJoe.IsChecked)
            {

            }
            Parieur Bob = new Parieur("Bob", 50);
            Parieur Bill = new Parieur("Bill", 50);
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtJoe.Text = "Joe n'a pas encore parié";
            txtBill.Text = "Bill n'a pas encore parié";
            txtBob.Text = "Bob n'a pas encore parié";
        }
    }
}