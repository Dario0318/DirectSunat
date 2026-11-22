using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Negocio.DTOs
{
    public class TipoDocumentoDTO
    {
        public int     IdTipoDocumento  { get; set; }
        public string? NomTipoDocumento { get; set; }
        public string? Descripcion      { get; set; }
    }
}

