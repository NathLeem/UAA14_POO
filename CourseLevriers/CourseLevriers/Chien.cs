using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CourseLevriers
{
    class Chien
    {
        int _longueurPiste = 100;
        int _numChien = 1;
        BitmapImage imageChien = new BitmapImage();
        int[] _positionCourante;
        bool _gagne;

        public Chien(int numChien, int[] positionCourante)
        {
            _numChien = numChien;
            _positionCourante = positionCourante;


            imageChien.BeginInit();
            imageChien.UriSource = new Uri("image/dog.png", UriKind.Relative);
            imageChien.EndInit();

            MainWindow plateau = (CourseLevriers.MainWindow)App.Current.MainWindow;

            Image monImage = new Image();
            monImage.Source = imageChien;
            monImage.Stretch = System.Windows.Media.Stretch.None;
            
            Canvas.SetLeft(monImage, positionCourante[0]);
            Canvas.SetTop(monImage, positionCourante[1]);
            plateau.piste.Children.Add(monImage);
        }
        public void Court()
        {
            Random rnd = new Random();
            Image monImage = new Image();
            monImage.Source = imageChien;
            
            
            while (_longueurPiste >= _positionCourante[0])
            {
                _positionCourante[0] = _positionCourante[0] + rnd.Next(1,10);

                Canvas.SetLeft(monImage, _positionCourante[0]);
            }
            _gagne = true;
            
            string chienGagne = "Le chien n°" + _numChien +" à gagner la course";
        }
    }
}