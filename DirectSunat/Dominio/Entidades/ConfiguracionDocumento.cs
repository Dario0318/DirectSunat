using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Dominio.Entidades
{
    public class ConfiguracionDocumento
    {
        public int     IdConfigDocumento        { get; set; }
        public int     IdTipoDocumento          { get; set; }
        public int     IdEmpresa                { get; set; }
        public string? NombreCampoPersonalizado { get; set; }
        public string? NombreCampoOriginal      { get; set; }
    }
}

