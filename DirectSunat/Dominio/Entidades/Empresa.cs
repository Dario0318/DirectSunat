using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Dominio.Entidades
{
    public class Empresa
    {
        public int     codigoEmpresa     { get; set; }
        public string? razonSocial       { get; set; }
        public string? nombreComercial   { get; set; }
        public int     numeroRUC         { get; set; }
        public int     codigoCorporacion { get; set; }
        public int     codigoEstado      {  get; set; }
    }
}
