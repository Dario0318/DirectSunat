using DirectSunat.Dominio.Entidades;
using DirectSunat.Negocio.DTOs;

public interface IDocumentoEnvioServicio
{
    List<RespuestaSunatDTO> ListarDocumentosEnvio();
    void RegistrarNuevoDocumentoEnvio(RespuestaSunatDTO documentoEnvioDTO);
    void EditarDocumentoEnvio(RespuestaSunatDTO documentoEnvioDTO);
    void EliminarDocumentoEnvio(int idDocumento);
}

