using DirectSunat.Datos.Helper;
using DirectSunat.Dominio.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Datos.Repositorios
{
    internal class CorporacionRepositorio : ICorporacion
    {
        // Se declara la variable de solo lectura para la conexión
        private readonly ConexionDB _conexion;

        public CorporacionRepositorio(ConexionDB conexion)
        {
            _conexion = conexion;
        }
        public Corporacion? ConsultarCorporacionCodigo(int codigoCorporacion)
        {
            //Creamos una instancia de la entidad corporacion
            Corporacion corporacion = new Corporacion();

            using (SqlConnection connection = new SqlConnection(_conexion.ObtenerCadenaConexion()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SIS_SP_GET_OBTENER_CORPORACION", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("PINT_IN_CODIGO_CORPORACION", codigoCorporacion));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        corporacion = new Corporacion
                        {
                            codigoCorporacion = (int)reader["codigo"] ,
                            nombreCorporacion = reader["nombre"].ToString(),
                            empresas = new List<Empresa>()
                        };

                        Empresa empresa = new Empresa
                        {
                            codigoEmpresa   = Convert.ToInt32(reader["codigoEmpresa"]),
                            nombreComercial = reader["nombreEmpresa"].ToString()
                        };
                        corporacion.empresas.Add(empresa);
                    }
                    return corporacion;
                }
            }
        }

        public void CrearCorporacion(Corporacion corporacion)
        {
            //Se crea la cadena de conexión
            using (SqlConnection con = new SqlConnection(_conexion.ObtenerCadenaConexion()))
            {
                //Abrimos la conexión
                con.Open();

                SqlCommand cmd = new SqlCommand("SIS_SP_SET_CREAR_CORPORACION", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // indicamos qué se va a ejecutar
                cmd.Parameters.Add(new SqlParameter("PINT_IN_CODIGO_CORPORACION", corporacion.codigoCorporacion));
                cmd.Parameters.Add(new SqlParameter("PINT_IN_NOMBRE_CORPORACION", corporacion.nombreCorporacion));
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarCorporacion(Corporacion corporacion)
        {
            //Se crea la cadena de conexión
            using (SqlConnection con = new SqlConnection(_conexion.ObtenerCadenaConexion()))
            {
                //Abrimos la conexión
                con.Open();

                SqlCommand cmd = new SqlCommand("SIS_SP_SET_EDITAR_CORPORACION", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // indicamos qué se va a ejecutar
                cmd.Parameters.Add(new SqlParameter("PINT_IN_CODIGO_CORPORACION", corporacion.codigoCorporacion));
                cmd.Parameters.Add(new SqlParameter("PINT_IN_NOMBRE_CORPORACION", corporacion.nombreCorporacion));
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCorporacion(int codigoCorporacion)
        {
            //Se crea la cadena de conexión
            using (SqlConnection con = new SqlConnection(_conexion.ObtenerCadenaConexion()))
            {
                //Abrimos la conexión
                con.Open();

                SqlCommand cmd = new SqlCommand("SIS_SP_SET_EDITAR_CORPORACION", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // indicamos qué se va a ejecutar
                cmd.Parameters.Add(new SqlParameter("PINT_IN_CODIGO_CORPORACION", codigoCorporacion));
                cmd.ExecuteNonQuery();
            }
        }

        public List<Corporacion> ObtenerCorporaciones()
        {
            // Crear instancia de la lista de corporaciones
            List<Corporacion> corporaciones = null; 

            using (SqlConnection conn = new SqlConnection( _conexion.ObtenerCadenaConexion()))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SIS_SP_GET_OBTENER_CORPORACIONES", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Corporacion cor = new Corporacion
                        {
                            codigoCorporacion = Convert.ToInt32(reader["codigo"]),
                            nombreCorporacion = reader["nombre"].ToString(),
                            empresas = new List<Empresa>()
                        };

                        Empresa empresa = new Empresa
                        {
                            codigoEmpresa = Convert.ToInt32(reader["codigo"]),
                            nombreComercial = Convert.ToString(reader["nombre"])
                        };

                        cor.empresas.Add(empresa);
                        corporaciones.Add(cor);
                    }
                    return corporaciones;
                }
            }
        }
    }
}
