using DirectSunat.Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectSunat.Negocio.Validadores
{
    class CorporacionValidador
    {
        #region "Propiedades"
        public string errorVariable { get; set; } = string.Empty;     
        public int    tipoMensaje { get; set; }
        #endregion

        public void ValidarNombreCorporacion(CorporacionDTO corporacionDTO) 
        {
            
            // Validamos que el nombre de la corporacion registrada o editada no esté vacío
            if (string.IsNullOrEmpty(corporacionDTO.NomCorporacion))
            {
                errorVariable = "El nombre de la corporación no puede estar vacío";
                tipoMensaje = 1; // Si el tipo mensaje es 1, entonces es un error
            }


            // Obtenemos la cantidad de letras del nombre de la corporacion
            int cantidadLetrasNombreCorporacion = corporacionDTO.NomCorporacion?.Trim().Length ?? 0; 
            // Validamos que la cantidad de letras de la corporacion no sea una sola letra
            if (cantidadLetrasNombreCorporacion == 1)
            {
                errorVariable = "¿Seguro de que desea guardar este nombre?";
                tipoMensaje = 2; // Si el tipo de mensaje es 2, entonces es una advertencia
            }
        }
    }
}
