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
    /// Lógica de interacción para Pastas.xaml
    /// </summary>
    public partial class Pastas : UserControl
    {
        public Pastas()
        {
            InitializeComponent();
        }

        private void btnGuardarP_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombreP.Text == "" || txtCodigoP.Text == "" || txtMarcaP.Text == "" || txtDescuentoP.Text == "" || txtPrecioP.Text == "")
            {
                txtExceptionP.Visibility = Visibility.Visible;

            }
            else
            {
                grdP.Children.Clear();
            }
        }

        private void btnCancelarP_Click(object sender, RoutedEventArgs e)
        {
            btnGuardarP.Visibility = Visibility.Hidden;
            btnCancelarP.Visibility = Visibility.Hidden;
            grdP.Children.Clear();
        }

        private void txtNombreP_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionP.Visibility = Visibility.Hidden;
        }

        private void txtCodigoP_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionP.Visibility = Visibility.Hidden;
        }

        private void txtMarcaP_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionP.Visibility = Visibility.Hidden;
        }

        private void txtPrecioP_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionP.Visibility = Visibility.Hidden;
        }

        private void txtDescuentoP_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionP.Visibility = Visibility.Hidden;
        }
    }
}
