using DirectSunat.Dominio.Entidades;
using DirectSunat.Negocio.DTOs;

public interface ITipoDocumentoEmpresaServicio
{
    List<TipoDocumentoEmpresaDTO> ListarTiposDocumentoEmpresa();
    void RegistrarNuevoTipoDocumentoEmpresa(TipoDocumentoEmpresaDTO tipoDocumentoEmpresaDTO);
    void EditarTipoDocumentoEmpresa(TipoDocumentoEmpresaDTO tipoDocumentoEmpresaDTO);
    void EliminarTipoDocumentoEmpresa(int idTipoDocumentoEmpresa);
    void CambiarEstadoTipoDocumentoEmpresa(TipoDocumentoEmpresaDTO tipoDocumentoEmpresaDTO, bool indicadorActivacion);
}

