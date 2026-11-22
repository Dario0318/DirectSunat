using DirectSunat.Presentación.Módulos;
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

namespace DirectSunat.Presentación.Panel
{
    /// <summary>
    /// Lógica de interacción para WPF_Panel.xaml
    /// </summary>
    public partial class WPF_Panel : Window
    {
        // El panel inicia completamente expandido al inicializar el proyecto
        private bool _isSidebarExpanded = true;

        private readonly SolidColorBrush _activeTabBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6A1B9A"));
        private readonly SolidColorBrush _inactiveTabBrush = Brushes.Transparent;

        public WPF_Panel()
        {
            InitializeComponent();
            ExpandirPanelCompletamente();
            SeleccionarPestana("Dashboard", BtnTabDashboard, new WPF_Dashboard());
        }

        private void ExpandirPanelCompletamente()
        {
            _isSidebarExpanded = true;
            SidebarColumn.Width = new GridLength(240);
            BrandTitlePanel.Visibility = Visibility.Visible;
            TxtTabDashboard.Visibility = Visibility.Visible;
            TxtTabUsuarios.Visibility = Visibility.Visible;
            TxtTabConfiguracion.Visibility = Visibility.Visible;
            PanelDatosUsuario.Visibility = Visibility.Visible;
            WindowState = WindowState.Maximized;
        }

        private void BtnToggleSidebar_Click(object sender, RoutedEventArgs e)
        {
            _isSidebarExpanded = !_isSidebarExpanded;

            if (_isSidebarExpanded)
            {
                SidebarColumn.Width = new GridLength(240);
                BrandTitlePanel.Visibility = Visibility.Visible;
                TxtTabDashboard.Visibility = Visibility.Visible;
                TxtTabUsuarios.Visibility = Visibility.Visible;
                TxtTabConfiguracion.Visibility = Visibility.Visible;
                PanelDatosUsuario.Visibility = Visibility.Visible;
            }
            else
            {
                SidebarColumn.Width = new GridLength(68);
                BrandTitlePanel.Visibility = Visibility.Collapsed;
                TxtTabDashboard.Visibility = Visibility.Collapsed;
                TxtTabUsuarios.Visibility = Visibility.Collapsed;
                TxtTabConfiguracion.Visibility = Visibility.Collapsed;
                PanelDatosUsuario.Visibility = Visibility.Collapsed;
            }
        }

        private void SeleccionarPestana(string titulo, Button botonActivo, UserControl moduloVista)
        {
            TxtSectionTitle.Text = titulo;

            // Actualizar color de pestaña activa
            BtnTabDashboard.Background = _inactiveTabBrush;
            BtnTabUsuarios.Background = _inactiveTabBrush;
            BtnTabConfiguracion.Background = _inactiveTabBrush;
            botonActivo.Background = _activeTabBrush;

            // Cargar la vista del módulo seleccionado en el panel
            ContenedorModulo.Content = moduloVista;
        }

        private void BtnTabDashboard_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPestana("Dashboard", BtnTabDashboard, new WPF_Dashboard());
        }

        private void BtnTabUsuarios_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPestana("Usuarios", BtnTabUsuarios, new WPF_Usuarios());
        }

        private void BtnTabConfiguracion_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPestana("Configuración", BtnTabConfiguracion, new WPF_Configuracion());
        }
    }
}
