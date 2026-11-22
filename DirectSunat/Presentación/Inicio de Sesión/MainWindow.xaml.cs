using DirectSunat.Negocio.Servicios;
using System.Security;
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

namespace DirectSunat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            // Obtenemos los valores 
            string NombreUsuario = txtNomUsuario.Text;
            SecureString Contraseña = txtContraseña.SecurePassword;

            MessageBox.Show($"Usuario: {NombreUsuario} - Contraseña: {Contraseña}");

            // Se lo pasamos al servicio con delegados....
        }
    }
}