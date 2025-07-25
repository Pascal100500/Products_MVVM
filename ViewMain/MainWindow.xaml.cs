﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ViewMain
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

        private void OpenElectronicsWindow(object sender, RoutedEventArgs e)
        {
            var electronicsWindow = new View.ElectronicsWindow();
            electronicsWindow.ShowDialog(); // Чтобы главное окно было неактивным, когда открыто окно с электроникой
        }

        private void OpenVegetableWindow(object sender, RoutedEventArgs e)
        {
            var vegetableWindow = new View.VegetableWindow();
            vegetableWindow.ShowDialog(); // Чтобы главное окно было неактивным, когда открыто окно с овощами
        }
    }
}