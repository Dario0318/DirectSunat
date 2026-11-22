using DirectSunat.Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Negocio.Servicios
{
    internal class RespuestaSunatServicio : IRespuestaSunatServicio
    {
        private readonly IRespuestaSunat _respuestaSunatRepositorio;

        public RespuestaSunatServicio(IRespuestaSunat respuestaSunatRepositorio)
        {
            _respuestaSunatRepositorio = respuestaSunatRepositorio;
        }

        public List<RespuestaSunatDTO> ListarRespuestasSunat()
        {
            var respuestas = _respuestaSunatRepositorio.ObtenerRespuestasSunat();
            var listaRespuestas = new List<RespuestaSunatDTO>();

            foreach (var resp in respuestas)
            {
                listaRespuestas.Add(new RespuestaSunatDTO
                {
                    IdDocumento         = resp.IdDocumento,
                    IdEmpresa           = resp.IdEmpresa,
                    IdTipoDocumento     = resp.IdTipoDocumento,
                    NumeroSerie         = resp.NumeroSerie,
                    Correlativo         = resp.Correlativo,
                    JsonPayloadRecibido = resp.JsonPayloadRecibido,
                    EstadoSunat         = resp.EstadoSunat,
                    FechaEmision        = resp.FechaEmision,
                    FechaEnvioSunat     = resp.FechaEnvioSunat,
                    IndicadorActivacion = resp.IndicadorActivacion
                });
            }

            return listaRespuestas;
        }

        public void RegistrarNuevaRespuestaSunat(RespuestaSunatDTO respuestaSunatDTO)
        {
        }

        public RespuestaSunatDTO? ConsultarRespuestaSunatCodigo(int idDocumento)
        {
            return null;
        }
    }
}

