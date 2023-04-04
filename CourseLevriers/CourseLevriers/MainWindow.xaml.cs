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
            chien1.Court();
            chien2.Court();
            chien3.Court();
            chien4.Court();
        }
        private void btnPari_Click(object sender, RoutedEventArgs e)
        {
            Parieur Joe = new Parieur("Joe", 50);
            Parieur Bob = new Parieur("Bob", 50);
            Parieur Bill = new Parieur("Bill", 50);
        }
    }
}