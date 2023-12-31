﻿using System;
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

namespace Gallery
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numPicture = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            
        }

        private void GoNext(object sender, RoutedEventArgs e)
        {
            numPicture++;

            if (numPicture == 6)
            {
                numPicture = 1;
            }

            imageArea.Source = new BitmapImage(
                new Uri(
                    "Images/" + numPicture + ".jpg", 
                    UriKind.Relative
                )
            );
        }
    }
}
