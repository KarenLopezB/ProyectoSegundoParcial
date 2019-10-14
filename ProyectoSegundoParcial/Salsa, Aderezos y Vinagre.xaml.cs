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
    /// Lógica de interacción para Salsa__Aderezos_y_Vinagre.xaml
    /// </summary>
    public partial class Salsa__Aderezos_y_Vinagre : UserControl
    {
        public Salsa__Aderezos_y_Vinagre()
        {
            InitializeComponent();
        }

        private void btnGuardarSAV_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombreSAV.Text == "" || txtCodigoSAV.Text == "" || txtMarcaSAV.Text == "" || txtDescuentoSAV.Text == "" || txtPrecioSAV.Text == "")
            {
                txtExceptionSAV.Visibility = Visibility.Visible;

            }
            else
            {
                grdSAV.Children.Clear();
            }
        }

        private void btnCancelarSAV_Click(object sender, RoutedEventArgs e)
        {
            btnGuardarCB.Visibility = Visibility.Hidden;
            btnCancelarCB.Visibility = Visibility.Hidden;
            grdSAV.Children.Clear();
        }

        private void txtNombreSAV_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionSAV.Visibility = Visibility.Hidden;
        }

        private void txtCodigoSAV_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionSAV.Visibility = Visibility.Hidden;
        }

        private void txtMarcaSAV_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionSAV.Visibility = Visibility.Hidden;
        }

        private void txtPrecioSAV_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionSAV.Visibility = Visibility.Hidden;
        }

        private void txtDescuentoSAV_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionSAV.Visibility = Visibility.Hidden;
        }
    }
}
