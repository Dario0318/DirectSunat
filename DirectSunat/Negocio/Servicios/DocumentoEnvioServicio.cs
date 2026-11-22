using DirectSunat.Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Negocio.Servicios
{
    internal class DocumentoEnvioServicio : IDocumentoEnvioServicio
    {
        private readonly IDocumentoEnvio _documentoEnvioRepositorio;

        public DocumentoEnvioServicio(IDocumentoEnvio documentoEnvioRepositorio)
        {
            _documentoEnvioRepositorio = documentoEnvioRepositorio;
        }

        public List<RespuestaSunatDTO> ListarDocumentosEnvio()
        {
            var documentos = _documentoEnvioRepositorio.ObtenerDocumentosEnvio();
            var listaDocumentos = new List<RespuestaSunatDTO>();

            foreach (var doc in documentos)
            {
                listaDocumentos.Add(new RespuestaSunatDTO
                {
                    IdDocumento         = doc.IdDocumento,
                    IdEmpresa           = doc.IdEmpresa,
                    IdTipoDocumento     = doc.IdTipoDocumento,
                    NumeroSerie         = doc.NumeroSerie,
                    Correlativo         = doc.Correlativo,
                    JsonPayloadRecibido = doc.JsonPayloadRecibido,
                    EstadoSunat         = doc.EstadoSunat,
                    FechaEmision        = doc.FechaEmision,
                    FechaEnvioSunat     = doc.FechaEnvioSunat,
                    IndicadorActivacion = doc.IndicadorActivacion
                });
            }

            return listaDocumentos;
        }

        public void RegistrarNuevoDocumentoEnvio(RespuestaSunatDTO documentoEnvioDTO)
        {
        }

        public void EditarDocumentoEnvio(RespuestaSunatDTO documentoEnvioDTO)
        {
        }

        public void EliminarDocumentoEnvio(int idDocumento)
        {
        }
    }
}

