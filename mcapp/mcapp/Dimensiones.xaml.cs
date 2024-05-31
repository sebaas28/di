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
    /// Lógica de interacción para Dimensiones.xaml
    /// </summary>
    public partial class Dimensiones : Window
    {
        public Dimensiones()
        {
            InitializeComponent();

        }
        public void Menu_Man(object sender, RoutedEventArgs e)
        {
            DescriptionTextBlock.Text = "¿A qué esperas para disfrutar del menú favorito de Manuel Turizo?: La icónica BigMac con sus dos jugosas carnes 100% vacuno, Coca-Cola zero, 4 sabrosas alitas de pollo, patatas deluxe y de postre, ¡apple pie! ¿Algo mejor? Disfrútalo por tiempo limitado por sólo 10,90€.";
            DescriptionImage.Source = new BitmapImage(new Uri("img/menu_man.png", UriKind.RelativeOrAbsolute));
        }
        public void Menu_Sai(object sender, RoutedEventArgs e)
        {
            DescriptionTextBlock.Text = "No te pierdas el menú favorito de Saiko, Cuarto de Libra con carne 100% vacuno, 4 McNuggets, patatas fritas, Fanta de Naranja y un delicioso Mini McFlurry KitKat de postre. Disfrútalo por tiempo limitado por sólo 10,90€";
            DescriptionImage.Source = new BitmapImage(new Uri("img/menu_sai.png", UriKind.RelativeOrAbsolute));
        }
        public void Mcflurry_Mil(object sender, RoutedEventArgs e)
        {
            DescriptionTextBlock.Text = "Perlas de Chocolate Blanco Milkybar con sirope de chocolate blanco. También puedes probarlo con otros siropes, como chocolate o caramelo.";
        }
        public void Mcdalena_Cho(object sender, RoutedEventArgs e)
        {
            DescriptionTextBlock.Text = "¡Ya está aquí! Nuestra esperada McDalena, muy tierna y con una fundente cobertura de chocolate.";
        }
        public void Spicy_Mcc(object sender, RoutedEventArgs e)
        {
            DescriptionTextBlock.Text = "Saca tu lado spicy con la nueva Spicy McCrispy®. Deliciosa hamburguesa de pollo compuesta por pollo crujiente y jugoso acompañado de deliciosa salsa Hot Habanero, lechuga, tomate y queso cheddar fundido. Todo ello envuelto en delicioso pan de patata. ¡Te encantará! Descubre también nuestra versión doble Spicy McCrispy®Doble. ¡Te esperamos!";
        }
        public void Mccrispy_ori(object sender, RoutedEventArgs e)
        {
            DescriptionTextBlock_1.Text = "Disfruta de nuestra hamburguesa McCrispy® Original, con jugoso pollo crujiente, nuevo pan tierno de harina de patata, irresistible salsa Original, queso cheddar, tomate y lechuga.";
        }
        public void Mcroyal_Del(object sender, RoutedEventArgs e)
        {
            DescriptionTextBlock_1.Text = "McRoyal Deluxe se destaca por su frescura, ya que es es la única hamburguesa de ternera que lleva tomate. Ven y pruébala ya, ahora más caliente, más jugosa y más sabrosa que nunca. Si aún no has probado nuestra hamburguesa McRoyal Deluxe® de McDonald's, ¡no esperes más! Corre a tu restaurante McDonald's más cercano. ¡Conviértelo en menú seleccionando tu complemento y bebida favorita!";
        }
        public void Cuarto_de(object sender, RoutedEventArgs e)
        {
            DescriptionTextBlock_1.Text = "Hamburguesa de carne, doble de queso, pepinillo, cebolla en tiras, kétchup y mostaza.";
        }
        public void Mcpollo(object sender, RoutedEventArgs e)
        {
            DescriptionTextBlock_1.Text = "Tu clásico de pollo, el que nunca falla. Disfruta de su crujiente pollo empanado acompañado de una cremosa salsa fina y lechuga fresca servido en un tierno pan con semillas de sésamo.\r\n\r\nMcPollo® es una de las opciones más populares en el menú de McDonald's, esta deliciosa hamburguesa cuenta con un filete de pollo empanado y crujiente, lechuga fresca y mayonesa, todo ello servido en un pan suave y esponjoso.";
        }
        public void Cbo(object sender, RoutedEventArgs e)
        {
            DescriptionTextBlock_1.Text = "¿Qué esperas para probar nuestra hamburguesa CBO®? Es una de las favoritas en McDonald's. Esta deliciosa hamburguesa es una combinación perfecta de pollo, bacon crujiente, crispy onion, queso Cheddar, lechuga y salsa CBO® todo envuelto en un pan exclusivo que hace que esta hamburguesa sea única.\r\nDescubre la combinación perfecta del bacon con la frescura de la cebolla y la jugosidad del pollo.";
        }
    }
        }