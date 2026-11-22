using DirectSunat.Negocio.DTOs;
using DirectSunat.Negocio.Validadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Negocio.Servicios
{
    internal class CorporacionServicio: ICorporacionServicio
    {
        // Traer la interfaz
        private readonly ICorporacion _corporacionRepositorio;
        // Traer el validador 
        public CorporacionServicio(ICorporacion corporacionRepositorio)
        {
            _corporacionRepositorio = corporacionRepositorio;
        }

        public List<CorporacionDTO> ListarCorporaciones()
        {
            // Obtener las corporaciones desde el repositorio
            var corporaciones =  _corporacionRepositorio.ObtenerCorporaciones();

            // Mapear entidades de dominio a DTOs
            var ListaCorporaciones = new List<CorporacionDTO>();
            foreach (var corp in corporaciones)
            {
                ListaCorporaciones.Add(new CorporacionDTO
                {
                    codCorporacion = corp.codigoCorporacion,
                    NomCorporacion = corp.nombreCorporacion
                });
            }
            return ListaCorporaciones;
        }

        public void RegistrarNuevaCorporacion(CorporacionDTO corporacionDTO)
        {
            // Realizamos las validaciones correspondientes
            CorporacionValidador validador = new CorporacionValidador();
            validador.ValidarNombreCorporacion(corporacionDTO);

            if (string.IsNullOrEmpty(validador.errorVariable))
            {
                //throw new ValidadorExcepcion(validador.errorVariable, validador.tipoMensaje);
            }

            // Si pasa la validación entonces lo registramos
        }

        public void EditarCorporacion(CorporacionDTO corporacionDTO) 
        {
            
        }

        public void EliminarCorporacion(int codigoCorporacion) 
        {
        
        }
        
    }
}
