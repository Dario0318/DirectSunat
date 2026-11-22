using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Negocio.DTOs
{
    public class TipoDocumentoEmpresaDTO
    {
        public int  IdTipoDocumentoEmpresa { get; set; }
        public int  IdEmpresa              { get; set; }
        public int  IdTipoDocumento        { get; set; }
        public bool IndicadorActivacion    { get; set; }
    }
}

