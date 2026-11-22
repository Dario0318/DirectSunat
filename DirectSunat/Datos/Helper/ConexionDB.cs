using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Datos.Helper
{
    internal class ConexionDB
    {
        // Variable estática privada que contendrá la única instancia de la clase
        private static readonly Lazy<ConexionDB> _instance = new Lazy<ConexionDB>(() => new ConexionDB());

        // Propiedad que almacena la cadena de conexión
        private readonly string _cadenaConexion;
        // Constructor privado para evitar que se instancie con 'new ConexionDB()' desde afuera
        private ConexionDB()
        {
            // Aquí defines tu cadena por defecto
            // O puedes leerla desde un archivo de configuración cifrado / app.config
            _cadenaConexion = "Data Source=sunat_local.db;Cache=Shared;";
        }

        // Propiedad pública global para acceder a la única instancia
        public static ConexionDB Instance => _instance.Value;

        // Método para obtener la cadena de conexión en mayúsculas (o normal según requieras)
        public string ObtenerCadenaConexion()
        {
            return _cadenaConexion;
        }

        // Opcional: Si en algún momento el usuario cambia de SQLite a SQL Server o PostgreSQL,
        // este método permite actualizar la cadena de conexión en caliente en memoria.
        public string ActualizarCadenaConexion(string nuevaCadena)
        {
            // Lógica para actualizar si se requiere
            return _cadenaConexion;
        }
    }
}
