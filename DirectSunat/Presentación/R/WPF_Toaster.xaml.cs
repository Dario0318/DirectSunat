using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DirectSunat.Presentación.R
{
    /// <summary>
    /// Lógica de interacción para WPF_Toaster.xaml
    /// </summary>
    public partial class WPF_Toaster : Window
    {
        // Variables de inicialización
        private string MensajeToaster; // Indica el mensaje que se mostrará en el toaster
        private int tipoRespuesta; // dependiendo del tipo el color va a variar


        public WPF_Toaster()
        {
            InitializeComponent();
        }

        private void WPF_Toaster1_Loaded(object sender, RoutedEventArgs e)
        {
            switch (tipoRespuesta)
            {
                case 1:
                    lblIndicadorColor.Background = Brushes.Red;
                    lblTextoIndicador.Content = "Ups! Hubo un error";
                    break;
                case 2:
                    lblTextoIndicador.Background = Brushes.Green;
                    lblTextoIndicador.Content = "Creado Exitosamente";
                    break;
                case 3:
                    lblTextoIndicador.Content = "EditadoExitosamente";
                    lblIndicadorColor.Background = Brushes.Blue;
                    break;
                default:
                    break;
            }
        }

        private void btnCerrarToaster_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
