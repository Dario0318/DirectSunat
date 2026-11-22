using DirectSunat.Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Negocio.Servicios
{
    internal class ConfiguracionDocumentoServicio : IConfiguracionDocumentoServicio
    {
        private readonly IConfiguracionDocumento _configuracionDocumentoRepositorio;

        public ConfiguracionDocumentoServicio(IConfiguracionDocumento configuracionDocumentoRepositorio)
        {
            _configuracionDocumentoRepositorio = configuracionDocumentoRepositorio;
        }

        public List<ConfiguracionDocumentoDTO> ListarConfiguracionesDocumento()
        {
            var configuraciones = _configuracionDocumentoRepositorio.ObtenerConfiguracionesDocumento();
            var listaConfiguraciones = new List<ConfiguracionDocumentoDTO>();

            foreach (var config in configuraciones)
            {
                listaConfiguraciones.Add(new ConfiguracionDocumentoDTO
                {
                    IdConfigDocumento        = config.IdConfigDocumento,
                    IdTipoDocumento          = config.IdTipoDocumento,
                    IdEmpresa                = config.IdEmpresa,
                    NombreCampoPersonalizado = config.NombreCampoPersonalizado,
                    NombreCampoOriginal      = config.NombreCampoOriginal
                });
            }

            return listaConfiguraciones;
        }

        public void RegistrarNuevaConfiguracionDocumento(ConfiguracionDocumentoDTO configuracionDocumentoDTO)
        {
        }

        public void EditarConfiguracionDocumento(ConfiguracionDocumentoDTO configuracionDocumentoDTO)
        {
        }

        public void EliminarConfiguracionDocumento(int idConfigDocumento)
        {
        }
    }
}

