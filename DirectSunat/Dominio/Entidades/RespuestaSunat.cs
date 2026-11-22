using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Dominio.Entidades
{
    public class RespuestaSunat
    {
        public int      IdDocumento         { get; set; }
        public int      IdEmpresa           { get; set; }
        public int      IdTipoDocumento     { get; set; }
        public string?  NumeroSerie         { get; set; }
        public string?  Correlativo         { get; set; }
        public string?  JsonPayloadRecibido { get; set; }
        public string?  EstadoSunat         { get; set; }
        public DateTime FechaEmision        { get; set; }
        public DateTime FechaEnvioSunat     { get; set; }
        public bool     IndicadorActivacion { get; set; }
    }
}

