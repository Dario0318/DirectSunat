using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Dominio.Entidades
{
    public class Usuario
    {
        public int          codigoUsuario {  get; set;  }
        public string       nombreUsuario {  get; set;  }
        public string?      nombres       {  get; set;  }
        public string?      apellidos     {  get; set;  }
        public string       passwordHash  { get; set;   } = string.Empty;
        public string       passwordSalt  { get; set;   } = string.Empty;
        public string?      correo        {  get; set;  }
        public bool         EstadoUsuario { get; set;   }
        public DateTime     FechaCreacion { get; set;   }
        public int          CodRol        {  get; set;  }
    }
}
