using DirectSunat.Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Negocio.Servicios
{
    internal class TipoDocumentoEmpresaServicio : ITipoDocumentoEmpresaServicio
    {
        private readonly ITipoDocumentoEmpresa _tipoDocumentoEmpresaRepositorio;

        public TipoDocumentoEmpresaServicio(ITipoDocumentoEmpresa tipoDocumentoEmpresaRepositorio)
        {
            _tipoDocumentoEmpresaRepositorio = tipoDocumentoEmpresaRepositorio;
        }

        public List<TipoDocumentoEmpresaDTO> ListarTiposDocumentoEmpresa()
        {
            var tiposDocumento = _tipoDocumentoEmpresaRepositorio.ObtenerTiposDocumentoEmpresa();
            var listaTiposDocumento = new List<TipoDocumentoEmpresaDTO>();

            foreach (var item in tiposDocumento)
            {
                listaTiposDocumento.Add(new TipoDocumentoEmpresaDTO
                {
                    IdTipoDocumentoEmpresa = item.IdTipoDocumentoEmpresa,
                    IdEmpresa              = item.IdEmpresa,
                    IdTipoDocumento        = item.IdTipoDocumento,
                    IndicadorActivacion    = item.IndicadorActivacion
                });
            }

            return listaTiposDocumento;
        }

        public void RegistrarNuevoTipoDocumentoEmpresa(TipoDocumentoEmpresaDTO tipoDocumentoEmpresaDTO)
        {
        }

        public void EditarTipoDocumentoEmpresa(TipoDocumentoEmpresaDTO tipoDocumentoEmpresaDTO)
        {
        }

        public void EliminarTipoDocumentoEmpresa(int idTipoDocumentoEmpresa)
        {
        }

        public void CambiarEstadoTipoDocumentoEmpresa(TipoDocumentoEmpresaDTO tipoDocumentoEmpresaDTO, bool indicadorActivacion)
        {
        }
    }
}

