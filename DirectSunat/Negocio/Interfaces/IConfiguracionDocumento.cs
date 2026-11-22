using DirectSunat.Dominio.Entidades;
using DirectSunat.Negocio.DTOs;

public interface IConfiguracionDocumentoServicio
{
    List<ConfiguracionDocumentoDTO> ListarConfiguracionesDocumento();
    void RegistrarNuevaConfiguracionDocumento(ConfiguracionDocumentoDTO configuracionDocumentoDTO);
    void EditarConfiguracionDocumento(ConfiguracionDocumentoDTO configuracionDocumentoDTO);
    void EliminarConfiguracionDocumento(int idConfigDocumento);
}

