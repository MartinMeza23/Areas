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

namespace Area
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Btnresolver1_Click(object sender, RoutedEventArgs e)
        {
            double rectangulo1 = double.Parse(txtrectangulo1.Text);

            double rectangulo2 = double.Parse(txtrectangulo2.Text);

            double resultado1 = rectangulo1 * rectangulo2;

            lblarearectangulo.Text = resultado1.ToString();

        }

        private void Btnresolver2_Click(object sender, RoutedEventArgs e)
        {
            double triangulo1 = double.Parse(txttriangulo1.Text);

            double triangulo2 = double.Parse(txttriangulo2.Text);

            double resultado2 = ((triangulo1 * triangulo2) / 2);

            lblareatriangulo.Text = resultado2.ToString();

        }

        private void Btnresolver3_Click(object sender, RoutedEventArgs e)
        {
            double circulo1 = double.Parse(txtcirculo.Text);

            double resultado3 = Math.PI * (circulo1 * circulo1);

            lblareacirculo.Text = resultado3.ToString();

        }

        private void Btnresolver4_Click(object sender, RoutedEventArgs e)
        {
            double trapecio1 = double.Parse(txttrapecio1.Text);

            double trapecio2 = double.Parse(txttrapecio2.Text);

            double trapecio3 = double.Parse(txttrapecio3.Text);

            double resultado4 = ((trapecio1 + trapecio2) * trapecio3) / 2;

            lblareatrapecio.Text = resultado4.ToString();

        }
    }
}
