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

namespace mcapp
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
        private void login_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
            this.Close();
        }
        private void dimensiones(object sender, RoutedEventArgs e) {
            Dimensiones dimensiones = new Dimensiones();
            dimensiones.Show();
            this.Close();
        }
    }
}