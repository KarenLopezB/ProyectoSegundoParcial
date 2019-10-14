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
    /// Lógica de interacción para Arroz__Frijol_y_Semillas.xaml
    /// </summary>
    public partial class Arroz__Frijol_y_Semillas : UserControl
    {
        public Arroz__Frijol_y_Semillas()
        {
            InitializeComponent();
        }

private void btnGuardarAFS_Click(object sender, RoutedEventArgs e)
        {
            //btnGuardarAFS.Visibility = Visibility.Hidden;
            //btnCancelarAFS.Visibility = Visibility.Hidden;
            //grdAFS.Children.Clear();

            if (txtNombreAFS.Text == "" || txtCodigoAFS.Text == "" || txtMarcaAFS.Text == "" || txtDescuentoASF.Text == "" || txtPrecioAFS.Text == "")
            {
                txtExceptionASF.Visibility = Visibility.Visible;
            
            }
            else
            {
                grdAFS.Children.Clear();
                txtNombreAFS.Visibility = Visibility.Hidden;
                txtCodigoAFS.Visibility = Visibility.Hidden;
                txtMarcaAFS.Visibility = Visibility.Hidden;
                txtPrecioAFS.Visibility = Visibility.Hidden;
                txtDescuentoASF.Visibility = Visibility.Hidden;
            }
        }

        private void btnCancelarAFS_Click(object sender, RoutedEventArgs e)
        {
            btnGuardarAFS.Visibility = Visibility.Hidden;
            btnCancelarAFS.Visibility = Visibility.Hidden;
            grdAFS.Children.Clear();
        }

        private void txtNombreAFS_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionASF.Visibility = Visibility.Hidden;
        }

        private void txtCodigoAFS_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionASF.Visibility = Visibility.Hidden;
        }

        private void txtMarcaAFS_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionASF.Visibility = Visibility.Hidden;
        }

        private void txtPrecioAFS_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionASF.Visibility = Visibility.Hidden;
        }

        private void txtDescuentoASF_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionASF.Visibility = Visibility.Hidden;
        }
    }
}
