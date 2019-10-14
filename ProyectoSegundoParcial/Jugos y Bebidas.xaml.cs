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

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para Jugos_y_Bebidas.xaml
    /// </summary>
    public partial class Jugos_y_Bebidas : UserControl
    {
        public Jugos_y_Bebidas()
        {
            InitializeComponent();
        }

        private void btnGuardarJB_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombreJB.Text == "" || txtCodigoJB.Text == "" || txtMarcaJB.Text == "" || txtDescuentoJB.Text == "" || txtPrecioJB.Text == "")
            {
                txtExceptionJB.Visibility = Visibility.Visible;

            }
            else
            {
                grdJB.Children.Clear();
            }
        }

        private void btnCancelarJB_Click(object sender, RoutedEventArgs e)
        {
            btnGuardarJB.Visibility = Visibility.Hidden;
            btnCancelarJB.Visibility = Visibility.Hidden;
            grdJB.Children.Clear();
        }

        private void txtNombreJB_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionJB.Visibility = Visibility.Hidden;
        }

        private void txtCodigoJB_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionJB.Visibility = Visibility.Hidden;
        }

        private void txtMarcaJB_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionJB.Visibility = Visibility.Hidden;
        }

        private void txtPrecioJB_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionJB.Visibility = Visibility.Hidden;
        }

        private void txtDescuentoJB_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionJB.Visibility = Visibility.Hidden;
        }
    }
}
