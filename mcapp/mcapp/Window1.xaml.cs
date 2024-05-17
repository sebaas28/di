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
using System.Windows.Shapes;

namespace mcapp
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Registrar_Click(object sender, RoutedEventArgs e)
        {
            sp_Login.Visibility = Visibility.Collapsed;
            sp_Registro.Visibility = Visibility.Visible;
        }
        private void VolverALogin_Click(object sender, RoutedEventArgs e)
        {
            sp_Registro.Visibility = Visibility.Collapsed;
            sp_Login.Visibility = Visibility.Visible;
        }
        private void ENTRAR_Click(object sender, RoutedEventArgs e)
        {
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
        }
        private void Registrado_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Te has registrado correctamente!");    
        }
        private void Creditos_Click(object sender, RoutedEventArgs e)
        {
            Info i = new Info();
            i.Show();
            this.Close();
        }
    }
}
