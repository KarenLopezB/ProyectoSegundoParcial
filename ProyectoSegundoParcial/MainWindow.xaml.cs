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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbInterfaz_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            //btnGuardar.Visibility = Visibility.Visible;
            //btnCancelar.Visibility = Visibility.Visible;

            grdInterfaz.Children.Clear();
            switch (cbInterfaz.SelectedIndex)
            {
                case 0: //Arroz, Frijol y Semillas
                    grdInterfaz.Children.
                        Add(new Arroz__Frijol_y_Semillas());
                    break;
                default:
                    break;
                case 1: // Cereales y Barras
                    grdInterfaz.Children.
                        Add(new Cereales_y_Barras());
                    break;
                case 2: // Pastas
                    grdInterfaz.Children.
                        Add(new Pastas());
                    break;
                case 3: // Enlatados y Conservas
                    grdInterfaz.Children.
                        Add(new Enlatados_y_Conservas());
                    break;
                case 4: // Salsa, Aderezos y Vinagre
                    grdInterfaz.Children.
                        Add(new Salsa__Aderezos_y_Vinagre());
                    break;
                case 5: // Jugos y Bebidas
                    grdInterfaz.Children.
                        Add(new Jugos_y_Bebidas());
                    break;
            }
        }

        //private void btnGuardar_Click(object sender, RoutedEventArgs e)
        //{
          //  btnGuardar.Visibility = Visibility.Hidden;
            //btnCancelar.Visibility = Visibility.Hidden;
          //  grdInterfaz.Children.Clear();
        //}

        //private void btnCancelar_Click(object sender, RoutedEventArgs e)
        //{
          //  btnGuardar.Visibility = Visibility.Hidden;
          //  btnCancelar.Visibility = Visibility.Hidden;
          //  grdInterfaz.Children.Clear();
        //}
    }
}
