using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Dominio.Entidades
{
    internal class DocumentoEnvio
    {
        public int    codigoEmpresa       {  get; set; }
        public int    codigoTipoDocumento { get; set;  }
        public string rutaXML             { get; set;  }
        public string rutaPDF             {  get; set; }
        public string rutaCDR             {  get; set; }

    }
}
