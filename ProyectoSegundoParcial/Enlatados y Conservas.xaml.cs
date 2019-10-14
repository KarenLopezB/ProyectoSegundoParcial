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
    /// Lógica de interacción para Enlatados_y_Conservas.xaml
    /// </summary>
    public partial class Enlatados_y_Conservas : UserControl
    {
        public Enlatados_y_Conservas()
        {
            InitializeComponent();
        }

        private void btnGuardarEC_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombreEC.Text == "" || txtCodigoEC.Text == "" || txtMarcaEC.Text == "" || txtDescuentoEC.Text == "" || txtPrecioEC.Text == "")
            {
                txtExceptionEC.Visibility = Visibility.Visible;

            }
            else
            {
                grdEC.Children.Clear();
            }
        }

        private void btnCancelarEC_Click(object sender, RoutedEventArgs e)
        {
            btnGuardarEC.Visibility = Visibility.Hidden;
            btnCancelarEC.Visibility = Visibility.Hidden;
            grdEC.Children.Clear();
        }

        private void txtNombreEC_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionEC.Visibility = Visibility.Hidden;
        }

        private void txtCodigoEC_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionEC.Visibility = Visibility.Hidden;
        }

        private void txtMarcaEC_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionEC.Visibility = Visibility.Hidden;
        }

        private void txtPrecioEC_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionEC.Visibility = Visibility.Hidden;
        }

        private void txtDescuentoEC_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionEC.Visibility = Visibility.Hidden;
        }
    }
}
