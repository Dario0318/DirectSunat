using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Dominio.Entidades
{
    public class Corporacion
    {
        public int      codigoCorporacion { get; set;  }
        public string?  nombreCorporacion { get; set;  }


        // Colección de empresas
        public ICollection<Empresa> empresas { get; set; } = new List<Empresa>();
    }
}
