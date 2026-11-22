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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DirectSunat.Presentación.Módulos
{
    /// <summary>
    /// Lógica de interacción para WPF_Configuracion.xaml
    /// </summary>
    public partial class WPF_Configuracion : UserControl
    {
        private readonly SolidColorBrush _activeSubMenuBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B1FA2"));
        private readonly SolidColorBrush _inactiveSubMenuBrush = Brushes.Transparent;

        public class CorporacionEjemploItem
        {
            public int Id { get; set; }
            public string Nombre { get; set; } = string.Empty;
        }

        public class EmpresaEjemploItem
        {
            public int Id { get; set; }
            public string RazonSocial { get; set; } = string.Empty;
            public string RUC { get; set; } = string.Empty;
            public string Corporacion { get; set; } = string.Empty;
        }

        public WPF_Configuracion()
        {
            InitializeComponent();
            CargarDatosEjemplo();
        }

        private void CargarDatosEjemplo()
        {
            // Registro de ejemplo para la grilla de Corporaciones
            var listaCorporaciones = new List<CorporacionEjemploItem>
            {
                new CorporacionEjemploItem
                {
                    Id = 1,
                    Nombre = "Corporación Grupo Andino S.A.C."
                }
            };
            dgvCorporaciones.ItemsSource = listaCorporaciones;

            // Registro de ejemplo para la grilla de Empresas
            var listaEmpresas = new List<EmpresaEjemploItem>
            {
                new EmpresaEjemploItem
                {
                    Id = 1,
                    RazonSocial = "Inversiones Tecnológicas del Pacífico S.A.C.",
                    RUC = "20601234567",
                    Corporacion = "Corporación Grupo Andino S.A.C."
                }
            };
            dgvEmpresas.ItemsSource = listaEmpresas;
        }

        private void SeleccionarApartado(Button botonActivo, UIElement vistaActiva)
        {
            // Actualizar estado visual de los botones del panel interno
            BtnSubCorporaciones.Background = _inactiveSubMenuBrush;
            BtnSubEmpresas.Background = _inactiveSubMenuBrush;
            BtnSubConfigurarDocumentos.Background = _inactiveSubMenuBrush;
            BtnSubPersonalizar.Background = _inactiveSubMenuBrush;
            botonActivo.Background = _activeSubMenuBrush;

            // Mostrar únicamente el apartado seleccionado
            ViewCorporaciones.Visibility = Visibility.Collapsed;
            ViewEmpresas.Visibility = Visibility.Collapsed;
            ViewConfigurarDocumentos.Visibility = Visibility.Collapsed;
            ViewPersonalizar.Visibility = Visibility.Collapsed;
            vistaActiva.Visibility = Visibility.Visible;
        }

        private void BtnSubCorporaciones_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarApartado(BtnSubCorporaciones, ViewCorporaciones);
        }

        private void BtnSubEmpresas_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarApartado(BtnSubEmpresas, ViewEmpresas);
        }

        private void BtnSubConfigurarDocumentos_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarApartado(BtnSubConfigurarDocumentos, ViewConfigurarDocumentos);
        }

        private void BtnSubPersonalizar_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarApartado(BtnSubPersonalizar, ViewPersonalizar);
        }
    }
}
