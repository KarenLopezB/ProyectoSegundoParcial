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
    /// Lógica de interacción para Cereales_y_Barras.xaml
    /// </summary>
    public partial class Cereales_y_Barras : UserControl
    {
        public Cereales_y_Barras()
        {
            InitializeComponent();
        }

        private void btnGuardarCB_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombreCB.Text == "" || txtCodigoCB.Text == "" || txtMarcaCB.Text == "" || txtDescuentoCB.Text == "" || txtPrecioCB.Text == "")
            {
                txtExceptionCB.Visibility = Visibility.Visible;

            }
            else
            {
                grdCB.Children.Clear();
            }
        }

        private void btnCancelarCB_Click(object sender, RoutedEventArgs e)
        {
            btnGuardarCB.Visibility = Visibility.Hidden;
            btnCancelarCB.Visibility = Visibility.Hidden;
            grdCB.Children.Clear();
        }

        private void txtNombreCB_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionCB.Visibility = Visibility.Hidden;
        }

        private void txtCodigoCB_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionCB.Visibility = Visibility.Hidden;
        }

        private void txtMarcaCB_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionCB.Visibility = Visibility.Hidden;
        }

        private void txtPrecioCB_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionCB.Visibility = Visibility.Hidden;
        }

        private void txtDescuentoCB_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExceptionCB.Visibility = Visibility.Hidden;
        }
    }
    
}
