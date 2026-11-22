using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Dominio.Entidades
{
    internal class SesionUsuario
    {
        public int          codigoSesion  { get; set; }
        public int          codigoUsuario { get; set; }
        public string       token         {  get; set; }
        public DateTime     fechaExpiracion { get; set; }
    }
}
